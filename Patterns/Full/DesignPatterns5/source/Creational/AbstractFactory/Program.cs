using System;

namespace AbstractFactory
{
	public static class Program
	{
		private static void Main()
		{
			new Client(new ConcreteFactoryA()).Run();
			new Client(new ConcreteFactoryB()).Run();

			Console.ReadKey();
		}
	}
}
