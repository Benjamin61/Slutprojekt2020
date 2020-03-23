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
			Console.WriteLine("Your goal is to roam around in the house and find a key to escap!");
			Console.WriteLine("What is your name?");
			string playerName = Console.ReadLine();
			Console.WriteLine("Good luck " + playerName );
			Console.ReadKey();
		}
	}
}
