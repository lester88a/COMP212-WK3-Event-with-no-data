using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Raising& Consuming custom events
 * 
 */

namespace Raising_Consuming_custom_events
{
    class Program
    {
        static void Main(string[] args)
        {
            //example 1: event that dones not have tata
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;
            Console.WriteLine("Press the key 'a' to increase");
            while (Console.ReadKey(true).KeyChar=='q')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }
        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The theshold was reached");
            //Environment.Exit(0);
        }
    }
}
