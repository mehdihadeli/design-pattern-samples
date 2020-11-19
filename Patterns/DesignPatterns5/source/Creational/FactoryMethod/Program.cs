using System;

namespace FactoryMethod
{
	public static class Program
	{
		private static void Main()
		{
			var creators = new Creator[] { new ConcreteCreatorA(), new ConcreteCreatorB() };

			foreach (var creator in creators)
			{
				Console.WriteLine(creator.FactoryMethod());
			}

			Console.ReadKey();
		}
	}
}
