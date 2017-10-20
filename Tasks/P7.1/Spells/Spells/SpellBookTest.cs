using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Spells
{
	[TestFixture()]
	public class SpellBookTest
	{
		[Test()]
		public void SpellAdditionTest()
		{
			SpellBook myBook = new SpellBook();
			Teleport testSpell = new Teleport("\"Mitch\'s mighty mover\"");

			Spell s = testSpell;
			myBook.AddSpell(s);

			Assert.IsNotNull(myBook[0]);
			Assert.AreEqual(myBook[0].Name, "\"Mitch\'s mighty mover\"");
			Assert.AreEqual(myBook[0].Kind, SpellKind.Teleport);
		}

		[Test()]
		public void SpellFetchTest()
		{
			SpellBook myBook = new SpellBook();
			Spell[] testSpell =
			{
				new Teleport ("\"Mitch\'s mighty mover\""),
				new Heal ("\"Alex\'s amazing antidote\""),
				new Transmogrification ("\"Rachel\'s reaching regression\"")
			};

			for (int i = 0; i < testSpell.Length; i++)
			{
				Spell s = testSpell[i];
				myBook.AddSpell(s);
			}

			Assert.AreEqual(myBook[0], testSpell[0]);
			Assert.AreEqual(myBook[1], testSpell[1]);
			Assert.AreEqual(myBook[2], testSpell[2]);
		}

		[Test()]
		public void SpellRemovalTest()
		{
			SpellBook myBook = new SpellBook();
			Spell[] testSpell = {
				new Teleport ("\"Mitch\'s mighty mover\""),
				new Heal ("\"Alex\'s amazing antidote\""),
				new Transmogrification ("\"Rachel\'s reaching regression\"")
			};

			for (int i = 0; i < testSpell.Length; i++)
			{
				Spell s = testSpell[i];
				myBook.AddSpell(s);
			}

			Assert.AreEqual(myBook[1], testSpell[1]);
			Assert.AreEqual(myBook.SpellCount, 3);

			myBook.RemoveSpell(testSpell[1]);

			Assert.AreNotEqual(myBook[1], testSpell[1]);
			Assert.AreEqual(myBook.SpellCount, 2);
		}
	}
}
