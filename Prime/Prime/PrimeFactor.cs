
using System.Collections.Generic;

namespace Prime
{
    public class PrimeFactor
    {
        public static List<int> Generate(int input)
        {
            var factors = new List<int>();
            for (; input % 2 == 0; input = input / 2)
            {
                factors.Add(2);
            }
            if (input > 1) factors.Add(input);
            return factors;
        }
    }
}
