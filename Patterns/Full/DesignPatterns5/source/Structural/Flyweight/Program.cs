using System;

namespace Flyweight
{
	public static class Program
	{
		private static void Main()
		{
			var extrinsicstate = 100;

			var flyweightFactory = new FlyweightFactory();

			flyweightFactory.GetFlyweight("ConcreteFlyweightA").Operation(--extrinsicstate);
			flyweightFactory.GetFlyweight("ConcreteFlyweightB").Operation(--extrinsicstate);
			flyweightFactory.GetFlyweight("ConcreteFlyweightC").Operation(--extrinsicstate);

			new UnsharedConcreteFlyweight().Operation(--extrinsicstate);

			Console.ReadKey();
		}
	}
}
