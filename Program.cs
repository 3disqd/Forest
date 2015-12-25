using System;

namespace Forest
{
	class Program
	{
		static void Main(string[] args)
		{
			IMapReader reader = new MapReader();
			var map = reader.ReadFrom("Maps/map2.txt");
			var forest = new FunkyForest(map);
			var visualisator = new Visualisator();
			forest.OnChange += visualisator.OnNewState;
			Console.ReadKey();
			forest.Put("John",new Point(1,1));
			Console.ReadKey();
            forest.Auto("John", new Point(4, 4));
			Console.ReadKey();

		}
	}
}
