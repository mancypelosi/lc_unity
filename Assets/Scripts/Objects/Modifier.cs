using System;
using System.Collections.Generic;

[Serializable]
public class Modifier : Stats
{

    // Enumerators
    public enum ModifierType
    {
        Prefix,
        Suffix
    }

    // Properties
    public int modId = 0;
    public string name = "Modifier";
    public ModifierType type = ModifierType.Prefix;
    public int buyValue = 0;
    public int sellValue = 0;

    // Get Modifier by mod id from list
    public Modifier GetModifierById(List<Modifier> list, int id)
    {
        Modifier m = new Modifier();
        if ((list.Find(modifier => modifier.modId == id) != null))
            m = list.Find(modifier => modifier.modId == id);
        return m;
    }

    // Get a list of all modifiers in the tier
    public List<Modifier> GetListByTier(List<Modifier> list, int tier)
    {
        List<Modifier> tierList = new List<Modifier>();
        foreach (Modifier m in list)
        {
            // Check if the first digit of the id matches the tier
            if ((Int32.Parse(m.modId.ToString("0000").Substring(0, 1))) == tier)
                tierList.Add(m);
        }
        return tierList;
    }

    // List of all prefix mods
    public List<Modifier> PrefixList()
    {
        List<Modifier> modifierList = new List<Modifier>();

        Modifier modifier;

        /***************/
        /*** TIER 0 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 0101,
            type = ModifierType.Prefix,
            name = "Warrior",
            buyValue = 10,
            sellValue = 5,
            strength = 1,
            dexterity = 0,
            intelligence = 0,
            critChance = 1,
            critDamage = 1,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 0102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 10,
            sellValue = 5,
            strength = 0,
            dexterity = 1,
            intelligence = 0,
            critChance = 1,
            critDamage = 1
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 0103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 10,
            sellValue = 5,
            strength = 0,
            dexterity = 0,
            intelligence = 1,
            critChance = 1,
            critDamage = 1
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 0104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 10,
            sellValue = 5,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 2,
            critDamage = 3
        };
        modifierList.Add(modifier);

        /***************/
        /*** TIER 1 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 1101,
            type = ModifierType.Prefix,
            name = "Warrior",
            buyValue = 20,
            sellValue = 10,
            strength = 3,
            dexterity = 0,
            intelligence = 0,
            critChance = 1,
            critDamage = 3,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 0,
            magicPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 1,
            intelligence = 0,
            critChance = 3,
            critDamage = 3
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 2,
            critChance = 2,
            critDamage = 3
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 3,
            critDamage = 10
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 5,
            magicFind = 5,
            bonusGold = 5,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1106,
            type = ModifierType.Prefix,
            name = "Lucky",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 2,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 5,
            magicFind = 5,
            bonusGold = 0,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1107,
            type = ModifierType.Prefix,
            name = "Berserker",
            buyValue = 20,
            sellValue = 10,
            strength = 3,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 3
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 1,
            intelligence = 0,
            critChance = 0,
            critDamage = 10,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 3
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 5,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1110,
            type = ModifierType.Prefix,
            name = ":Thinking",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 5,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1111,
            type = ModifierType.Prefix,
            name = "Savant",
            buyValue = 20,
            sellValue = 10,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 10,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1112,
            type = ModifierType.Prefix,
            name = "Chad",
            buyValue = 20,
            sellValue = 10,
            strength = 3,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 5,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1113,
            type = ModifierType.Prefix,
            name = "Sneaky",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 5,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        /***************/
        /*** TIER 2 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 2101,
            type = ModifierType.Prefix,
            name = "Warrior",
            buyValue = 40,
            sellValue = 20,
            strength = 5,
            dexterity = 0,
            intelligence = 0,
            critChance = 2,
            critDamage = 5,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 0,
            magicPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 2,
            intelligence = 0,
            critChance = 5,
            critDamage = 10
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 3,
            critChance = 3,
            critDamage = 5
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 3,
            critDamage = 10
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 8,
            magicFind = 8,
            bonusGold = 8,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2106,
            type = ModifierType.Prefix,
            name = "Lucky",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 3,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 8,
            magicFind = 8,
            bonusGold = 0,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2107,
            type = ModifierType.Prefix,
            name = "Berserker",
            buyValue = 40,
            sellValue = 20,
            strength = 5,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 5
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 2,
            intelligence = 0,
            critChance = 0,
            critDamage = 20,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 5
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 8,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2110,
            type = ModifierType.Prefix,
            name = ":Thinking",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 8,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2111,
            type = ModifierType.Prefix,
            name = "Savant",
            buyValue = 40,
            sellValue = 20,
            strength = 2,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 15,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2112,
            type = ModifierType.Prefix,
            name = "Chad",
            buyValue = 40,
            sellValue = 20,
            strength = 5,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 8,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2113,
            type = ModifierType.Prefix,
            name = "Sneaky",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 8,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        return modifierList;
    }

    // List of all prefix mods
    public List<Modifier> SuffixList()
    {
        List<Modifier> modifierList = new List<Modifier>();

        Modifier modifier;

        /***************/
        /*** TIER 0 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 0201,
            type = ModifierType.Suffix,
            name = "of the Bear",
            buyValue = 10,
            sellValue = 5,
            strength = 3,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 0202,
            type = ModifierType.Suffix,
            name = "of the Snake",
            buyValue = 10,
            sellValue = 5,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 0203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 10,
            sellValue = 5,
            strength = 0,
            dexterity = 0,
            intelligence = 3,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 0204,
            type = ModifierType.Suffix,
            name = "of Crittingham",
            buyValue = 10,
            sellValue = 5,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 3,
            critDamage = 0
        };
        modifierList.Add(modifier);

        /***************/
        /*** TIER 1 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 1201,
            type = ModifierType.Suffix,
            name = "of the Bear",
            buyValue = 20,
            sellValue = 10,
            strength = 5,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1202,
            type = ModifierType.Suffix,
            name = "of the Snake",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 5,
            intelligence = 0,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 5,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1204,
            type = ModifierType.Suffix,
            name = "of Crittingham",
            buyValue = 20,
            sellValue = 0,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 5,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 5,
            magicFind = 0,
            bonusGold = 5,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1206,
            type = ModifierType.Suffix,
            name = "of the Mercenary",
            buyValue = 20,
            sellValue = 10,
            strength = 3,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 10,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1207,
            type = ModifierType.Suffix,
            name = "of the Nerd",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 10,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1208,
            type = ModifierType.Suffix,
            name = "of the Dabbler",
            buyValue = 20,
            sellValue = 10,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 1,
            critDamage = 1,
            bonusPhysical = 1,
            bonusMagical = 1,
            itemFind = 1,
            magicFind = 1,
            bonusGold = 1,
            bonusExp = 1,
            magicPen = 1,
            armorPen = 1
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1209,
            type = ModifierType.Suffix,
            name = "of the Boar",
            buyValue = 20,
            sellValue = 10,
            strength = 3,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 3
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 2,
            intelligence = 0,
            critChance = 2,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 2
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 5,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1212,
            type = ModifierType.Suffix,
            name = "of the Necromancer",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 0,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 2
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1213,
            type = ModifierType.Suffix,
            name = "of the Crusader",
            buyValue = 20,
            sellValue = 10,
            strength = 2,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 2,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 2,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 20,
            sellValue = 10,
            strength = 0,
            dexterity = 2,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 2,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 2,
            armorPen = 0
        };
        modifierList.Add(modifier);


        /***************/
        /*** TIER 2 ***/
        /*************/
        // Create suffix modifier
        modifier = new Modifier
        {
            modId = 2201,
            type = ModifierType.Suffix,
            name = "of the Bear",
            buyValue = 40,
            sellValue = 20,
            strength = 8,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2202,
            type = ModifierType.Suffix,
            name = "of the Snake",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 8,
            intelligence = 0,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 8,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2204,
            type = ModifierType.Suffix,
            name = "of Crittingham",
            buyValue = 20,
            sellValue = 0,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 8,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 5,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 8,
            magicFind = 0,
            bonusGold = 8,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2206,
            type = ModifierType.Suffix,
            name = "of the Mercenary",
            buyValue = 40,
            sellValue = 20,
            strength = 5,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 15,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2207,
            type = ModifierType.Suffix,
            name = "of the Nerd",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 15,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2208,
            type = ModifierType.Suffix,
            name = "of the Dabbler",
            buyValue = 40,
            sellValue = 20,
            strength = 2,
            dexterity = 2,
            intelligence = 2,
            critChance = 2,
            critDamage = 2,
            bonusPhysical = 2,
            bonusMagical = 2,
            itemFind = 2,
            magicFind = 2,
            bonusGold = 2,
            bonusExp = 2,
            magicPen = 2,
            armorPen = 2
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2209,
            type = ModifierType.Suffix,
            name = "of the Boar",
            buyValue = 40,
            sellValue = 20,
            strength = 5,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 5
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 3,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 3
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 8,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2212,
            type = ModifierType.Suffix,
            name = "of the Necromancer",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 3
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2213,
            type = ModifierType.Suffix,
            name = "of the Crusader",
            buyValue = 40,
            sellValue = 20,
            strength = 3,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 3,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 3,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 3,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 3,
            armorPen = 0
        };
        modifierList.Add(modifier);

        return modifierList;
    }
}

