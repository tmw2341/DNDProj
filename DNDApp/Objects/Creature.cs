using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDApp.Objects
{
    class Creature
    {
        String Name;
        Size size;
        String alignment;

        int hp;
        Dice hitDice;
        int BAB;
        int CMB;
        int CMD;

        int init;

        int AC;
        int touch;
        int flat;
        int speed;
        int climb;
        int burrow;
        int fly;
        int swim;

        Abilities abilities;
        Skills skills;
        Saves saves;
        String[] languages;
        Feat[] feats;
    }
}
