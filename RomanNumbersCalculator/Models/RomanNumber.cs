using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort _number;
        private static int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public RomanNumber(ushort num)
        {
            if (num <= 0) 
                throw new RomanNumberException($"Число {num} ≤ 0.");
            else this._number = num;
        }

        public static RomanNumber operator +(RomanNumber? num_1, RomanNumber? num_2)
        {
            int num = num_1._number + num_2._number;

            if (num <= 0) 
                throw new RomanNumberException("Не удалось сложить числа.");
            else
                return new RomanNumber((ushort)num);
        }

        public static RomanNumber operator -(RomanNumber? num_1, RomanNumber? num_2)
        {
            int num = num_1._number - num_2._number;

            if (num <= 0) 
                throw new RomanNumberException("Результат вычитания ≤ 0.");
            else
                return new RomanNumber((ushort)num);
        }

        public static RomanNumber operator *(RomanNumber? num_1, RomanNumber? num_2)
        {
            int num = num_1._number * num_2._number;

            if (num <= 0) 
                throw new RomanNumberException("Не удалось умножить числа.");
            else
                return new RomanNumber((ushort)num);
        }

        public static RomanNumber operator /(RomanNumber? num_1, RomanNumber? num_2)
        {

            if (num_2._number == 0)
                throw new RomanNumberException("На ноль делить нельзя.");
            else
            {
                int num = num_1._number / num_2._number;

                if (num == 0) 
                    throw new RomanNumberException("Не удалось поделить числа");
                else
                    return new RomanNumber((ushort)num);
            }
        }
        public object Clone() { return new RomanNumber(_number); }
        public int CompareTo(object obj)
        {
            if (obj is RomanNumber roman)
                return _number.CompareTo(roman._number);
            else
                throw new RomanNumberException("object is not a RomanNumber");
        }

        public override string ToString()
        {
            int tmp = _number;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                while (tmp >= values[i])
                {
                    tmp -= (ushort)values[i];
                    result.Append(roman[i]);
                }
            }
            if (result.ToString() == "")
                throw new RomanNumberException("Перевод числа в Римские цифры невозможен.");
            else
                return result.ToString();
        }
    }
}