using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Worker.Entities
{
    class HourContract
    {
        public DateTime Data { get; set; }
        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract() { }
        public HourContract(DateTime data, double valuePerHour, int hours)
        {
            Data = data;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour*Hours; 
        }
    }
}
