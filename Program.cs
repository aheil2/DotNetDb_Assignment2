using System;

namespace DotNetDb_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            //1.
            Console.WriteLine("{0:MMMM} {0:dd}, {0:yyyy}", today);
            //2.
            //Console.WriteLine("{0:yyyy}.{0:MM}.{0:dd}", today);
            Console.WriteLine("{0:yyyy.MM.dd}", today);
            //3.
            Console.WriteLine("Day {0:dd} of {0:MMMM}, {0:yyyy}", today);
            //4.
            Console.WriteLine("Year: {0:yyyy}, Month: {0:MM}, Day: {0:dd}", today);
            //5.
            Console.WriteLine("{0,10:dddd}", today);
            //6.
            Console.WriteLine("{0,10:hh:mm:tt}{0,10:dddd}", today);
            //7.
            Console.WriteLine("h:{0:hh}, m:{0:mm}, s:{0:ss}", today);
            //8.
            //Console.WriteLine("{0:yyyy}.{0:MM}.{0:dd}.{0:hh}.{0:mm}.{0:ss}", today);
            Console.WriteLine("{0:yyyy.MM.dd.hh.mm.ss}", today);

            double pi = 3.1415;
            Console.WriteLine("{0:C}", pi);
            Console.WriteLine("{0,10:N3}", pi);
        }
    }
}
