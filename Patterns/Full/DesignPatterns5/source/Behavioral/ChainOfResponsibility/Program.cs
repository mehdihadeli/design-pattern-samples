using System;

namespace ChainOfResponsibility
{
	public static class Program
	{
		private static void Main()
		{
			var concreteHandlerA = new ConcreteHandlerA();
			var concreteHandlerB = new ConcreteHandlerB();
			var concreteHandlerC = new ConcreteHandlerC();

			concreteHandlerA.SetSuccessor(concreteHandlerB);
			concreteHandlerB.SetSuccessor(concreteHandlerC);

			concreteHandlerA.HandleRequest("Request");

			Console.ReadKey();
		}
	}
}
