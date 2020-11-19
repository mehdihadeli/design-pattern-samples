using System;

namespace Adapter
{
	public static class Program
	{
		private static void Main()
		{
			new Adapter().Request();

			Console.ReadKey();
		}
	}
}
