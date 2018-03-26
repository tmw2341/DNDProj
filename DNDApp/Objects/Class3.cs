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
        int[] abilScores;

        public int GetScore(Ability abil)
        {
            return abilScores[(int)abil];
        }

        public void SetScore(Ability abil, int score)
        {
            abilScores[(int)abil] = score;
        }

        public int GetModifier(Ability abil)
        {
            return (abilScores[(int)abil] - 10) / 2;
        }
    }
}
