using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
namespace asp.net.mvc_lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            PulThread pulThread = new PulThread();

        

           
            

           var Task2 = Task.Run(() => pulThread.ListFobonacciAdd(5, 500));


            var Task3 = Task.Run(() => pulThread.ListFobonacciAdd(10, 700));

           

         


            while (Task2.Wait(4000) )
            {

                Task.Run(() => pulThread.ListFobonacciRead(0, 100));
                Console.ReadLine();
                break;

            }

            while ( Task3.Wait(10000))
            {

                Task.Run(() => pulThread.ListFobonacciRead(0, 100));
                Console.ReadLine();
                break;

            }



        }
    }
}
