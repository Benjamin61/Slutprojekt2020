using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class CharactherCreation
	{
		public string name;
		//protected int strenght; //Försöker använda mig av en dictionary men har kvar detta om det inte funkar

		//protected int hp;
		protected Dictionary<string, int> CharacterStats = new Dictionary<string, int>(); //Istället för en string och ints så kan jag spara båda parametrar på ett och samma ställe

		

		protected static Random generator = new Random(); //Generator

		public CharactherCreation() //Bas värden för alla instanser en enemy och p1 som kommer att skapas
		{
			CharacterStats.Add("hp", 150); 
			CharacterStats.Add("strenght", 0);
		}

		public int HP 
		{
			get
			{
				return CharacterStats["hp"]; //retunerar hp
			}
		set { }
	        }
		public void DisplayStats() //Metod för att visa statistiken för en instans av en klass
		{
			Console.WriteLine(" Now displaying " + name + " stats");
			Console.WriteLine("HP: " + CharacterStats["hp"]);
			Console.WriteLine("Strenght: " + CharacterStats["strenght"]);
			//Console.WriteLine("HP:" + hp);
			//Console.WriteLine("Strenght" + hp);
		}

		

		public virtual int DamageDone(int amount) //Metod för att göra damage
		{
			int randomCrit = generator.Next(1, 6); //Slumpar fram ett nmr
			int dmg = 20;
			if (randomCrit == 4) // 1 på 6 chans att göra extra dmg
			{
				Console.WriteLine("Random crit! Next hit will be empowered by 200%");
				dmg = dmg + generator.Next(CharacterStats["strenght"], (CharacterStats["strenght"] + 3)); //Dmg kommer vara något mellan Karaktärens styrka +3
				dmg = dmg * 3;
				//Console.WriteLine("You did " + dmg + " To the enemyKAN DET HÄR TAS BORT1!");
			}
			else
			{
				dmg = generator.Next(CharacterStats["strenght"], (CharacterStats["strenght"] + 3));
				//Console.WriteLine("You did " + dmg + " To the enemyKAN DET HÄR TASBORT2!");
			}
			return dmg;

		}

		public int DamageTaken(int amount) //Metod för att skriva ut hur mycket dmg man tagit
		{
			
			CharacterStats["hp"] = CharacterStats["hp"] - amount;
			Console.WriteLine(name + " took " + amount + " damage and now has " + CharacterStats["hp"] + " hp left");
			return CharacterStats["hp"];
		}
		

		public virtual int highLowAttack() //En metod för att låra spelaren välja typ av attack
		{
			Console.WriteLine("[1] High risk or [2] Low risk");
			string choice = Console.ReadLine(); //Lagrar valet i en string
			int playerChoice;
			bool transform = int.TryParse(choice, out playerChoice); //Försöker göra om spelarens input till en int
			while (!transform || playerChoice != 1 && playerChoice != 2) //Om svaret inte är 1 eller 2 får man försöka igen
			{
				Console.WriteLine("Try again. Rember to answer 1 or 2");
				choice = Console.ReadLine();
				transform = int.TryParse(choice, out playerChoice);
				
				
			}
			if (playerChoice == 1) //Skriver ut vilken typ av attack man valde
			{
				Console.WriteLine("You chose High risk");
			}

			else
			{
				Console.WriteLine("You chose Low risk");
			}
			return playerChoice; //Retunerar spelarens val så att det kan användas för slumpa fram attacken.
		}
	}
}
