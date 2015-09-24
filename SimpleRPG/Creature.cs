using System;

namespace SimpleRPG
{
	public abstract class Creature
	{
		public Gauge<int> HP { get; protected set; }

		public int Defence { get; set; }
		public int MagicDefence { get; set; }

		public SkillsList Skills { get; protected set; }

		public Creature ()
		{
			this.HP = new Gauge<int> ();
			this.Skills = new SkillsList ();
		}
	}
}

