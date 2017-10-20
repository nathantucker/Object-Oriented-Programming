using System;

namespace Spells
{
	public class Teleport : Spell
	{
		private static Random _random = new Random();
		private bool _success;

		public Teleport(string spellName) : base(spellName, SpellKind.Teleport)
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
				return "Location Moved";
			}
			else
			{
				return "*BANG*";
			}
		}
	}
}
