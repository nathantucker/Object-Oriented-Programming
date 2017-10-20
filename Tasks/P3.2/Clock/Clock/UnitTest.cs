using NUnit.Framework;
using System;

namespace Clock
{
	[TestFixture()]
	public class UnitTest
	{
		Counter counterUnit;
		Clock clockUnit;

		[SetUp()]
		public void init()
		{
			counterUnit = new Counter();
			clockUnit = new Clock();
		}

		[Test()]
		public void StartCounter()
		{
			Assert.AreEqual(0, counterUnit.Value);
		}

		[Test()]
		public void IncrementCounter()
		{
			counterUnit.Increment();
			Assert.AreEqual(1, counterUnit.Value);
		}

		[Test()]
		public void MultipleIncrements()
		{
			counterUnit.Increment();
			counterUnit.Increment();
			counterUnit.Increment();
			Assert.AreEqual(3, counterUnit.Value);
		}

		[Test()]
		public void ResetCounter()
		{
			counterUnit.Increment();
			counterUnit.Increment();
			counterUnit.Increment();
			counterUnit.Reset();
			Assert.AreEqual(0, counterUnit.Value);
		}

		[Test()]
		public void OneSecond()
		{
			clockUnit.Tick();
			Assert.AreEqual("00:00:01", clockUnit.Time());
		}

		[Test()]
		public void OneMinute()
		{
			for (int i = 0; i < 60; i++)
				clockUnit.Tick();
			Assert.AreEqual("00:01:00", clockUnit.Time());
		}

		[Test()]
		public void OneHour()
		{
			for (int i = 0; i < 3600; i++)
				clockUnit.Tick();
			Assert.AreEqual("01:00:00", clockUnit.Time());
		}
	}
}
