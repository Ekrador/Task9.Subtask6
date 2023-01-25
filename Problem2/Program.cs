using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ChooseNumber sort = new ChooseNumber();
            sort.ChooseEvent += SortAlphabetic;
            try
            {
                sort.Start();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены не числа");
            }
            catch (WrongAnswer ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("-----------------------------------");
                Main(null);
            }
        }

        static void SortAlphabetic(int sortStyle)
        {
            var Surnames = new List<string> { "Козлов", "Иванов", "Крылов", "Петров", "Сидоров" };
            switch (sortStyle)
            {
                case 1:
                    Surnames.Sort();
                    foreach (var surname in Surnames) { Console.WriteLine(surname); }
                    break;
                case 2:
                    Surnames.Sort();
                    Surnames.Reverse();
                    foreach (var surname in Surnames) { Console.WriteLine(surname); }
                    break;
            }

        }
    }
}
