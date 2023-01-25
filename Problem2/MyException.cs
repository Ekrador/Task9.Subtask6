using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class WrongAnswer : Exception
    {
        public WrongAnswer() { }
        public WrongAnswer(string message) : base(message) { }
        public override string Message => "Введено число, отличное от 1 или 2";
    }
}
