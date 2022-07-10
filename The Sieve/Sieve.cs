using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Sieve
{
    internal class Sieve
    {
        public  Func<int, bool> test;

        public bool IsGood(int number)
        {
            return test(number);
            
        }

        public Sieve(Func<int, bool> intakeFunction)
        {
         test = intakeFunction;

        }

    }
}
