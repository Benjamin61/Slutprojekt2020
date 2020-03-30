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
			Console.Write("What is your name?");
			string playerName = Console.ReadLine();
			Console.WriteLine("These are youe stats " + playerName);
			Player P1 = new Player();
			P1.name = playerName;
			
			Console.WriteLine("Good luck " + P1.name );
			Console.ReadKey();
		}
	}
}
