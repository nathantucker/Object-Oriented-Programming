using System;

namespace Spells
{
	public class Transmogrification : Spell
	{
		private static Random _random = new Random();
		private bool _success;

		public Transmogrification(string spellName) : base(spellName, SpellKind.Transmogrification)
		{
		}

		public bool Success
		{
			get
			{
				return _success;
			}
		}

		public override string Cast()
		{
			if (_random.NextDouble() < 0.5)
			{
				_success = true;
			}
			else
			{
				_success = false;
			}

			if (_success)
			{
				return "*THUMP*";
			}
			else
			{
				return "Squeak Squeak";
			}
		}
	}
}
