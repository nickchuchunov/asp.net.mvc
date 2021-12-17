using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringConverter converter = new StringConverter();

           string s =  converter.LargeCharacters("Привет Николай сегодня 17.12.2021");
            Console.WriteLine(s);
            Console.ReadLine();



        }
    }
}
