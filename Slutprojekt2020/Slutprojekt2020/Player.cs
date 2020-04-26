using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Player : CharactherCreation
	{
		public Player() //En konsturktor som fastställer P1 grund stats
		{
			
			CharacterStats["hp"] = generator.Next(100, 155);
			Console.WriteLine("Your HP is " + CharacterStats["hp"]);
			CharacterStats["strenght"] = generator.Next(10, 33);
			Console.WriteLine("Your strenght is " + CharacterStats["strenght"]);
			Console.ReadKey();
			
		}
	}
}
