using System;
using System.Collections.Generic;

namespace Spells
{
	public class SpellBook
	{
		private readonly List<Spell> _spells;

		public SpellBook()
		{
			_spells = new List<Spell>();
		}

		public void AddSpell(Spell addition)
		{
			_spells.Add(addition);
		}

		public void RemoveSpell(Spell remove)
		{
			_spells.Remove(remove);
		}

		public int SpellCount
		{
			get
			{
				return _spells.Count;
			}
		}

		public Spell this[int i]
		{
			get
			{
				return _spells[i];
			}
		}
	}
}
