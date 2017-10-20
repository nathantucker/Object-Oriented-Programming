using System;

namespace Clock
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Clock myClock = new Clock();

			for (int i = 0; i < 86400; i++)
			{
				myClock.Tick();
				Console.WriteLine(myClock.Time());
			}
			Console.Read();
		}
	}
}
