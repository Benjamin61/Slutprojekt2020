using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Rooms : Items
	{
		
		private int findkey;
		protected List<string> roomList = new List<string>() { "Bathroom", "Bedroom", "Kitchen" };
		protected string roomNames;
		protected static Random generator = new Random();
		public Rooms()
		{
			 roomNames = roomList[generator.Next(0, roomList.Count())];//Fortsätt här med att lägga in 1 nyckel i ett random rum
																	   //Console.WriteLine(roomNames);
			findkey = generator.Next(1, 4);
		}

		public int WhatRoom()
		{
			Console.WriteLine("You found the " + roomNames );
			if (findkey == 4)
			{
				Console.WriteLine("You found a key!");
				return findkey;
				key = key + 1;
				Console.WriteLine(key);
			}

			else
			{
				Console.WriteLine("You found no key in this room");
				return generator.Next(5); // Slumpar fram ett tal, beronde på vad talet är kommer man få göra något.

			}
		}
		
	}
}
