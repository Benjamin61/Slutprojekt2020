using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Player : CharactherCreation
	{
		public Player()
		{
			Console.WriteLine("Test");
			CharactherStats["hp"] = generator.Next(100, 155);
			Console.WriteLine("Your HP is " + CharactherStats["hp"]);
			CharactherStats["strenght"] = generator.Next(10, 33);
			Console.WriteLine("Your strenght is " + CharactherStats["strenght"]);
			Console.ReadKey();
		}
	}
}
