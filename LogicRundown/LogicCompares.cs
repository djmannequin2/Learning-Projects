using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicRundown
{
    static class LogicCompares
    {
        public static bool CompareLessThan(int AlphaValue, int BetaValue, bool Inverter)
        {
            return (InvertBoolValue((Inverter), (AlphaValue < BetaValue)));

        }

        public static bool CompareDividedBy(int AlphaValue, int BetaValue, bool Inverter)
        {
            return (InvertBoolValue((Inverter), (BetaValue % AlphaValue == 0)));

        }

        public static bool CompareInBetween(int AlphaValue, int BetaValue, bool Inverter)
        {
            return (InvertBoolValue((Inverter), (Math.Pow(AlphaValue, BetaValue) > 200 && Math.Pow(AlphaValue, BetaValue) < 300)));
            
        }

        public static bool CompareGreaterEven(int AlphaValue, int BetaValue, bool Inverter)
        {
            return ((AlphaValue * BetaValue) > 10 != ((AlphaValue % 2 == 0) && (BetaValue % 2 == 0)));
            
        }

        public static bool ComparePrime(int AlphaValue, int BetaValue, bool Inverter)
        {
            int counter = 0;
            for (int i = 1; i <= AlphaValue; i++)
            {
                if (AlphaValue % i == 0)
                {
                    counter++;
                }

            }
            return (counter == 2);

        }

        public static bool CompareNice(int AlphaValue, int BetaValue, bool Inverter)
        {
            return (BetaValue == 69);
        }
        private static bool InvertBoolValue(bool shouldInvert, bool assessment)
        {
            return (shouldInvert ? !assessment : assessment);
        }
    }
}
