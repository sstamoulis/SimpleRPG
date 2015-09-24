using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace SimpleRPG
{
	public class SkillsList
	{
		const int SLOTS_LIMIT = 4;
		OrderedDictionary Skills = new OrderedDictionary(SLOTS_LIMIT);

		/// <summary>
		/// Adds a skill to the SkillsList.
		/// If there is no empty slot, it will throw an exception.
		/// </summary>
		/// <returns>The index of the skill</returns>
		/// <param name="skill">The skill to add.</param>
		/// <exception cref="System.InvalidOperationException">Thrown when there are no empty slots available.</exception>
		public void Add(Skill skill) {
			if (Skills.Count >= SLOTS_LIMIT) throw new InvalidOperationException("There is no empty skill slot!");
			Skills.Add(skill.Name, skill);
		}

		public void Remove(int index) {
			Skills.RemoveAt(index);
		}
		public void Remove(string skillName) {
			Skills.Remove(skillName);
		}

		public void Insert(int index, Skill skill) {
			Skills.Insert(index, skill.Name, skill);
		}

		public int GetEmptySlots() {
			return SLOTS_LIMIT - Skills.Count;
		}

		public Skill GetSkill(int index) {
			return Skills[index]; 
		}
		public Skill this[int index] => GetSkill(index);

		public Skill GetSkill(string skillName) {
			for (int i = 0; i < Skills.Length; i++) {
				if (Skills[i].Name.Equals(skillName, StringComparison.OrdinalIgnoreCase))
					return Skills[i];
			}
			return null;
		}
		public Skill this[string skillName] => GetSkill(skillName);
	}
}
