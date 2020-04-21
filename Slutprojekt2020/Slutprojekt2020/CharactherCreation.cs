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
		//protected int strenght; //Försöker använda mig av en dictionary men har kvar detta om det inte funkar

		//protected int hp;
		protected Dictionary<string, int> CharactherStats = new Dictionary<string, int>();

		

		protected static Random generator = new Random();

		public CharactherCreation()
		{
			CharactherStats.Add("hp", 150); 
			CharactherStats.Add("strenght", 0);
		}

		//public int HP
		//{
			//get
			//{
				//return CharactherStats["hp"];
			//}
			//set { }
		//}
		public void DisplayStats()
		{
			Console.WriteLine(" Now displaying" + name + "stats");
			Console.WriteLine("HP: " + CharactherStats["hp"]);
			Console.WriteLine("Strenght: " + CharactherStats["strenght"]);
			//Console.WriteLine("HP:" + hp);
			//Console.WriteLine("Strenght" + hp);
		}

		

		public int DamageDone()
		{
			int randomCrit = generator.Next(1, 6);
			int dmg = 0;
			if (randomCrit > 4)
			{
				Console.WriteLine("Random crit! Next hit will be empowered by 200%");
				dmg = generator.Next(CharactherStats["strenght"], (CharactherStats["strenght"] + 3));
				dmg = dmg * 3;
				Console.WriteLine("You did " + dmg + " To the enemy!");
			}
			else
			{
				dmg = generator.Next(CharactherStats["strenght"], (CharactherStats["strenght"] + 3));
				Console.WriteLine("You did " + dmg + " To the enemy!");
			}
			return dmg;

		}

		public int DamageTaken(int amount)
		{
			CharactherStats["hp"] = CharactherStats["hp"] - amount;
			Console.WriteLine(name + " took " + amount + " damage and now has " + CharactherStats["hp"] + " hp left");
			return CharactherStats["hp"];
		}

		public virtual int highLowAttack()
		{
			Console.WriteLine("[1] High risk or [2] Low risk");
			string choice = Console.ReadLine();
			int playerChoice;
			bool transform = int.TryParse(choice, out playerChoice);
			while (!transform || playerChoice != 1 && playerChoice != 2)
			{
				Console.WriteLine("Try again. Rember to answer 1 or 2");
				choice = Console.ReadLine();
				transform = int.TryParse(choice, out playerChoice);
				
				
			}
			return playerChoice;
		}
	}
}
