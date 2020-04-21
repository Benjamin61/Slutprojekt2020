using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Program
	{


		static Random generator = new Random();
		static void Main(string[] args)
		{
			int completedAllRooms = 0;
			Items i1 = new Items();
			Console.WriteLine("Test");
			Console.WriteLine("Your goal is to roam around in the house and find a key to escape!");
			Console.WriteLine("However, In every room there will be an obstacle you need to complete before you can find the key");
			Console.Write("What is your name? ");
			string playerName = Console.ReadLine();
			Console.WriteLine("These are your stats ");
			Player p1 = new Player();//Skapar en ny instan av Player och kör konstruktorn
			p1.name = playerName;


			Console.WriteLine("Good luck " + p1.name);
			Console.WriteLine(p1.name + " Walks towards then end of the hallway when he suddenly sees");
			Console.WriteLine(" 3 rooms with numbers 1-3 on them, Chose a door to enter");
			string whatDoor = Console.ReadLine();
			int roomDecide;
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

			while (completedAllRooms == 0)
			{
				int whatChallenge = onlyQueue.Dequeue().WhatRoom(); //I inten whatchallenge tar paramtern upp värdet i metod whatroom och tar bort 1 rum från listan med Dequeue
				if (whatChallenge == 1)
				{
					Console.WriteLine("Det blev en fight1");
				}
				if (whatChallenge == 2)
				{
					Console.WriteLine("Det blev stensaxpåse2");
				}

				if (whatChallenge == 3)
				{
					Console.WriteLine("Du möter en spådam3");
				}
				if (whatChallenge == 4)
				{
					Console.WriteLine("Vet inte4");
				}
				if (whatChallenge == 5)
				{
					Console.WriteLine("Kom på flera saker5");
				}
				if (completedAllRooms == 1)
				{
					Console.WriteLine("You won");
					Console.ReadLine();
				}
				else if (completedAllRooms == 2)
				{
					Console.WriteLine("You lost");
					Console.ReadLine();
				}
				if (onlyQueue.Count == 0) //Den del av koden kommer köras när Kön av rum är tom. Dvs man har klarat sig igenom alla rum
				{
					Console.WriteLine("You won");
					completedAllRooms = 1;
				}
			}



			Console.ReadKey();
		}
		int FightLoop()
		{
			Console.WriteLine();
			return 1;
		}
		
	}
}
