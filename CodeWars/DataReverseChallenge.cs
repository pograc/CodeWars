using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class DataReverseChallenge
	{
		#region DataReverse

		public int[] DataReverse(int[] data)
		{
			int length = data.Length;
			int x = length / 8;

			int[] output = new int[length];

			for (int i = 0; i < x; i++)
			{
				output[8 * i] = data[length - (i * 8) - 8];
				output[8 * i + 1] = data[length - (i * 8) - 7];
				output[8 * i + 2] = data[length - (i * 8) - 6];
				output[8 * i + 3] = data[length - (i * 8) - 5];
				output[8 * i + 4] = data[length - (i * 8) - 4];
				output[8 * i + 5] = data[length - (i * 8) - 3];
				output[8 * i + 6] = data[length - (i * 8) - 2];
				output[8 * i + 7] = data[length - (i * 8) - 1];
			}

			return output;
		}

		public int[] DataReverseBest(int[] data)
		{
			int[] bits = data;

			for (int i = 0; i < data.Length; i += 8)
				Array.Reverse(bits, i, 8);

			Array.Reverse(bits);

			return bits;
		}

		#endregion

	}
}
