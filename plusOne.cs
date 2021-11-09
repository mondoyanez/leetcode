using System;

namespace PlusOne
{
    class plusOne
    {
        static void Main(string[] args)
        {
            int[] testNums = new int[]{1,2,3,4,5,6,7,8,9};
            int currentValues = 1;

            int ones = testNums[testNums.Length - 1] * currentValues;
            currentValues *= 10;
            int tens = testNums[testNums.Length - 2] * currentValues;
            currentValues *= 10;

            Console.WriteLine($"currentValues: {currentValues}\n ones: {ones}\n tens:{tens}");

        }
    }
}