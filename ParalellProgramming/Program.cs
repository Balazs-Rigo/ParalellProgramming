using System;
using System.Threading.Tasks;

namespace ParalellProgramming
{
    internal class Program
    {
        public static void Write(char c)
        {
            int i = 1000;
            while (i -- >0)
            {
                Console.Write(c);
            }
        }

        public static void Write(object o)
        {
            int i = 1000;
            while (i-- > 0)
            {
                Console.Write(o);
            }
        }
        static void Main(string[] args)
        {
            Task t = new Task(Write,"Hello");
            t.Start();
            Task.Factory.StartNew(Write,123);
                                    
            Console.WriteLine("Main program done");
            Console.ReadKey();
        }
    }
}
