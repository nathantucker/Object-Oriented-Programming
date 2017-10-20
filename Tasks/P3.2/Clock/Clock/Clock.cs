using System;

namespace Clock
{
	public class Clock
	{
		private Counter _seconds;
		private Counter _minutes;
		private Counter _hours;

		public Clock()
		{
			_seconds = new Counter();
			_minutes = new Counter();
			_hours = new Counter();
		}

		public void Tick()
		{
			_seconds.Increment();
			if (_seconds.Value == 60)
			{
				_minutes.Increment();
				_seconds.Reset();
			}

			if (_minutes.Value == 60)
			{
				_hours.Increment();
				_minutes.Reset();
			}

			if (_hours.Value == 24)
			{
				_seconds.Increment();
				_hours.Reset();
			}
		}

		public string Time()
		{
			string time = _hours.Value.ToString("00") + ":" + _minutes.Value.ToString("00") + ":" + _seconds.Value.ToString("00");
			return time;
		}
	}
}
