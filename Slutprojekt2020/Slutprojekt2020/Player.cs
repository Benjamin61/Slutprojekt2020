using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Player : CharactherCreation
	{
		private int winCheck = 0;
		public Player() //En konsturktor som fastställer P1 grund stats
		{

			CharacterStats["hp"] = generator.Next(10000, 10000);
			Console.WriteLine("Your HP is " + CharacterStats["hp"]);
			CharacterStats["strenght"] = generator.Next(10000, 20000);
			Console.WriteLine("Your strenght is " + CharacterStats["strenght"]);
			Console.ReadKey();
			
		}
		public void Start() //Introduktioner till spelet
		{
			Console.WriteLine("Your goal is to roam around in the house and find a key to escape!"); //Förklara spelet
			Console.WriteLine("However, In every room there will be an obstacle you need to complete before you can find the key");
			Console.Write("What is your name? ");
			string playerName = Console.ReadLine(); //Lagrar spelarens namn i en string
			Console.WriteLine("These are your stats ");



			name = playerName; //Sätter in spelarens input i instansens namn
								  //Weapons w1 = new Weapons();


			Console.WriteLine("Good luck " + name);
			Console.WriteLine(name + " Walks towards then end of the hallway when he suddenly sees");
			Console.WriteLine(" 3 rooms with numbers 1-3 on them, Chose a door to enter");

			
		}
		
		public int GetWhoWon() //Metod för att se om det spelaren vunnit
		{
			return winCheck;
		}
		public void SetWinner(int temp) //Hämtar ett värdet från resultatet av fighten
		{
			winCheck = temp;
			
		}

		public bool PlayerResults(bool temp) //Bool som ändras beroende på om man dör av enemy eller vinner
		{
			if (winCheck == 1)
			{
				
				return true; //Win check blir 1 och spelet forsätter
			}
			else if (winCheck == 2)
			{
				Console.WriteLine("You lost, therefore the game will close once you press enter");
				Console.ReadKey();
				return true;
			}
			else
			{
				return false;
			}
		}
		public int InputCheck() //Felsöknings metod för rummet man vill gå in i
		{
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
			return roomDecide;
		}

	}
}
