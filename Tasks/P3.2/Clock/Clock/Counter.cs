using System;

namespace Clock
{
	public class Counter
	{
		private int _count;

		public Counter()
		{
			_count = 0;
		}

		public void Increment()
		{
			_count += 1;
		}

		public void Reset()
		{
			_count = 0;
		}

		public int Value
		{
			get
			{
				return _count;
			}
		}
	}
}
