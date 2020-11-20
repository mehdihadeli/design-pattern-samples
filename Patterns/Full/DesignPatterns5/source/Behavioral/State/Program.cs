using System;

namespace State
{
	public static class Program
	{
		private static void Main()
		{
			var context = new Context(new ConcreteStateA());

			Console.WriteLine($"State: {context.State}");

			context.Request();

			Console.WriteLine($"State: {context.State}");

			context.Request();

			Console.WriteLine($"State: {context.State}");

			context.Request();

			Console.WriteLine($"State: {context.State}");

			Console.ReadKey();
		}
	}
}
