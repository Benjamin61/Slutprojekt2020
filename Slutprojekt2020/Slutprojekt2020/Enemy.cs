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
		
		public string name1;
		
		public string name2;
		public string name3;
		//{ "Test1", "Test2", "Test3", };//Ska försöka göra en api istället
		List<String> whatEnemy = new List<string>();
		

		public void getEnemy()
		{
			RestClient client = new RestClient("https://swapi.dev/api/");
			int getNumber = generator.Next(89);
			int getNumber2 = generator.Next(89);
			int getNumber3 = generator.Next(89);
			RestRequest request = new RestRequest("people/" + getNumber + "/");
			IRestResponse response = client.Get(request);
			RestRequest request2 = new RestRequest("people/" + getNumber2 + "/");
			IRestResponse response2 = client.Get(request2);
			RestRequest request3 = new RestRequest("people/" + getNumber3 + "/");
			IRestResponse response3 = client.Get(request3);
			
			Enemy people1 = JsonConvert.DeserializeObject<Enemy>(response.Content);
			
			
			
			name1 = people1.name; //Sparar resultatet från API requesten och lagrar det i name1 string
			

			Enemy people2 = JsonConvert.DeserializeObject<Enemy>(response2.Content);
			
			name2 = people2.name;
			
			
			
			Enemy people3 = JsonConvert.DeserializeObject<Enemy>(response3.Content);
			
			name3 = people3.name;
			
			Console.WriteLine("Nu skriver jag ut alla namnen");
			Console.WriteLine(name1);
			
			Console.WriteLine(name2);
			
			Console.WriteLine(name3);
			whatEnemy.Add(name1);
			whatEnemy.Add(name2);
			whatEnemy.Add(name3);


		}
		public string writeName()
		{
			
			Console.ReadKey();
			return name1;
		}


		public Enemy()//Konstruktor som kommer köras när en ny instans ev enemy skapas
		{

			int enemyGenerator = generator.Next(whatEnemy.Count); //Slumpar fram vilken enemy det blir i listan
			name = whatEnemy[enemyGenerator]; //name blir det namnet sóm är på den plats som enemygenrator slumpade fram från listan
			

			if (enemyGenerator == 1)
			{
				CharacterStats["hp"] = generator.Next(CharacterStats["hp"], 200);
				CharacterStats["strenght"] = generator.Next(20, 30);
				Console.WriteLine("1Val");
			}
			else if (enemyGenerator == 2)
			{
				CharacterStats["hp"] = generator.Next(CharacterStats["hp"], 200);
				CharacterStats["strenght"] = generator.Next(10, 40);
				Console.WriteLine("2Val");
			}
			else if (enemyGenerator == 3)
			{
				CharacterStats["hp"] = generator.Next(CharacterStats["hp"], 200);
				CharacterStats["strenght"] = generator.Next(1, 70);
				Console.WriteLine("3Val");
			}

		}
		public override int highLowAttack()
		{
			List<string> attacks = new List<string>() { "High Risk", "Low risk" };
			int getAttack = generator.Next(1, 2);
			Console.WriteLine(name + "used" + attacks[getAttack] + "attack");
			return getAttack;


		}

	}
}

	



