using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class CharactherCreation
	{
		public string name;

		protected int strenght;

		protected int hp;

		protected static Random generator = new Random();
		void DisplayStats()
		{
			Console.WriteLine(" Now displaying" + name + "stats");
			Console.WriteLine("HP:" + hp);
			Console.WriteLine("Strenght" + hp);
		}

		public int DamageDone()
		{
			int randomCrit = generator.Next(1, 6);
			int dmg = 0;
			if (randomCrit > 4)
			{
				Console.WriteLine("Random crit! Next hit will be empowered by 200%");
				dmg = generator.Next(strenght, (strenght + 3));
				dmg = dmg * 3;
				Console.WriteLine("You did " + dmg + " To the enemy!");
			}
			else
			{
				dmg = generator.Next(strenght, (strenght + 3));
				Console.WriteLine("You did " + dmg + " To the enemy!");
			}
			return dmg;

		}
	}
}
