using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = { new ArgumentException(), new FormatException(), new ArgumentNullException(), new OverflowException(), new MyException() };
            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
