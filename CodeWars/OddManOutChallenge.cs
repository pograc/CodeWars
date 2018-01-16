using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class OddManOutChallenge
	{
		// Array at least 3 int all are either odd or even except one item
		// Return the one that does not belong
		#region Mine

		public int OddManOut(int[] list)
		{
			// look at first 2 to figure out what we are searching for
			int item;
			int current = 2;
			if(list[0] % 2 != list[1] % 2)
			{
				// we know that one of these two are the odd one out
				return list[0] % 2 == list[2] % 2 ? list[1] : list[0];
			}
			else
			{
				// we know that these two are not it and what the type is we are looking for
				do
				{
					item = list[current++];
				} while (item % 2 == list[0] % 2);
			}
			return item;
		}

		#endregion

		#region Best

		public int OddManOutBest(int[] integers)
		{
			List<int> even = integers.Where(item => item % 2 == 0).ToList();
			List<int> odd = integers.Where(item => item % 2 != 0).ToList();
			return even.Count() == 1 ? even.First() : odd.First();
		}

		public int OddManOutBest2(int[] list)
		{
			return list.GroupBy(item => item % 2).First(gb => gb.Count() == 1).First();
		}

		#endregion
	}
}
