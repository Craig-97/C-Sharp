using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillRaceSystem
{

    [Serializable]
    public class SeniorRunner : Runners
    {
        /// <summary>
        /// create a default runner object
        /// </summary>
        public SeniorRunner()
            : base("(unknown shrnumber)", "(unknown name)", "(unknown gender)")
        {

        }

        /// <summary>
        /// Create a runner with given shrnumber, name and gender
        /// </summary>
        /// <param name="shrnumber">shrnumber</param>
        /// <param name="name">name</param>
        /// <param name="gender">gender</param>
        public SeniorRunner(String shrnumber, String name, String gender)
            : base(shrnumber, name, gender)
        {
        }

        /// <summary>
        /// Return a string representation of this object.
        /// </summary>
        /// <returns>string representation of a senior runner</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

