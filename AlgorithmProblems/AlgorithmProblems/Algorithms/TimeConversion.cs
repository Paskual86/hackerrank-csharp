using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems.Algorithms
{
    internal class TimeConversion
    {
        public static string Execute(string s) 
        {
            var clock = s.Substring(s.Length - 2, 2);
            var hour = s.Substring(0, s.Length - 2);

            var time = hour.Split(":");

            var hour_i = int.Parse(time[0]);

            if (hour_i != 12)
            {
                if (clock == "PM") hour_i += 12;
            }
            else
            {
                if (clock == "AM") hour_i = 0;
            }

            return $"{hour_i.ToString().PadLeft(2, '0')}:{time[1]}:{time[2]}";
        }
    }
}
