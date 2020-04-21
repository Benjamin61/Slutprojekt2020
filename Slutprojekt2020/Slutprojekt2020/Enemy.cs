using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Enemy : CharactherCreation
	{
		private List<String> whatEnemy = new List<string>() { "Test1", "Test2", "Test3", };//Ska försöka göra en api istället
		public Enemy()//Konstruktor som kommer köras när en ny instans ev enemy skapas
		{
			int enemyGenerator = generator.Next(whatEnemy.Count); //Slumpar fram vilken enemy det blir i listan
			name = whatEnemy[enemyGenerator]; //name blir det namnet så är på den plats som enemygenrator slumpade fram från listan
			if (enemyGenerator == 1)
			{
				CharactherStats["hp"] = generator.Next(CharactherStats["hp"], 200);
				CharactherStats["strenght"] = generator.Next(20, 30);
			}
			else if (enemyGenerator == 2)
			{
				CharactherStats["hp"] = generator.Next(CharactherStats["hp"], 200);
				CharactherStats["strenght"] = generator.Next(10, 40);
			}
			else if (enemyGenerator == 3)
			{
				CharactherStats["hp"] = generator.Next(CharactherStats["hp"], 200);
				CharactherStats["strenght"] = generator.Next(1, 70);
			}

		}
		public override int highLowAttack()
		{
			List<string> attacks = new List<string>() { "High Risk", "Low risk" };
			int getAttack = generator.Next(1, 2);
			Console.WriteLine(name + "used" + attacks[getAttack] + "attack"  );
			return getAttack;
		}
	}

	
}
