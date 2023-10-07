using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextGame
{
	public class Character
	{
		public static string name = "";
		public static int strength = new Random().Next(10, 20);
		public static int health = new Random().Next(20, 30);
		public static int arcana = new Random().Next(1, 10);
		public static int speed = new Random().Next(1, 10);
		public static void characterBuild()
		{
			Console.WriteLine("Enter your name: ");
			Thread.Sleep(2000);
			name = Console.ReadLine();
			Console.WriteLine("Rolling for strength...");
			Thread.Sleep(2000);
			Console.WriteLine("Strength set at " + strength);
			Thread.Sleep(2000);
			Console.WriteLine("Rolling for health..");
			Thread.Sleep(2000); 
			Console.WriteLine("Health set at..." + health);
			Thread.Sleep(2000);
			Console.WriteLine("Rolling for arcana...");
			Thread.Sleep(2000);
			Console.WriteLine("Arcana set at " + arcana);
			Thread.Sleep(2000);


		}
	}
}
