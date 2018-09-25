using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLecture25_09_2018
{
    class LittleHelper
    {
        private int counter;
        public bool startWithQ(string s)
        {
            counter++;
            return s.ToLower().StartsWith("q");
        }

        public int getStringLength(string s)
        {
            counter++;
            return s.Length;
        }
    }
}
