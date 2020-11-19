using System;

namespace TemplateMethod
{
	public static class Program
	{
		private static void Main()
		{
			new ConcreteClassA().TemplateMethod();

			new ConcreteClassB().TemplateMethod();

			Console.ReadKey();
		}
	}
}
