using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;


namespace Slutprojekt2020
{
	class Enemy : CharactherCreation
	{
		public int enemyGenerator;
		public  string name1;
		public  string name2;
		public  string name3;
		//{ "Test1", "Test2", "Test3", };//Ska försöka göra en api istället
		List<String> whatEnemy = new List<string>();
		public void  getEnemy()
		{
			
			whatEnemy.Add(name1);
			whatEnemy.Add(name2);
			whatEnemy.Add(name3);
			//string allEnemy = string.Join(",", whatEnemy.ToArray());
			//Console.WriteLine(allEnemy);
			enemyGenerator = generator.Next(whatEnemy.Count); //Slumpar fram vilken enemy det blir i listan
			name = whatEnemy[enemyGenerator]; //name blir det namnet sóm är på den plats som enemygenrator slumpade fram från listan
			Console.WriteLine(name);


		}

		public Enemy()//Konstruktor som kommer köras när en ny instans ev enemy skapas
		{

			
			
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
