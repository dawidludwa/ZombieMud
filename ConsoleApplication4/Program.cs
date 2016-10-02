using Library.Units;
using System;

namespace ConsoleApplication4
{

	class Program
	{
		static void Main(string[] args)
		{
			
			NpcFactory locationFactory = new NpcFactory();
			var unit = locationFactory.CreateUnit();
			var zombieUnit = locationFactory.CreateZombieUnit();

			zombieUnit.Attack(unit);
			unit.Attack(zombieUnit);
			

			var locFact = new Library.Locations.LocationFactory();

			var llol = locFact.Create("forest");
			llol.Add(locFact.Create("cave"));
			llol.Add(locFact.Create("medow"));
			var lol = llol.GetRandomLocation();
			Console.ReadKey();
		}
	}
}
