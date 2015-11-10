
using System.Collections.Generic;

namespace Prime
{
    public class PrimeFactor
    {
        public static List<int> Generate(int input)
        {
            var factors = new List<int>();
            var candidate = 2;
            while (input > 1)
            {
                for (; input % candidate == 0; input = input / candidate)
                {
                    factors.Add(candidate);
                }
                candidate++;
            }

            return factors;
        }
    }
}
