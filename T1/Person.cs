using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    /// <summary>
    /// This class contains Person properties.
    /// </summary>
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSevurityNumber { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSevurityNumber;
        }
    }
}
