using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Slutprojekt2020
{
	class Rooms 
	{

		
		protected List<string> roomList = new List<string>() { "Bathroom", "Bedroom", "Kitchen" }; //Finns 3 olika rum man kan hamna i
		protected string roomNames;
		protected static Random generator = new Random();
		public Rooms() //Skapar en ny instans av ett rum med ett random namn från listan ovan
		{
			 roomNames = roomList[generator.Next(0, roomList.Count())];//Fortsätt här med att lägga in 1 nyckel i ett random rum
																	   //Console.WriteLine(roomNames);
			
		}

		public int WhatRoom()
		{
			Console.WriteLine("You found the " + roomNames);
			
            return generator.Next(5); // Slumpar fram ett tal, beronde på vad talet är kommer man få göra ett minigame. //Denna del funkar komplett men har inte gjort olika minigames

			
		}
		
		
		
	}
}
