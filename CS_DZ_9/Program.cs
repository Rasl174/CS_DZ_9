using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 7;
            int lastNumber = 98;
            int sequenceStep = 7;

            for (int i = firstNumber; i <= lastNumber;  i += sequenceStep) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
