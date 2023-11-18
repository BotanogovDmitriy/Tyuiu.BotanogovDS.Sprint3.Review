using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BotanogovDS.Sprint3.TaskReview.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                double x = i + startValue;
                result[i] = Math.Round(Math.Sin(x) + Math.Cos(x), 2);
            }

            return result;
        }
    }
}
