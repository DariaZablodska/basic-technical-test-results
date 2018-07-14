using System;
using System.Numerics;
namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            int Sum = 0;
            for (int i = 1; i <= maxNrAsInt; i++) {
                Sum += i;
            }
                
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            return Sum;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            int maxNrAsInt = 0;
            Int32.TryParse(maxNrAsString, out maxNrAsInt);

            BigInteger Sum = 0;
            for (int i = 1; i <= maxNrAsInt; i++)
            {
                Sum += i;
            }

            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            return Sum.ToString();

        }
    }
}
