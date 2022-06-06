using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_project_for_marks
{
    internal class itax
    {
        public double mcTax_rate = 0.5;

        public double  iFindTax (double icAmount)
        {
            double findtax = icAmount - (mcTax_rate * icAmount);
            return findtax;
        }
    }
}
