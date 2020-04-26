using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Bow : Weapons
	{
		public Bow()
		{
			
			
		}
		
		public int ExtraDmg()
		{
			int ExtraDamageOdds = generator.Next(1, 5);
			if (ExtraDamageOdds == 1)
				
			{
				int ExtraDamages = generator.Next(10, 15);
				extraDamage = ExtraDamages + extraDamage;
				Console.WriteLine("You found a bow, therefore you will do extra Damage!");
				
			}
			return extraDamage;

		}
		
	}
	
}
