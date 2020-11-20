using System;

namespace Command
{
	public static class Program
	{
		private static void Main()
		{
			var receiver = new Receiver();
			var command = new ConcreteCommand(receiver);
			var invoker = new Invoker();

			invoker.SetCommand(command);
			invoker.ExecuteCommand();

			Console.ReadKey();
		}
	}
}
