using System;

namespace Spells
{
	public abstract class Spell
	{
		private string _name;
		private SpellKind _kind;

		public Spell(string name, SpellKind kind)
		{
			_name = name;
			_kind = kind;
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public SpellKind Kind
		{
			get
			{
				return _kind;
			}
		}

		public abstract string Cast();
	}
}
