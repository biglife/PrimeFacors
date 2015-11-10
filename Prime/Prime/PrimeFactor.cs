
using System.Collections.Generic;

namespace Prime
{
    public class PrimeFactor
    {
        public static List<int> Generate(int input)
        {
            var factors = new List<int>();
            if (input > 1) factors.Add(input);
            return factors;
        }
    }
}
