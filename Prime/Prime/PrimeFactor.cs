
using System.Collections.Generic;

namespace Prime
{
    public class PrimeFactor
    {
        public static List<int> Generate(int input)
        {
            var factors = new List<int>();
            
            for (var candidate = 2;input > 1; candidate++)
            {
                for (; input % candidate == 0; input = input / candidate)
                {
                    factors.Add(candidate);
                }
            }

            return factors;
        }
    }
}
