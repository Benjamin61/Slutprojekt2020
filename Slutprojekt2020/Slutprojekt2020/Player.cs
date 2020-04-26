using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Player : CharactherCreation
	{
		public int extraDmg;
		public Player() //En konsturktor som fastställer P1 grund stats
		{
			
			CharacterStats["hp"] = generator.Next(10000, 15500);
			Console.WriteLine("Your HP is " + CharacterStats["hp"]);
			CharacterStats["strenght"] = generator.Next(1000, 3300);
			Console.WriteLine("Your strenght is " + CharacterStats["strenght"]);
			Console.ReadKey();
			
		}

		
	}
}
