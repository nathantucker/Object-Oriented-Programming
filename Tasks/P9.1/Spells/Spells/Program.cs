using System;

namespace Spells
{
	class MainClass
	{
		public static void CastAll(SpellBook spellBook)
		{
			for (int i = 0; i < spellBook.SpellCount; i++)
			{
				Console.WriteLine("Casting {0} - {1}", spellBook[i].Name, spellBook[i].Cast());
			}
		}

		public static void Main(string[] args)
		{
			Spell[] spells = new Spell[10];
			SpellBook spirit = new SpellBook();

			spells[0] = new Teleport("\"Mitch\'s mighty mover\"");
			spells[1] = new Heal("\"Alex\'s amazing antidote\"");
			spells[2] = new Transmogrification("\"Rachel\'s reaching regression\"");
			spells[3] = new Teleport("\"Josh\'s jovial jump\"");
			spells[4] = new Heal("\"Hayley\'s high heals\"");
			spells[5] = new Transmogrification("\"Dan\'s dolling dumps\"");
			spells[6] = new Teleport("\"Patty\'s polling push\"");
			spells[7] = new Heal("\"Paige\'s petite polish\"");
			spells[8] = new Transmogrification("\"Ebony\'s elastic earther\"");
			spells[9] = new Teleport("\"Taylor\'s towing transfer\"");

			for (int i = 0; i < 10; i++)
			{
				spirit.AddSpell(spells[i]);
			}
			MainClass.CastAll(spirit);
			Console.ReadLine();
		}
	}
}
