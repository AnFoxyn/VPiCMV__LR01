using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException(string message) : base(message) { }
    }
}
