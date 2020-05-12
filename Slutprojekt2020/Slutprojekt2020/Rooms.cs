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
		protected static Random generator = new Random();
		

		public int WhatRoom()
		{
			roomNames = roomList[generator.Next(0, roomList.Count())];
			Console.WriteLine("You found the " + roomNames);
			if (roomNames == "Bathroom")
			{
				Console.WriteLine("Test test BathroomS");
				Bedroom b1 = new Bedroom();
			}
			else if (roomNames == "Bedroom")
			{
				Console.WriteLine("Test test BedroomS");
				Bedroom b1 = new Bedroom();
			}
			else
			{
				Console.WriteLine("Test test KitchenS");
				Bedroom b1 = new Bedroom();
			}
            return generator.Next(5); // Slumpar fram ett tal, beronde på vad talet är kommer man få göra ett minigame. //Denna del funkar komplett men har inte gjort olika minigames

			
		}
		
		
		
	}
}
