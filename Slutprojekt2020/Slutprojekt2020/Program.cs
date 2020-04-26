using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Slutprojekt2020
{
	class Program
	{
		
		
		static Random generator = new Random();
		static void Main(string[] args)
		{


			
			//Characther.whatEnemys();
			
			
			
			
			
			
			
			
			int completedAllRooms = 0; //En int som kommer ändras beroende på om man klarat alla rum
			
			
			Console.WriteLine("Your goal is to roam around in the house and find a key to escape!"); //Förklara spelet
			Console.WriteLine("However, In every room there will be an obstacle you need to complete before you can find the key");
			Console.Write("What is your name? ");
			string playerName = Console.ReadLine(); //Lagrar spelarens namn i en string
			Console.WriteLine("These are your stats ");
			Player p1 = new Player();//Skapar en ny instan av Player och kör konstruktorn
			Console.WriteLine("Nu har p1 körts");
			bow b1 = new bow();
			p1.name = playerName; //Sätter in spelarens input i instansens namn
			//Weapons w1 = new Weapons();


			Console.WriteLine("Good luck " + p1.name);
			Console.WriteLine(p1.name + " Walks towards then end of the hallway when he suddenly sees");
			Console.WriteLine(" 3 rooms with numbers 1-3 on them, Chose a door to enter");
			string whatDoor = Console.ReadLine(); //Man får välja vilket rum man vill gå in i
			int roomDecide; //Felsökning, så att spelaren inte kan krascha spelet
			bool correctRoomInput = int.TryParse(whatDoor, out roomDecide);
			while (!correctRoomInput || roomDecide <= 0 || roomDecide >= 4)
			{
				Console.WriteLine("Try again, remember to answer in numbers(1,2 or 3)");
				Console.Write("Choice:");
				whatDoor = Console.ReadLine();
				correctRoomInput = int.TryParse(whatDoor, out roomDecide);

			}

			int amountOfRooms = generator.Next(3, 10);//Slumpar fram hur många rum som genereras


			Queue<Rooms> onlyQueue = new Queue<Rooms>(); //Istället för en list skapas en kör där alla rum samlas

			for (int i = 0; i < amountOfRooms + 1; i++)
			{
				onlyQueue.Enqueue(new Rooms()); //Skapar ny instanser av Rooms till det nått upp till det slumpade antalet AmountofRooms
			}

			while (completedAllRooms == 0) //Så längen inten completeedAllRooms == 0 så kommer denna loop att fortsätta
			{
				int whatChallenge = onlyQueue.Dequeue().WhatRoom(); //I inten whatchallenge tar paramtern upp värdet i metod whatroom och tar bort 1 rum från listan med Dequeue
				if (whatChallenge == 1 || whatChallenge == 2 || whatChallenge == 3 || whatChallenge == 4 || whatChallenge == 5) //Just nu leder alla rum till en fight, men programmet funkar så man kan göra olika challenges berodne på vilket rum man hamnar i
				{
					Console.WriteLine("Det blev en fight1");
					int round = 0;
					
					
					Enemy e1 = new Enemy(); //Skapar en ny instans av enemy
					e1.getEnemy(); //Kör getEnemy metod som hämtar random namn från starwars api och slumpar mellan 3 namn
					while (e1.HP > 0 && p1.HP > 0) //En loop som körs så länge båda spelare har över 0 hp kvar
					{
						//Console.Clear();
						Console.WriteLine("You encounter " + e1.name + ". that wants to fight!");
						p1.DisplayStats(); //Kör metoden displaystats för båda karaktärer
						e1.DisplayStats();
						//i1.DisplayStats();
						round++;
						Console.WriteLine("Round [" + round + "]");
						Console.WriteLine("Chose High or low");
						int Damage = p1.highLowAttack(); //Lagrar spelarens val i en int
						
						e1.DamageTaken(p1.DamageDone(Damage)); //Kör metod som tar bort hp från enemy, använder p1 metod som parameter
						if (e1.HP > 0) //Om enemy har över 0 hp får hen också attackera
						{
							Damage = e1.highLowAttack(); //Lagrar e1 val av attack i en int
							p1.DamageTaken(e1.DamageDone(Damage)); //Samma som när e1 tog dmg fast omvänt
						}
						if (e1.HP <= 0) //Om enemy har 0 eller mindre hp så vinner man
						{
							Console.WriteLine(e1.name + " Died, You won!");
							Console.WriteLine("Press any key when you are ready to proceed to the next enemy");
							Console.ReadKey();
							
							//Console.Clear();
						}
						else //ÖFÖFÖFÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖ
						{
							if (p1.HP <= 0) //Om p1 hp är 0 eller under förlorar man
							{
								

								Console.WriteLine(e1.name + "Has defeated you");
								completedAllRooms = 2;  //Ändrar completed all rooms så att loopen inte kommer köras längre
							}
						}
						
						
						Console.ReadKey();

																  
						
					}
				}
				if (whatChallenge == 2) //Har var tanken att ha olika minigames beroende på vilket rum nr som slumpades men har inte gjort flera minigames
				{
					//Console.WriteLine("Det blev stensaxpåse2");
				}

				if (whatChallenge == 3)
				{
					//Console.WriteLine("Du möter en spådam3");
				}
				if (whatChallenge == 4)
				{
					//Console.WriteLine("Vet inte4");
				}
				if (whatChallenge == 5)
				{
					//Console.WriteLine("Kom på flera saker5");
				}
				/*if (completedAllRooms == 1)
				{
					Console.WriteLine("You won this fight");
					Console.WriteLine("Här?");
					Console.ReadLine();
				}*/
				else if (completedAllRooms == 2)
				{
					Console.WriteLine("You lost");
					Console.ReadLine();
				}
				if (onlyQueue.Count == 0) //Den del av koden kommer köras när Kön av rum är tom. Dvs man har klarat sig igenom alla rum
				{
					Console.WriteLine("You cleared all the rooms! Congratulations");
					Console.WriteLine("Quee tom");
					
				}
			}



			Console.ReadKey();
		}
		
		/*static void GetEnemy()
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

			
			Enemy e1 = new Enemy();
			
			
			Enemy people1 = JsonConvert.DeserializeObject<Enemy>(response.Content);
			e1.name1 = people1.name;
			Console.WriteLine(e1.name1);
			Console.WriteLine("här3Enemy1Ovan?");
			Console.ReadKey();
			Enemy people2 = JsonConvert.DeserializeObject<Enemy>(response2.Content);
			e1.name2 = people2.name;
			Console.WriteLine(e1.name2);
			Console.WriteLine("här4Enemy2Ovan?");
			Console.ReadKey();
			Enemy people3 = JsonConvert.DeserializeObject<Enemy>(response3.Content);
			e1.name3 = people3.name;
			Console.WriteLine(e1.name3);
			Console.WriteLine("här5Enemy3Ovan?");
			Console.ReadKey();

			e1.getEnemy();
			Console.WriteLine("här6RandomEnemy");
			Console.ReadKey();
			//Lagrar namnet jag fick från api i e1 instansens string name










			Console.ReadKey();



		}*/
		
		
		
	}
}
