using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class FightLoop 
	{
		public class getPlayer
		{
			
			



		}
		Player test = new Player();
		public FightLoop()
		{
			
			//Player 3 = new Player();
			int round = 0;

			Bow b1 = new Bow();
			Enemy e1 = new Enemy(); //Skapar en ny instans av enemy
			e1.getEnemy(); //Kör getEnemy metod som hämtar random namn från starwars api och slumpar mellan 3 namn
			while (e1.HP > 0 && test.HP > 0) //En loop som körs så länge båda spelare har över 0 hp kvar
			{

				Console.WriteLine("You encounter " + e1.name + ". that wants to fight!");
				test.DisplayStats(); //Kör metoden displaystats för båda karaktärer
				e1.DisplayStats();

				round++;
				Console.WriteLine("Round [" + round + "]");
				Console.WriteLine("Chose High or low");
				int Damage = test.HighLowAttack(); //Lagrar spelarens val i en int

				int extraDmg = b1.ExtraDmg();


				e1.DamageTaken(test.DamageDone(Damage), extraDmg); //Kör metod som tar bort hp från enemy, använder test metod som parameter

				if (e1.HP > 0) //Om enemy har över 0 hp får hen också attackera
				{
					Damage = e1.HighLowAttack(); //Lagrar e1 val av attack i en int
					test.DamageTaken(e1.DamageDone(Damage), Damage); //Samma som när e1 tog dmg fast omvänt
				}
				if (e1.HP <= 0) //Om enemy har 0 eller mindre hp så vinner man
				{
					Console.WriteLine(e1.name + " Died, You won!");
					Console.WriteLine("Press any key when you are ready to proceed to the next enemy");
					Console.ReadKey();


					Console.Clear();
				}
				else //ÖFÖFÖFÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖÖ
				{
					if (test.HP <= 0) //Om p2 hp är 0 eller under förlorar man
					{


						Console.WriteLine(e1.name + "Has defeated you");
						//completedAllRooms = 2;  //Ändrar completed all rooms så att loopen inte kommer köras längre
					}
				}
			}
		}
	}
}
