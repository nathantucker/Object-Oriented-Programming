using System;

namespace Spells
{
	public class Heal : Spell
	{
		private static Random _random = new Random();
		private bool _success;

		public Heal(string spellName) : base(spellName, SpellKind.Heal)
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
			if (_random.NextDouble() < 0.8)
			{
				_success = true;
			}
			else
			{
				_success = false;
			}

			if (_success)
			{
				return "You Have Been Healed";
			}
			else
			{
				return "OUCH";
			}
		}
	}
}
