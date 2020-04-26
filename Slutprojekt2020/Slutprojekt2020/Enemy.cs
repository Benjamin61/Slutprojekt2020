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
		public int enemyGenerator;

		//{ "Test1", "Test2", "Test3", };//Ska försöka göra en api istället
		//List<String> whatEnemy = new List<string>();




		



		public void getEnemy()
		{
			RestClient client = new RestClient("https://swapi.dev/api/"); //En client som skickar en förfrågan till starwars api
			int getNumber = generator.Next(89); //Slumpar fram ett nummber
			int getNumber2 = generator.Next(89);
			int getNumber3 = generator.Next(89);
			RestRequest request = new RestRequest("people/" + getNumber + "/"); //En request till api met url people/randomnumber/ + adressen från RestClient
			IRestResponse response = client.Get(request); //Get som hämtar namn från starwars api
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

			
			
			List<String> whatEnemy = new List<string>(); //Skapar en lista
			whatEnemy.Add(name1); //Lägger in namnen från API requesten i listan
			whatEnemy.Add(name2);
			whatEnemy.Add(name3);
			
			enemyGenerator = generator.Next(whatEnemy.Count); //Slumpar fram vilken enemy det blir i listan
			name = whatEnemy[enemyGenerator];
			

			
			
			

		}


		public Enemy()//Konstruktor som kommer köras när en ny instans ev enemy skapas
		{

			int EnemyAttacks = generator.Next(1, 4); //Slumpar fram vilken typ av attack det blir
			

			
			
			

			if (EnemyAttacks == 1) //Om svaret blir 1 skapas dessa värden för enemy
			{
				CharacterStats["hp"] = generator.Next(CharacterStats["hp"], 200);
				CharacterStats["strenght"] = generator.Next(20, 30);
				
			}
			else if (EnemyAttacks == 2) //Samma fast andra värden
			{
				CharacterStats["hp"] = generator.Next(CharacterStats["hp"], 200);
				CharacterStats["strenght"] = generator.Next(10, 40);
				
			}
			else if (EnemyAttacks == 3)
			{
				CharacterStats["hp"] = generator.Next(CharacterStats["hp"], 200);
				CharacterStats["strenght"] = generator.Next(1, 70);
				
			}

		}
		public override int highLowAttack() //Override metod för att göra så att enemy kan välja high eller low risk attack också
		{
			List<string> attacks = new List<string>() { "High Risk", "Low risk" };
			int getAttack = generator.Next(1, 2); //Slumpar fram vilken typ av attack enemy använder
			Console.WriteLine(name + "used" + attacks[getAttack] + "attack");
			return getAttack;


		}

		

	}
}

	



