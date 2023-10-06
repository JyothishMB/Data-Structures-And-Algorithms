using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class RecursionDemo
    {
        public int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            
            return n * CalculateFactorial(n - 1);
            
        }

        public int CalculateSumofNNaturalNumbers(int n)
        {
            return n == 1 ? n : n + CalculateSumofNNaturalNumbers(n - 1);
        }
    }
}
