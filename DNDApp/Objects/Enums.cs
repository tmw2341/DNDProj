using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDApp.Objects
{
    public enum Skill
    {
        Acrobatics, Appraise, Bluff, Climb, Craft, Diplomacy, Disable_Device, Disguise, Escape_Artist, Fly, Handle_Animal, Heal, Intimidate,
        Arcana, Dungeoneering, Engineering, Geography, History, Local, Nature, Nobility, Planes, Religion, Linguistics, Perception,
        Perform, Profession, Ride, Sense_Motive, Sleight_of_Hand, Spellcraft, Stealth, Survival, Swim, Use_Magic_Device
    };

    public enum Ability
    {
        Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma
    };

    public enum Save
    {
        Fortitude, Reflex, Will
    };

    public enum Size
    {
        Fine, Diminuitive, Tiny, Small, Medium, Large_Tall, Large_Long, Huge_Tall, Huge_Long, Gargantuan_Tall, Gargantuan_Long,
        Colossal_Tall, Colossal_Long
    }

    public enum Type
    {
        Aberration, Animal, Construct, Dragon, Fey, Humanoid, Magical_Beast, Monstrous_Humanoid, Ooze, Outsider, Plant, Undead, Vermin
    };

    public enum Subtype
    {
        Adlet, Aeon, Agathion, Air, Angel, Aquatic, Archon, Asura, Augmented, Azata, Behemoth, Catfolk, Chaotic, Clockwork, Cold, Colossus,
        Daemon, Dark_Folk, Deep_One, Demodand, Demon, Devil, Div, Dwarf, Earth, Elemental, Elf, Evil, Extraplanar, Fire, Giant, Gnome,
        Goblinoid, Godspawn, Good, Great_Old_One, Halfling, Herald, Hive, Human, Incorporeal, Inevitable, Kaiju, Kami, Kasatha, Kitsune,
        Kyton, Lawful, Leshy, Mythic, Native ,Nightshade, Oni, Orc, Protean, Psychopomp, Qlippoth, Rakshasa, Ratfolk, Reptilian, Robot,
        Samsaran, Sasquatch, Shapechanger, Swarm, Troop, Udaeus, Unbreathing, Vanara, Vishkanya, Water
    };

    public enum Item_Type
    {
        Potion, Ring, Rod, Scroll, Stave, Rune, Wand, Wonderous, Armor, Weapon, Misc
    }

    public enum Item_Slot
    {
        Belt, Body, Chest, Eyes, Feet, Hand, Head, Headband, Neck, Shoulder, Wrist, Slotless
    }

    public enum Item_Desc
    {
        AC, Abil, Skill, Spell, 
    }
}
