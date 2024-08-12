using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3._4
{
    internal class WeekDay
    {
        public string Day {  get; set; }

        public WeekDay(string day)
        {
            Day = day;
        }

        public string Check()
        {
            switch(Day) 
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    return "Weekday";
                case "saturday":
                case "sunday":
                    return "Weekend";
                default:
                    return "No information";
            }
        }
    }
}
