using System;

namespace CounterTest
{
	class MainClass
	{
		public static void PrintCounters(Counter[] counters)
		{
			foreach (Counter c in counters)
			{
				Console.WriteLine("{0} is {1}", c.Name, c.Value);
			}
		}

		public static void Main(string[] args)
		{
			Counter[] myCounters = new Counter[3];
			int i;

			myCounters[0] = new Counter("Counter 1");
			myCounters[1] = new Counter("Counter 2");
			myCounters[2] = myCounters[0];

			for (i = 0; i < 4; i++) 
			{
				myCounters[0].Increment();
			}

			for (i = 0; i < 9; i++)
			{
				myCounters[1].Increment();
			}

			MainClass.PrintCounters(myCounters);

			myCounters[2].Reset();
			             
			MainClass.PrintCounters(myCounters);

			Console.ReadLine();
		}
	}

}
