using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public delegate void Number(int number);
    internal class ChooseNumber
    {
        public event Number ChooseEvent;
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Введите \"1\" для сортировки \"А-Я\" или \"2\" для сортировки \"Я-А\"");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer != 1 && answer != 2) throw new WrongAnswer();
            Choose(answer);
        }
        protected virtual void Choose(int number)
        {
            ChooseEvent?.Invoke(number);
        }
    }
}
