using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleExpressionCalc
{
    class Calculation
    {
		static public bool argumentCheck(string argument)
		{
			string argumentPattern = @"^[+,-]?[0-9]+$";

			if (argument.Length > 0 && Regex.IsMatch(argument, argumentPattern, RegexOptions.IgnoreCase))
			{
				int x = Int32.Parse(argument);
				if (x <= 0 || x > 20)
                {
					return false;
                }
				Console.WriteLine("Строка является аргументом");
				return true;
			}
			else
			{
				Console.WriteLine("Строка не является аргументом");
				return false;
			}
		}

		static public int expressionCalc(string argument)
        {
			int x = Int32.Parse(argument);

			if (0 < x && x <= 10) {
				return 6 * x * x + 3 * x + 1;
			} else if (11 <= x && x <= 20)
            {
				return 4 * x + 17;
            } else
            {
				return 0;
            }
        }
	}
}
