using System;

namespace Strategy
{
	public static class Program
	{
		private static void Main()
		{
			new Context(new ConcreteStrategyA()).Method();

			new Context(new ConcreteStrategyB()).Method();

			new Context(new ConcreteStrategyC()).Method();

			Console.ReadKey();
		}
	}
}
