using NUnit.Framework;
using System;

namespace Spells
{
	[TestFixture()]
	public class SpellTest
	{
		[Test()]
		public void TestHeal()
		{
			Heal spell = new Heal("Alex");

			string s = spell.Cast();

			if (spell.Success)
			{
				Assert.AreEqual(s, "You Have Been Healed");

				do
				{
					s = spell.Cast();
					if (!spell.Success)
					{
						Assert.AreEqual(s, "OUCH");
					}
				} while (spell.Success);
			}
			else
			{
				Assert.AreEqual(s, "OUCH");
				do
				{
					s = spell.Cast();
					if (spell.Success)
					{
						Assert.AreEqual(s, "You Have Been Healed");
					}
				} while (!spell.Success);
			}
		}

		[Test()]
		public void TestTeleport()
		{
			Teleport spell = new Teleport("Mitch");

			string s = spell.Cast();

			if (spell.Success)
			{
				Assert.AreEqual(s, "Location Moved");

				do
				{
					s = spell.Cast();
					if (!spell.Success)
					{
						Assert.AreEqual(s, "*BANG*");
					}
				} while (spell.Success);
			}
			else
			{
				Assert.AreEqual(s, "*BANG*");
				do
				{
					s = spell.Cast();
					if (spell.Success)
					{
						Assert.AreEqual(s, "Location Moved");
					}
				} while (!spell.Success);
			}
		}

		[Test()]
		public void TestTransmogrification()
		{
			Transmogrification spell = new Transmogrification("Mitch");

			string s = spell.Cast();

			if (spell.Success)
			{
				Assert.AreEqual(s, "*THUMP*");

				do
				{
					s = spell.Cast();
					if (!spell.Success)
					{
						Assert.AreEqual(s, "Squeak Squeak");
					}
				} while (spell.Success);
			}
			else
			{
				Assert.AreEqual(s, "Squeak Squeak");
				do
				{
					s = spell.Cast();
					if (spell.Success)
					{
						Assert.AreEqual(s, "*THUMP*");
					}
				} while (!spell.Success);
			}
		}
	}
}