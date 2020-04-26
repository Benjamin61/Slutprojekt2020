using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Weapons : Items
	{
		
		protected int sword;
		protected int ExtraDamage;
		protected int ExtraDefence;
		public Weapons()
		{

		}
		

	          
		public override int DamageDone(int amount)
		{
			
			return base.DamageDone(amount);
		}













	}
}
