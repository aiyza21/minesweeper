using System;
namespace MinesweeperProject
{
	public class Opening
	{
		public static void Start()//method sets beginning message
		{ 
			Console.WriteLine("Get ready to mine-sweep!");
			Console.WriteLine("");
			Console.WriteLine("---How to play---");
			Console.WriteLine("Just begin by entering one number at a time and hit enter");
		}

		public static void End()//method sets ending of the game message
		{

			Console.WriteLine("");
			Console.WriteLine("BOOM!You hit a mine!");
			Console.WriteLine("");
			Console.WriteLine("Game Over! :( ");
		}

	}
}

