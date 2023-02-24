using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угрюмова_ОА_пр_11_12
{
    public class Student
    {
        public string name;
        public int rost;
        public double eda;
        public double ves;
        public double GetEat()
        {
            return ves;
        }
        public double SetEat(double eda, double weight)
        {
            if (eda < 5)
            {
                weight += eda;
            }
            if (eda > 5 && eda <10)
            {
                weight += (eda * 0.7);
            }
            if(eda > 10)
            {
                weight += eda*0.5;
            }
            return weight;
        }
        public int SetRost(double eda, int rost)
        {
            if(eda > 5 && eda<10)
            {
                rost -= 1;
            }
            if(eda > 10)
            {
                rost -= 2;
            }
            return rost;
        }
    }
}
