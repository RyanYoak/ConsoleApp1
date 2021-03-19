using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evens = numbers.Where(n => n % 2 == 0);
            numbers[0] = 12; 
            // The output will be 12,2,4,6,8,10
            // evens does not evaluate until it is called in a foreach
            // Console.WriteLine(evens[0]) would not work
                /// Console.WriteLine(evens.First()) would work
            foreach(var number in evens)
            {
                Console.WriteLine(number);
            }

            //foreach(var number in GetSomeNumbers().Skip(20).Take(100))
            //{
            //    Console.WriteLine(number);
            //}


            //var sw = new Stopwatch();
            //sw.Start();
            //foreach(var number in GetNumbersOneToHundret())
            //{
            //    Console.WriteLine(number);
            //}
            //sw.Stop();

            //Console.WriteLine("That took {0} Milliseconds", sw.ElapsedMilliseconds);
        }

        public static IEnumerable<long> GetSomeNumbers()
        {
            for(var t = 0; t < long.MaxValue; t++)
            {
                yield return t;
            }
        }

        public static IEnumerable<string> FavoriteIceCream()
        {
            yield return "Chocolate";
            yield return "Strawberry";
            yield return "Double Dark Raspberry";
        }

        public static IEnumerable<int> GetNumbersOneToHundret()
        {
            var results = new List<int>();
            for(var t = 1; t < 101; t++)
            {
                Thread.Sleep(100);
                // Will remember the state of this method and pick up where it was left off
                yield return t;
            }
        }
    }
}
