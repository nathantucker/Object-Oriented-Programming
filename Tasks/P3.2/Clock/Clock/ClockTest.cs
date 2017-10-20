using NUnit.Framework;
using System;

namespace Clock
{
	[TestFixture()]
	public class ClockTest
	{
		[Test()]
		public void OneMinute()
		{
			Clock unit = new Clock();
			unit.Tick();
			Assert.AreEqual
		}

		[Test()]
		public void OneHour()
		{
		}

		[Test()]
		public void OneDay()
		{
		}
	}
}
