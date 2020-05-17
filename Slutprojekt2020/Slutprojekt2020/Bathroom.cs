using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt2020
{
	class Bathroom : Rooms
	{
		
		private Dictionary<string, int> playerStats = new Dictionary<string, int>();
		private Dictionary<string, int> enemyStats = new Dictionary<string, int>();
		public Bathroom()
		{
			playerStats.Add("hp", 5);
			playerStats.Add("strenght", 1);

			enemyStats.Add("hp", 10);
			enemyStats.Add("strenght", 2);
			
			
		}

		public Dictionary<string, int> ImportStats(Dictionary<string, int> placeholder)
		{
			playerStats = placeholder;
			return placeholder;
		}

		public void FightLoop(Player p1, Enemy e1)
		{

			
			

			Bow b1 = new Bow();
			 
			e1.GetEnemy(); //Kör getEnemy metod som hämtar random namn från starwars api och slumpar mellan 3 namn
			while (e1.HP > 0 && p1.HP > 0) //En loop som körs så länge båda spelare har över 0 hp kvar
			{
				int round = -1;
				round++;
				Console.WriteLine("You encounter " + e1.name + ". that wants to fight!");
				p1.DisplayStats(); //Kör metoden displaystats för båda karaktärer
				e1.DisplayStats();

				round++;
				Console.WriteLine("Round [" + round + "]");
				Console.WriteLine("Chose High or low");
				int Damage = p1.HighLowAttack(); //Lagrar spelarens val i en int

				int extraDmg = b1.ExtraDmg();


				e1.DamageTaken(p1.DamageDone(Damage), extraDmg); //Kör metod som tar bort hp från enemy, använder p1 metod som parameter

				if (e1.HP > 0) //Om enemy har över 0 hp får hen också attackera
				{
					Damage = e1.HighLowAttack(); //Lagrar e1 val av attack i en int
					p1.DamageTaken(e1.DamageDone(Damage), Damage); //Samma som när e1 tog dmg fast omvänt
				}
				if (e1.HP <= 0) //Om enemy har 0 eller mindre hp så vinner man
				{
					Console.WriteLine(e1.name + " Died, You won!");
					Console.WriteLine("Press any key when you are ready to proceed to the next enemy");
					Console.ReadKey();
					


					
				}
				else 
				{
					


						Console.WriteLine(e1.name + "Has defeated you");
						p1.SetWinner(2); //Ändrar temp värdet till 2 så att  wincheck == 2 dvs man förlorar
					
						p1.PlayerResults(false); //Boolen kommer bli false och spelet avslutas
					
						
					
				}
			}
		}
	}
}
