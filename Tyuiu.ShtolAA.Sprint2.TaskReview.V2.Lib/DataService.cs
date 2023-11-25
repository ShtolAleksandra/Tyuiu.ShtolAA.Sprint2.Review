using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtolAA.Sprint2.TaskReview.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= Math.Sqrt(1 - x * x)) && (y <= x / 2))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
