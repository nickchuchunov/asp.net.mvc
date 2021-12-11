using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace asp.net.mvc_lesson1._1
{
    public class FibonacciNumbers

    {

        public string Numbers { get; set; } = " ";

        public int n2 { get; set; }



        internal DateTime Time1 { get; set; }
        internal DateTime Time2 { get; set; }
        internal int N { get; set; } = 0;




        public void Fibonacci1(int n, int MilliSeconds)
        {

            int _n1 = 0; // n-1
            int _n = 1; // n

            while (N < n)
            {
                if (Time1.AddMilliseconds(MilliSeconds) <= Time2)
                {


                    Time1 = DateTime.Now;
                    n2 = _n1 + _n;
                    Numbers += $"{ n2}, {Time1}\n";

                    _n1 = _n;
                    _n = n2;
                    N++;


                }

                Time2 = DateTime.Now;

            }




        }









    }
}
