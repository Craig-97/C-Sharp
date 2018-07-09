using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempTester
{
    /// <summary>
    /// Temperature class - a temperature ADT
    /// works with kelvin (simple), centigrade and fahrenheit
    /// </summary>
    public class Temperature
    {
        #region private attributes
        /// <summary>
        /// stores temperature as kelvin
        /// </summary>
        private double temp;
        #endregion

        #region public properties
        /// <summary>
        /// Property for setting/getting temperature in Celcius
        /// </summary>
        public double Celcius
        {
            get
                {
                    return getTemp('C');
                }

            set
            {
                setTemp(value, 'C');
            }
        }

        /// <summary>
        /// Property for setting/getting temperature in Kelvin
        /// </summary>
        public double Kelvin
        {
            get
            {
                return getTemp('K');
            }

            set
            {
                setTemp(value, 'K');
            }
        }

        /// <summary>
        /// Property for setting/getting temperature in Fahrenheit
        /// </summary>
        public double Fahrenheit
        {
            get
            {
                return getTemp('F');
            }

            set
            {
                setTemp(value, 'F');
            }
        }
#endregion

        #region public constructors
        //constructors
        /// <summary>
        /// Constructor 
        /// sets temperature to kelvin using
        /// argument passed in
        /// </summary>
        /// <param name="t">temperature in kelvin</param>
        public Temperature(double t)
        {
            setTemp(t, 'K');
        }

        /// <summary>
        /// default constructor 
        /// sets temperature to 0K
        /// </summary>
        public Temperature()
        {
            setTemp(0, 'K');
        }
#endregion
       
        #region private helper methods
        //these methods are the key to how the class works

        /// <summary>
        /// sets temperature to kelvin
        /// using K, F or C value passed in
        /// </summary>
        /// <param name="d">temperature value</param>
        /// <param name="c">scale C, K or F</param>
        private void setTemp(double d, char c)
        {
            c = char.ToUpper(c);
            if (c == 'F')
            {
                //convert to celsius 
                d = (d - 32) / 1.8;
            }
            if (c == 'C' || c == 'F')
            {
                //convert to kelvin
                d = d + 273;
            
           }

            if ((c != 'F' && c != 'C' && c != 'K') || d < 0)
                throw new Exception("unkown temprature");

            this.temp = d;
        }

        /// <summary>
        /// returns temperature in units passed in
        /// throws exception if units invalid
        /// </summary>
        /// <param name="c">units for temperature</param>
        /// <returns>temperature in units c</returns>
        private double getTemp(char c)
        {
            double t = temp; // holds value to return
            c = char.ToUpper(c);
            if (c != 'F' && c != 'C' && c != 'K')
                throw new Exception("unkown unit");


            if (c == 'C' || c == 'F')
            {
                //convert to celcius
                t = temp - 273;

            }
            if (c == 'F')
            {
                //convert to fahrenheit 
                t = (t * 9 / 5) + 32;
            }

            return t;
        }
        #endregion

        #region public settors and getters
       
        /// <summary>
        /// Sets temprature to kelvin
        /// throws exception if illegal
        /// </summary>
        /// <param name="t">temperature in kelvin</param>
        public void setTempK(double t)
        {
            setTemp(t, 'K');
        }

        /// <summary>
        /// sets temperature to kelvin value
        /// equivalent to celcius value passed in
        /// </summary>
        /// <param name="t">temperature in celcius</param>
        public void setTempC(double t)
        {
            setTemp(t, 'C');
        }

        /// <summary>
        /// sets temperature to kelvin value
        /// equivalent to fahrenheit value passed in
        /// </summary>
        /// <param name="t"></param>
        public void setTempF(double t)
        {
            setTemp(t, 'F');
        }
        /// <summary>
        /// returns value in temp as celcius
        /// </summary>
        /// <returns>tempertaure in celcius</returns>
         public double getTempC()
         {
             return getTemp('C');
         }

        /// <summary>
        /// returns value in temp as kelvin
        /// </summary>
        /// <returns>temperature in kelvin</returns>
         public double getTempK()
         {
             return getTemp('k');
         }

        /// <summary>
        /// returns value in temp as fahrenheit
        /// </summary>
        /// <returns>temperature in fahrenheit</returns>
         public double getTempF()
         {
             return getTemp('f');
         }
#endregion

         #region public string representations
         /// <summary>
         /// overrides defaulkt ToString to show
         /// contents of temp as degrees kelvin
         /// </summary>
         /// <returns>string representation of temperature in kelvin</returns>
         public override string ToString()
         {
             //also note how you can use \x00B0 (UTF-16 code for ° symbol)
             string mystring = String.Format("{0:f2}\x00B0K", temp);
             return mystring;
         }

        /// <summary>
        /// returns string representation of temperature in celcius
        /// </summary>
        /// <returns>string representation of temperature in celcius</returns>
        public string getStrCelcius()
        {
            double t = getTemp('C');
            string mystring = String.Format("{0:f2}\x00B0C",t );
            return mystring;
        }


        /// <summary>
        /// returns string representation of temperature in fahrenheit
        /// </summary>
        /// <returns>string representation of temperature in fahrenheit</returns>
        public string getStrFahrenheit()
        {
            double t = getTemp('F');
            string mystring = String.Format("{0:f2}\x00B0F", t);
            return mystring;
        }

        /// <summary>
        /// returns string representation of temperature in kelvin
        /// </summary>
        /// <returns>string representation of temperature in kelvin</returns>
        public string getStrKelvin()
        {
            double t = getTemp('K');
            string mystring = String.Format("{0:f2}\x00B0K", t);
            return mystring;
        }
#endregion

        #region static methods
        /// <summary>
        /// static Parse method
        /// reads in string in format ddd.dds
        /// where s can be f,F,C,c,K or k
        /// and converts to new temperature object
        /// throws exception if illegal
        /// </summary>
        /// <param name="st">string in format ddd.dds where s can be f,F,C,c,K or k </param>
        /// <returns>new Temperature object</returns>
        public static Temperature Parse(string st)
        {
            char c = 'e';//set to illegal character
            double d = 0.00;
            if (st.Length > 0)
            {
                //get last character
                c = st[st.Length - 1];
                //remove last character
                st = st.Remove(st.Length - 1);
            }
            try
            {
                d = double.Parse(st);//will throw error if cannot parse
                Temperature t = new Temperature();
                t.setTemp(d, c);//will throw error if invalid arguments
                return (t);
            }
            catch (Exception e)
            {
                throw e;//Exception thrown on
            }
        }

        #endregion

        #region operator overloads
        /// <summary>
        /// overriden < operator
        /// </summary>
        /// <param name="t1">first temprature</param>
        /// <param name="t2">second temperature</param>
        /// <returns>true or false</returns>
        public static bool operator <(Temperature t1, Temperature t2)
        {
           return (t1.temp < t2.temp);
        }

        /// <summary>
        /// overriden > operator
        /// </summary>
        /// <param name="t1">first temprature</param>
        /// <param name="t2">second temperature</param>
        /// <returns>true or false</returns>
        public static bool operator >(Temperature t1, Temperature t2)
         {
           return (t1.temp > t2.temp);
         }

        /// <summary>
        /// overriden >= operator
        /// </summary>
        /// <param name="t1">first temprature</param>
        /// <param name="t2">second temperature</param>
        /// <returns>true or false</returns>
        public static bool operator >=(Temperature t1, Temperature t2)
        {
            return (t1.temp > t2.temp);
        }

        /// <summary>
        /// overriden > operator
        /// </summary>
        /// <param name="t1">first temprature</param>
        /// <param name="t2">second temperature</param>
        /// <returns>true or false</returns>
        public static bool operator <=(Temperature t1, Temperature t2)
        {
            return (t1.temp <= t2.temp);
        }

        
        /// <summary>
        /// assignment operator
        /// accepts string in format ddd.ds
        /// where s can be c,C,F,f,K,k
        /// </summary>
        /// <param name="st">string in format ddd.dds where s can be f,F,C,c,K or k</param>
        /// <returns>new Temperature object</returns>
         public static implicit operator Temperature(string st)
         {
            Temperature temp = new Temperature();
            try
            {
               temp = Temperature.Parse(st);
            }
            catch (Exception e)
            {
               throw e;
            }
            return temp;
         }

        /// <summary>
        /// addition operator
        /// adds two temperature objects
        /// </summary>
        /// <param name="b">Temperature left operand</param>
         /// <param name="c">Temperature right operand</param>
        /// <returns>Temperature object</returns>
         public static Temperature operator +(Temperature b, Temperature c)
         {
             Temperature t = new Temperature();
             t.temp = b.temp + c.temp;
             
             return t;
         }

        /// <summary>
        /// ++ operator
        /// adds 1 degree kelvin
        /// </summary>
        /// <param name="b">Temperature object to increment</param>
        /// <returns>Temperature object</returns>
         public static Temperature operator ++(Temperature b)
         {
             Temperature t = new Temperature();
             t.temp = b.temp + 1;     
             return t;
         }

        /// <summary>
        /// subtraction operator
        /// sets to 0 kelvin if tries to set below
        /// </summary>
         /// <param name="b">Temperature left operand</param>
         /// <param name="c">Temperature right operand</param>
        /// <returns>Temperature object</returns>
         public static Temperature operator -(Temperature b, Temperature c)
         {
             Temperature t = new Temperature();
             t.temp = b.temp - c.temp;
             if (t.temp < 0) 
                 t.temp = 0;
             return t;
         }

        /// <summary>
        /// -- operator
        /// subtracts 1 degree kelvin from object
        /// sets to 0 if less than 0
        /// </summary>
         /// <param name="b">Temperature object to decrement</param>
        /// <returns>Temperature object</returns>
         public static Temperature operator --(Temperature b)
         {
             Temperature t = new Temperature();
             t.temp = b.temp - 1;
             if (t.temp < 0) 
                 t.temp = 0;
             return t;
         }

        #endregion

    }
}
