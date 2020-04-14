using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Program
	{
		static void Main(string[] args)
		{
			Items i1 = new Items();
			Console.WriteLine("Test");
			Console.WriteLine("Your goal is to roam around in the house and find a key to escape!");
			Console.WriteLine("However, In every room there will be an obstacle you need to complete before you can find the key");
			Console.Write("What is your name? ");
			string playerName = Console.ReadLine();
			Console.WriteLine("These are your stats ");
			Player p1 = new Player();//Skapar en ny instan av Player och kör konstruktorn
			p1.name = playerName;
			Random generator = new Random();
			int amount = generator.Next(2, 8);
			Console.WriteLine("Good luck " + p1.name );
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
			Console.WriteLine("Funkar???");
		//	List<Rooms> ShowRooms = new List<Rooms>(amount);

			//	ShowRooms.Add(new Rooms());

			//Console.WriteLine();
			//for (int i = 1; i < amount + 1; i++)
			//{

			//}
			Console.WriteLine(amount);
			Console.WriteLine("Test");
			Console.ReadKey();
		}
	}
}
