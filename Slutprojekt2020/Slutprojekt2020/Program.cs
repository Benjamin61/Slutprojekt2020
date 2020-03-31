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
			 
			Console.WriteLine("Test");
			Console.WriteLine("Your goal is to roam around in the house and find a key to escape!");
			Console.WriteLine("However, In every room there will be an obstacle you need to complete before you can find the key");
			Console.Write("What is your name? ");
			string playerName = Console.ReadLine();
			Console.WriteLine("These are your stats ");
			Player P1 = new Player();//Skapar en ny instan av Player och kör konstruktorn
			P1.name = playerName;
			Random generator = new Random();
			int amount = generator.Next(2, 8);
			Console.WriteLine("Good luck " + P1.name );
			List<Rooms> ShowRooms = new List<Rooms>(amount);
			Console.WriteLine(P1.name + " Walks towards then end of the hallway when he suddenly sees the ");
			ShowRooms.Add(new Rooms());

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
