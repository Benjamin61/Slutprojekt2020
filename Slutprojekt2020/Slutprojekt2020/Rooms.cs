using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Rooms
	{
		protected int key;
		protected List<string> roomList = new List<string>() { "Bathroom", "Bedroom", "Kitchen" };
		protected string roomNames;
		protected static Random generator = new Random();
		public Rooms()
		{
			 roomNames = roomList[generator.Next(1, roomList.Count())];//Fortsätt här med att lägga in 1 nyckel i ett random rum
			Console.WriteLine(roomNames);
		}

		
	}
}
