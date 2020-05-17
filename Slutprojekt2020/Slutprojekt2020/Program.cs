using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Slutprojekt2020
{
	class Program
	{
		
		
		static Random generator = new Random();
		static void Main(string[] args)
		{

			Player p1 = new Player();//Skapar en ny instan av Player och kör konstruktorn

			//Characther.whatEnemys();


			p1.Start();
			p1.InputCheck();
			
			//int input = InputCheck();




			



			

			int amountOfRooms = generator.Next(2, 5);//Slumpar fram hur många rum som genereras


			Queue<Rooms> allRooms = new Queue<Rooms>(); //Istället för en list skapas en kör där alla rum samlas

			for (int i = 0; i < amountOfRooms + 1; i++)
			{
				allRooms.Enqueue(new Rooms()); //Skapar ny instanser av Rooms till det nått upp till det slumpade antalet AmountofRooms
			}

			while (p1.GetWhoWon() == 0) //Så längen inten get who won är 0 så kommer denna loop att fortsätta
			{
				int whatChallenge = allRooms.Dequeue().WhatRoom(); //I inten whatchallenge tar paramtern upp värdet i metod whatroom och tar bort 1 rum från listan med Dequeue
				if (whatChallenge == 1 || whatChallenge == 2 || whatChallenge == 3 || whatChallenge == 4 || whatChallenge == 5) //Just nu leder alla rum till en fight, men programmet funkar så man kan göra olika challenges berodne på vilket rum man hamnar i
				{
					Enemy e1 = new Enemy(); //Skapar en fiende
					Bathroom b1 = new Bathroom(); //Skapar ett rum
					b1.ImportStats(p1.GetStats()); //Importerat stats från p1s get stats till metoden importstats i bathroom
					b1.FightLoop(p1, e1); //Kör en fightloop för bathroom med e1 och p1 som parametrar

				}



				
				if (!allRooms.Any()) //Den del av koden kommer köras när Kön av rum är tom. Dvs man har klarat sig igenom alla rum
				{
					p1.PlayerResults(true);
					Console.WriteLine("You cleared all the rooms! Congratulations");
					Console.WriteLine("When you press enter the game will be closed");
					Console.ReadKey();


				}
			}



			Console.ReadKey();
		}

		
		

		
		
		
		
	}
}
