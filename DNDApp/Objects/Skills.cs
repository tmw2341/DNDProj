using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDApp.Objects
{
    class Skills
    {
        private Dictionary<String, int> skillRanks;
        private HashSet<String> craftSkills;
        private HashSet<String> performSkills;
        private HashSet<String> professionSkills;

        public Skills()
        {
            foreach(String name in Enum.GetNames(typeof(Skill)))
            {
                if (name.Contains("_"))
                {
                    name.Replace("_", " ");
                }
                this.skillRanks.Add(name, 0);
            }
        }

        public Ability getAbil(Skill skill)
        {
            if (skill == Skill.Acrobatics || skill == Skill.Disable_Device || skill == Skill.Escape_Artist ||
               skill == Skill.Fly || skill == Skill.Ride || skill == Skill.Sleight_of_Hand || skill == Skill.Stealth)
            {
                return Ability.Dexterity;
            }
            else if (skill == Skill.Climb || skill == Skill.Swim)
            {
                return Ability.Strength;
            }
            else if (skill == Skill.Appraise || skill == Skill.Craft || skill == Skill.Arcana ||
               skill == Skill.Dungeoneering || skill == Skill.Engineering || skill == Skill.Geography ||
               skill == Skill.History || skill == Skill.Local || skill == Skill.Nature || skill == Skill.Nobility || 
               skill == Skill.Planes || skill == Skill.Religion || skill == Skill.Linguistics || skill == Skill.Spellcraft)
            {
                return Ability.Intelligence;
            }
            else if (skill == Skill.Bluff || skill == Skill.Diplomacy || skill == Skill.Disguise ||
               skill == Skill.Handle_Animal || skill == Skill.Intimidate || skill == Skill.Perform ||
               skill == Skill.Use_Magic_Device)
            {
                return Ability.Charisma;
            }
            else if (skill == Skill.Heal || skill == Skill.Perception || skill == Skill.Profession ||
               skill == Skill.Sense_Motive || skill == Skill.Survival)
            {
                return Ability.Wisdom;
            }
            else
            {
                return Ability.Constitution;
            }
        }

        public bool GetTrainedOnly(Skill skill)
        {
            if (skill == Skill.Disable_Device || skill == Skill.Handle_Animal || skill == Skill.Arcana ||
               skill == Skill.Dungeoneering || skill == Skill.Engineering || skill == Skill.Geography ||
               skill == Skill.History || skill == Skill.Local || skill == Skill.Nature || skill == Skill.Nobility ||
               skill == Skill.Planes || skill == Skill.Religion || skill == Skill.Linguistics || skill == Skill.Profession ||
               skill == Skill.Sleight_of_Hand || skill == Skill.Spellcraft || skill == Skill.Use_Magic_Device)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetCheckPenalty(Skill skill)
        {
            if (skill == Skill.Acrobatics || skill == Skill.Climb || skill == Skill.Disable_Device ||
               skill == Skill.Escape_Artist || skill == Skill.Fly || skill == Skill.Ride ||
               skill == Skill.Sleight_of_Hand || skill == Skill.Stealth || skill == Skill.Swim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetRanks(Skill skill, String key = "")
        {
            String name;
            switch (skill)
            {
                case Skill.Craft:
                    if (this.skillRanks.ContainsKey(key) && this.craftSkills.Contains(key))
                    {
                        return skillRanks[key];
                    }
                    return -1;
                case Skill.Perform:
                    if (this.skillRanks.ContainsKey(key) && this.performSkills.Contains(key))
                    {
                        return skillRanks[key];
                    }
                    return -1;
                case Skill.Profession:
                    if(this.skillRanks.ContainsKey(key) && this.professionSkills.Contains(key))
                    {
                        return skillRanks[key]; 
                    }
                    return -1;
                default:
                    name = skill.ToString();
                    if (name.Contains("_"))
                    {
                        name.Replace("_", " ");
                    }
                    if (this.skillRanks.ContainsKey(name))
                    {
                        return skillRanks[name];
                    }
                    return -1;
            }
        }

        public void SetRanks(Skill skill, int val, String key = "")
        {
            String name;
            switch (skill)
            {
                case Skill.Craft:
                    if (this.skillRanks.ContainsKey(key) && this.craftSkills.Contains(key))
                    {
                        skillRanks[key] = val;
                    }
                    return;
                case Skill.Perform:
                    if (this.skillRanks.ContainsKey(key) && this.performSkills.Contains(key))
                    {
                        skillRanks[key] = val;
                    }
                    return;
                case Skill.Profession:
                    if (this.skillRanks.ContainsKey(key) && this.professionSkills.Contains(key))
                    {
                        skillRanks[key] = val;
                    }
                    return;
                default:
                    name = skill.ToString();
                    if (name.Contains("_"))
                    {
                        name.Replace("_", " ");
                    }
                    if (this.skillRanks.ContainsKey(name))
                    {
                        skillRanks[name] = val;
                    }
                    return;
            }
        }

        public void AddSkill(Skill skill, String name, int val = 0)
        {
            switch (skill)
            {
                case Skill.Craft:
                    if (!skillRanks.ContainsKey(name))
                    {
                        skillRanks.Add(name, val);
                        craftSkills.Add(name);
                    }
                    return;
                case Skill.Perform:
                    if (!skillRanks.ContainsKey(name))
                    {
                        skillRanks.Add(name, val);
                        performSkills.Add(name);
                    }
                    return;
                case Skill.Profession:
                    if (!skillRanks.ContainsKey(name))
                    {
                        skillRanks.Add(name, val);
                        professionSkills.Add(name);
                    }
                    return;
                default:
                    return;
            }
        }
    }
}
