using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace SubmarineControlSystem
{
    class Controller
    {
        //imports
        private readonly SubControlDashboard subDashboard;

        //sees
        private readonly KeyTorpedo tKey;
        private readonly OxygenMonitor oxyMonitor;
        private readonly TempMonitor tempMonitor;
        private AirlockDoorMonitor doorMonitor;
        private readonly RadarMonitor radarMonitor;
        private readonly DepthMonitor depthMonitor;

        private OxygenState oxygenState = OxygenState.highOxygen;
        private AirlockDoorState doorState = AirlockDoorState.twoClosed;
        private TempState tempState = TempState.lowTemp;
        private RadarState radarState = RadarState.noDetection;

        public Controller(KeyTorpedo tKey, OxygenMonitor oxyMonitor, TempMonitor tempMonitor, AirlockDoorMonitor doorMonitor, RadarMonitor radarMonitor, DepthMonitor depthMonitor, int maxDepth)
        {
            //// sees -> insure the parameters are not null
            Contract.Requires(tKey != null);
            Contract.Requires(oxyMonitor != null);
            Contract.Requires(tempMonitor != null);
            Contract.Requires(doorMonitor != null);
            Contract.Requires(radarMonitor != null);
            Contract.Requires(depthMonitor != null);

            this.tKey = tKey;
            this.oxyMonitor = oxyMonitor;
            this.tempMonitor = tempMonitor;
            this.doorMonitor = doorMonitor;
            this.radarMonitor = radarMonitor;
            this.depthMonitor = depthMonitor;

            // Imports
            subDashboard = new SubControlDashboard();

            // a => b is equivalent to (not a) or b
            // When there is one door closed the sub dashboard start light should be turned on
            Contract.Invariant(!(doorState == AirlockDoorState.oneClosed) || subDashboard.subStartLight == SubControlState.on);
            // When there is two doors closed the sub dashboard start light should be turned on
            Contract.Invariant(!(doorState == AirlockDoorState.twoClosed) || subDashboard.subStartLight == SubControlState.on);
            // When the temperature is high the dashboard temperature light should be turned on
            Contract.Invariant(!(tempState == TempState.highTemp) || subDashboard.temperature == SubControlState.on);
            // When the oxygen is low the dashboard low oxygen light warning must be on
            Contract.Invariant(!(oxygenState == OxygenState.lowOxygen) || subDashboard.lowOxygenLight == SubControlState.on);
            // When there is no oxygen is the dashboard no oxygen warning must be on
            Contract.Invariant(!(oxygenState == OxygenState.noOxygen) || subDashboard.NoOxygen == SubControlState.on);
            // When there is a sub closeby the dashboard radar warning must be on
            Contract.Invariant(!(radarState == RadarState.yesDetection) || subDashboard.radar == SubControlState.on);
        }

        public void operateStructured()
        {
            //structured outcome method

            //checks if one of more doors are locked
            if (doorState == AirlockDoorState.oneClosed || doorState == AirlockDoorState.twoClosed)
            {
                subDashboard.subStartlightOn();

                tKey.getKeyState();

                //checks oxygen levels
                if (oxygenState == OxygenState.highOxygen)
                {
                    subDashboard.lowOxygenLightOff();
                }
                else if (oxygenState == OxygenState.lowOxygen)
                {
                    subDashboard.lowOxygenLightOn();
                }
                else if (oxygenState == OxygenState.noOxygen)
                {
                    subDashboard.noOxygen();
                }

                //checks if reactor temp is too high
                if (tempState == TempState.highTemp)
                {
                    subDashboard.tempTooHigh();
                }
                else
                {
                    subDashboard.tempOk();
                }

                //checks if there is a sub closeby
                if (radarState == RadarState.yesDetection)
                {
                    subDashboard.radarDetection();
                }
                else
                {
                    subDashboard.radarNoDetection();
                }

                Random rnd = new Random();
                int depth = rnd.Next(1, 200);

                Console.WriteLine("Current Depth: " + depth);

                if(depth > 100)
                {
                    subDashboard.maxDepth();
                }
                else
                {
                    subDashboard.DepthOK();
                }
            }
            else
            {
                subDashboard.subStartLightOff();
            }
        }

        //random outcome method
        public void operateRandom()
        {
            doorMonitor.getDoorState();
            tKey.getKeyState();
            oxyMonitor.getOxygenLevel();
            tempMonitor.getTempLevel();
            radarMonitor.getRadarLevel();

            Random rnd = new Random();
            int depth = rnd.Next(1, 200);

            Console.WriteLine("Current Depth: " + depth);

            if (depth > 100)
            {
                subDashboard.maxDepth();
            }
            else
            {
                subDashboard.DepthOK();
            }
            depthMonitor.getCurrentDepth();
        }

        /* Test Methods 
        // Some of these methods by design brake the invariant on the controller -> hence the ContractVerification(false) -> don't try and prove them
        // Also those that don't aren't being called while the operate loop is being called -> dont account for them
        
        // Test whether the torpedo can be fired while the key had been withdrawn
        [ContractVerification(false)]
        public void key_withdrawn_test()
        {
            keytorpedo_state = KeyTorpedoState.keyOut;
            engineinterface.set_engine_good();
            engineinterface.engine_turn_on();
        }


        // expected to be good 
        [ContractVerification(false)]
        public void key_with_key_test()
        {
            ignition_state = IgnitionState.inserted_key;
            engineinterface.set_engine_good();
            engineinterface.engine_turn_on();
        }


        // Expected to fail
        [ContractVerification(false)]
        public void engine_failure_brakes_good_not_applied_test()
        {
            ignition_state = IgnitionState.inserted_key;
            engineinterface.set_engine_good();
            engineinterface.engine_turn_on();
            brakeinterface.set_brake_good();
            engineinterface.set_engine_bad();
            brakeinterface.release_brakes();
        }

        // expected to be good
        [ContractVerification(false)]
        public void engine_failure_brakes_good_applied_test()
        {
            ignition_state = IgnitionState.inserted_key;
            engineinterface.set_engine_good();
            engineinterface.engine_turn_on();
            brakeinterface.set_brake_good();
            engineinterface.set_engine_bad();
            brakeinterface.apply_brakes();
        }

        // Expected to fail
        [ContractVerification(false)]
        public void brakes_failed_engine_running_test()
        {
            ignition_state = IgnitionState.inserted_key;
            engineinterface.set_engine_good();
            engineinterface.engine_turn_on();
            brakeinterface.set_brake_bad();
        }

        // expected to be good
        [ContractVerification(false)]
        public void brakes_failed_engine_off_test()
        {
            ignition_state = IgnitionState.inserted_key;
            engineinterface.set_engine_good();
            engineinterface.engine_turn_on();
            brakeinterface.set_brake_bad();
            engineinterface.engine_turn_off();
        }


        // Expected to fail
        [ContractVerification(false)]
        public int failed_to_go_above_maximum_speed_test()
        {
            ignition_state = IgnitionState.inserted_key;
            engineinterface.set_engine_good();
            engineinterface.engine_turn_on();
            brakeinterface.set_brake_good();
            engineinterface.speedmonitor.set_newspeed(0);
            int i = 0;
            // go 1 above the maximum speed
            while (i <= engineinterface.speedmonitor.maximum_speed)
            {
                engineinterface.increase_speed(1);
                i++;
            }
            return engineinterface.speedmonitor.get_current_speed();
        }

        // Expected to be good
        // Expected to return a value of 0 == the end speed after the test
        [ContractVerification(false)]
        public int go_to_maximum_speed_and_to_zero_test()
        {
            ignition_state = IgnitionState.inserted_key;
            engineinterface.set_engine_good();
            brakeinterface.set_brake_good();
            engineinterface.engine_turn_on();
            engineinterface.speedmonitor.set_newspeed(0);
            int i = 0;
            // go to the maximum speed
            while (i < engineinterface.speedmonitor.maximum_speed)
            {
                engineinterface.increase_speed(1);
                i++;
            }
            // go down to 0 again
            while (i > 0)
            {
                engineinterface.decrease_speed(1);
                i--;
            }
            return engineinterface.speedmonitor.get_current_speed();
        }

        // Expected to fail
        [ContractVerification(false)]
        public void petrol_low_fail_dashboard_light_test()
        {
            petrol_state = PetrolState.petrol_low;
            dashboard.petrol_light_off();
        }

        // Expected to be good
        [ContractVerification(false)]
        public void petrol_low_dashboard_light()
        {
            petrol_state = PetrolState.petrol_low;
            dashboard.petrol_light_on();
        }

        // Expected to fail
        [ContractVerification(false)]
        public void oil_temp_high_fail_dashboard_light_test()
        {
            oil_temperature_state = OilTemperatureState.oil_temperature_high;
            dashboard.oil_temperature_light_off();
        }

        // Expected to be good
        [ContractVerification(false)]
        public void oil_temp_high_dashboard_light_test()
        {
            oil_temperature_state = OilTemperatureState.oil_temperature_high;
            dashboard.oil_temperature_light_on();
        }

        // Expected to fail
        [ContractVerification(false)]
        public void oil_pressure_high_fail_dashboard_light_test()
        {
            oil_pressure_state = OilPressureState.oil_pressure_high;
            dashboard.oil_pressure_light_off();
        }


        // Expected to be good
        [ContractVerification(false)]
        public void oil_pressure_high_dashboard_light_test()
        {
            oil_pressure_state = OilPressureState.oil_pressure_high;
            dashboard.oil_pressure_light_on();
        }*/

    }
}
