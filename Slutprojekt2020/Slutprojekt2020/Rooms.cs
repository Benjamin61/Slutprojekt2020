using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Slutprojekt2020
{
	class Rooms : Items
	{

		
		protected List<string> roomList = new List<string>() { "Bathroom", "Bedroom", "Kitchen" };
		protected string roomNames;
		protected static Random generator = new Random();
		public Rooms()
		{
			 roomNames = roomList[generator.Next(0, roomList.Count())];//Fortsätt här med att lägga in 1 nyckel i ett random rum
																	   //Console.WriteLine(roomNames);
			
		}

		public int WhatRoom()
		{
			Console.WriteLine("You found the " + roomNames);
			
            return generator.Next(5); // Slumpar fram ett tal, beronde på vad talet är kommer man få göra ett minigame.

			
		}
		
		
		
	}
}
