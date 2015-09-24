using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace SimpleRPG
{
	public class SkillsList
	{
		int countLimit;
		Dictionary<string,Skill> SkillsByName = new Dictionary<string, Skill>();
		List<Skill> SkillsByIndex = new List<Skill>();

		public void Add(Skill skill) {
			SkillsByName.Add(skill.Name, skill);
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
			return Skills[skillName];
		}
		public Skill this[string skillName] => GetSkill(skillName);
	}
}
