using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;


namespace asp.net.mvc_lesson2
{
   ///  <summary> запись и чтение ряда фибонначи </summary>
    public class PulThread
    {
        private static Mutex _mutex = new Mutex(); 

        public ConcurrentDictionary<int, DateTime> ListFobonacci = new ConcurrentDictionary<int , DateTime>();



       

        public int n2 { get; set; }



        internal DateTime Time1 { get; set; }
        internal DateTime Time2 { get; set; }
        internal int N { get; set; } = 0;




        ///<returns> добавляет  в словарь ListFobonacci числовой ряд фибонначи (колмчество элементов n) как ключ и как значения время вычисления ( задержка milliSeconds )  </returns> 
        internal void ListFobonacciAdd( int n, int milliSeconds) 
        {


            int _n1 = 0; // n-1
            int _n = 1; // n

            var Count = ListFobonacci.GetEnumerator();

            while (N < n)
            {
                if (Time1.AddMilliseconds(milliSeconds) <= Time2)
                {
                    

                    Time1 = DateTime.Now;
                    n2 = _n1 + _n;
                    ListFobonacci.AddOrUpdate(n2, Time1, (n2, Time1) => Time1.AddSeconds(5));   //(n2, Time1); //TryAdd(n2, Time1);
                    Count.MoveNext();
                    _n1 = _n;
                    _n = n2;
                    N++;
 
                }

                Time2 = DateTime.Now;

            }


        }





        ///<returns> метод чтения ListFobonacci по ключу  в диапазоне от n1 до n2  </returns> 
        internal void ListFobonacciRead(int n1, int n2)

        {

            for ( int i=n1; i<n2; i++)
            {

                if (ListFobonacci.ContainsKey(i)) 
                {

                    Console.WriteLine(" Ключ {0} значение: дата {1}, время {2}", i, ListFobonacci[i].Date,   ListFobonacci[i].TimeOfDay);
                
                
                }


            
            }
        

        }


    }
}
