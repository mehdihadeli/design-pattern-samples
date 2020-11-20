using System;

namespace Visitor
{
	public static class Program
	{
		private static void Main()
		{
			var objectStructure = new ObjectStructure();

			objectStructure.Attach(new ConcreteElementA());
			objectStructure.Attach(new ConcreteElementB());

			objectStructure.Accept(new ConcreteVisitorA());
			objectStructure.Accept(new ConcreteVisitorB());

			Console.ReadKey();
		}
	}
}
