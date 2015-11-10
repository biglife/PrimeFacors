
using System.Collections.Generic;

namespace Prime
{
    public class PrimeFactor
    {
        public static List<int> Generate(int input)
        {
            var factors = new List<int>();
            if (input%2 == 0)
            {
                factors.Add(2);
                input = input/2;
            }
            if (input > 1) factors.Add(input);
            return factors;
        }
    }
}
