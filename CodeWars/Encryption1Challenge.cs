using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class Encryption1Challenge
	{
		//Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
		//Do this n times!
		//"This is a test!", 1 -> "hsi  etTi sats!"
		//"This is a test!", 2 -> "hsi  etTi sats!" -> "s eT ashi tist!"
		#region Mine

		public string Encrypt(string text, int n)
		{
			string returnValue = text;

			if (string.IsNullOrWhiteSpace(returnValue) || n <= 0)
				return returnValue;

			for (int i = n; i > 0; i--)
			{
				string begin = string.Empty;
				string end = string.Empty;
				for (int x = 0; x < returnValue.Length; x++)
				{
					if (x % 2 == 0)
						end = string.Concat(end, returnValue[x]);
					else
						begin = string.Concat(begin, returnValue[x]);
				}
				returnValue = string.Concat(begin, end);
			}

			return returnValue;
		}

		public string Decrypt(string text, int n)
		{
			string returnValue = text;

			if (string.IsNullOrWhiteSpace(returnValue) || n <= 0)
				return returnValue;

			int length = returnValue.Length;
			int half = length / 2;

			for (int i = n; i > 0; i--)
			{
				string updatedCopy = string.Empty;
				for (int x = 0; x < half; x++)
					updatedCopy = string.Concat(updatedCopy, returnValue.Substring(half + x, 1), returnValue.Substring(x, 1));
				if (length % 2 != 0)
					updatedCopy = string.Concat(updatedCopy, returnValue.Substring(length - 1));
				returnValue = updatedCopy;
			}

			return returnValue;
		}

		#endregion

		#region Best Practice

		public string EncryptBest(string text, int n)
		{
			if (string.IsNullOrWhiteSpace(text) || n <= 0)
				return text;

			while (n != 0)
			{
				text = string.Concat(text.Where((c, i) => i % 2 == 1).Concat(text.Where((c, i) => i % 2 == 0)));
				n--;
			}

			return text;
		}

		public string DecryptBest(string text, int n)
		{
			if (string.IsNullOrWhiteSpace(text) || n <= 0)
				return text;

			while (n != 0)
			{
				string leftPart = string.Concat(text.Take(text.Length / 2));
				string rightPart = string.Concat(text.Skip(text.Length / 2));

				text = string.Concat(Enumerable.Range(0, text.Length).Select(i => i % 2 == 0 ? rightPart[i / 2] : leftPart[i / 2]));
				n--;
			}

			return text;
		}

		#endregion

	}
}
