using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Slutprojekt2020
{
	class Rooms : CharactherCreation
	{

		
		protected List<string> roomList = new List<string>() { "Bathroom", "Bedroom", "Kitchen" }; //Finns 3 olika rum man kan hamna i
		protected string roomNames;
		//protected static Random generator = new Random();
		public Rooms()
		{
			roomNames = roomList[generator.Next(1, roomList.Count())];
		}

		public int WhatRoom() //Just nu skapas enbart instanser av bathroom då jag endast har ett minigame skapad för det rummet
		{
			
			Console.WriteLine("You found the " + roomNames);
			if (roomNames == "Bathroom")
			{
				
				Bathroom b1 = new Bathroom();
			}
			else if (roomNames == "Bedroom")
			{

				Bathroom b1 = new Bathroom();
			}
			else
			{
				Bathroom b1 = new Bathroom();
			}
            return generator.Next(5); // Slumpar fram ett tal, beronde på vad talet är kommer man få göra ett minigame. //Denna del funkar komplett men har inte gjort olika minigames

			
		}
		
		
		
	}
}
