using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class bow : Weapons
	{
		
		int extraDmg(int ExtraDamage)
		{
			int ExtraDamageOdds = generator.Next(1, 5);
			if (ExtraDamageOdds == 1)
			{
				int ExtraDamages = generator.Next(10, 15);
				ExtraDamage = ExtraDamages + ExtraDamage;
				
			}
			return ExtraDamage;

		}
		
	}
	
}
