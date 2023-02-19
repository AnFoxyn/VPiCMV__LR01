using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    public class RomanNumberExtend : RomanNumber
    {
        public static ushort ToInt(string num)
        {
            num = new string(num.Reverse().ToArray());
            ushort toInt = 0;

            for (int i = 0 ; i < num.Length; i++)
            {
                switch (num[i])
                {
                    case 'M':
                        toInt += 1000;
                        break;

                    case 'D':
                        toInt += 500;
                        break;

                    case 'C':
                        toInt += 100;
                        if (i > 0)
                            if (num[i - 1] == 'M' || num[i - 1] == 'D')
                                toInt -= 200;
                        break;

                    case 'L':
                        toInt += 50;
                        break;

                    case 'X':
                        toInt += 10;
                        if (i > 0)
                            if (num[i - 1] == 'C' || num[i - 1] == 'L')
                                toInt -= 20;
                        break;

                    case 'V':
                        toInt += 5;
                        break;

                    case 'I':
                        toInt += 1;
                        if (i > 0)
                            if (num[i - 1] == 'X' || num[i - 1] == 'V')
                                toInt -= 2;
                        break;

                    default:
                        break;
                }
            }
            return toInt;
        }
        public RomanNumberExtend(string num) : base(ToInt(num)) { }
    }
}
