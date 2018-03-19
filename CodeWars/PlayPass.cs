using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class PlayPass
	{
		public string playPass(string s, int n)
		{
			string returnValue = string.Empty;
			int count = 0;
			int a = Convert.ToUInt16('a');
			// 1. shift each letter by a given number but the transformed letter must be a letter (circular shift).
			// 2. replace each digit by its complement to 9. using 2 -> 9 - 2 = 7
			// 3. keep such as non alphabetic and non digit characters.
			// 4. downcase each letter in odd position, upcase each letter in even position
			// 5. reverse entire result
			foreach(char character in s.ToLower())
			{
				// check if number
				if (char.IsDigit(character))
				{
					returnValue += 9 - (int)char.GetNumericValue(character);
				}
				// if character
				else if (char.IsLetter(character))
				{
					char toAdd = (char)(((Convert.ToUInt16(character) - a + n) % 26) + a);
					returnValue += count % 2 == 0 ? char.ToUpper(toAdd) : toAdd;
				}
				// else do nothing
				else
				{
					returnValue += character;
				}
				// increment count
				count++;
			}
			char[] arr = returnValue.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}

		private string lib = "abcdefghijklmnopqrstuvwxyz";
		public string playPassBest(string s, int n)
		{
			string shifted = lib.Substring(n) + lib.Substring(0, n);
			return string.Concat(s.ToLower().Select((c, i) => {
				if (lib.Contains(c))
				{
					char r = shifted[lib.IndexOf(c)];
					return i % 2 == 0 ? Char.ToUpper(r) : r;
				}
				if (Char.IsDigit(c)) return (9 - Char.GetNumericValue(c)).ToString()[0];
				return c;
			}).Reverse());
		}
	}
}
