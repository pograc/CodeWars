using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
	public class BuildTower
	{
		public string[] TowerBuilder(int nFloors)
		{
			int stringLength = nFloors * 2 - 1;
			int starCount = 1;
			string[] returnValue = new string[nFloors];
			for(int count = 0; count < nFloors; count++)
			{
				returnValue[count] = string.Concat(new string(' ', (stringLength - starCount) / 2), new string('*', starCount), new string(' ', (stringLength - starCount) / 2));
				starCount += 2;
			}
			return returnValue;
		}
	}
}
