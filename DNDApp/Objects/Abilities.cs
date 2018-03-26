using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDApp.Objects
{
    class Abilities
    {
        Ability abilities;
        Dictionary<Ability, int> abilScores;

        public int GetScore(Ability abil)
        {
            return abilScores[(abil];
        }

        public void SetScore(Ability abil, int score)
        {
            abilScores[abil] = score;
        }

        public int GetModifier(Ability abil)
        {
            return (abilScores[abil] - 10) / 2;
        }
    }
}
