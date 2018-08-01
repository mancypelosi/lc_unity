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
        if (tierList.Count == 0)
            tierList = list;
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
            critDamage = 0,
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
            critDamage = 0,
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
            itemFind = 1,
            magicFind = 1,
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
            itemFind = 1,
            magicFind = 1,
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
            itemFind = 1,
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
            critChance = 3,
            critDamage = 0,
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
            critChance = 2,
            critDamage = 5
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
            critChance = 2,
            critDamage = 5
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 3,
            critDamage = 10
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2105,
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
            itemFind = 2,
            magicFind = 2,
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
            itemFind = 2,
            magicFind = 2,
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
            itemFind = 2,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        /***************/
        /*** TIER 3 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 3101,
            type = ModifierType.Prefix,
            name = "Warrior",
            buyValue = 60,
            sellValue = 30,
            strength = 7,
            dexterity = 0,
            intelligence = 0,
            critChance = 4,
            critDamage = 0,
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
            modId = 3102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 3,
            critDamage = 20
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 0,
            intelligence = 5,
            critChance = 5,
            critDamage = 8
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 3,
            critDamage = 20
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 3,
            magicFind = 3,
            bonusGold = 12,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3106,
            type = ModifierType.Prefix,
            name = "Lucky",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 5,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 3,
            magicFind = 3,
            bonusGold = 0,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3107,
            type = ModifierType.Prefix,
            name = "Berserker",
            buyValue = 60,
            sellValue = 30,
            strength = 7,
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
            armorPen = 7
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 0,
            critDamage = 30,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 7
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 60,
            sellValue = 30,
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
            bonusExp = 0,
            magicPen = 12,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3110,
            type = ModifierType.Prefix,
            name = ":Thinking",
            buyValue = 60,
            sellValue = 30,
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
            bonusExp = 12,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3111,
            type = ModifierType.Prefix,
            name = "Savant",
            buyValue = 60,
            sellValue = 30,
            strength = 3,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 22,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3112,
            type = ModifierType.Prefix,
            name = "Chad",
            buyValue = 60,
            sellValue = 30,
            strength = 7,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 12,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3113,
            type = ModifierType.Prefix,
            name = "Sneaky",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 5,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 3,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);
        
        /***************/
        /*** TIER 4 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 4101,
            type = ModifierType.Prefix,
            name = "Warrior",
            buyValue = 120,
            sellValue = 60,
            strength = 12,
            dexterity = 0,
            intelligence = 0,
            critChance = 5,
            critDamage = 0,
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
            modId = 4102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 5,
            intelligence = 0,
            critChance = 8,
            critDamage = 25
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 10,
            critChance = 5,
            critDamage = 15
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 5,
            critDamage = 30
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 4,
            magicFind = 4,
            bonusGold = 16,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4106,
            type = ModifierType.Prefix,
            name = "Lucky",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 8,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 4,
            magicFind = 4,
            bonusGold = 0,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4107,
            type = ModifierType.Prefix,
            name = "Berserker",
            buyValue = 120,
            sellValue = 60,
            strength = 10,
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
            armorPen = 10
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 5,
            intelligence = 0,
            critChance = 0,
            critDamage = 45,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 10
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 8,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 17,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4110,
            type = ModifierType.Prefix,
            name = ":Thinking",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 8,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 16,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4111,
            type = ModifierType.Prefix,
            name = "Savant",
            buyValue = 120,
            sellValue = 60,
            strength = 4,
            dexterity = 4,
            intelligence = 4,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 30,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4112,
            type = ModifierType.Prefix,
            name = "Chad",
            buyValue = 120,
            sellValue = 60,
            strength = 10,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 16,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4113,
            type = ModifierType.Prefix,
            name = "Sneaky",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 8,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 4,
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
            critChance = 2,
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
            itemFind = 1,
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
            name = "of the Lich",
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
            name = "of the Spellsword",
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
            buyValue = 40,
            sellValue = 20,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 7,
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
            itemFind = 2,
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
            name = "of the Lich",
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
            name = "of the Spellsword",
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
        /************/
        /***TIER 3***/
        /************/
        modifier = new Modifier
        {
            modId = 3201,
            type = ModifierType.Suffix,
            name = "of the Bear",
            buyValue = 60,
            sellValue = 30,
            strength = 12,
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
            modId = 3202,
            type = ModifierType.Suffix,
            name = "of the Snake",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 12,
            intelligence = 0,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 0,
            intelligence = 12,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3204,
            type = ModifierType.Suffix,
            name = "of Crittingham",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 10,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 7,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 3,
            magicFind = 0,
            bonusGold = 12,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3206,
            type = ModifierType.Suffix,
            name = "of the Mercenary",
            buyValue = 60,
            sellValue = 30,
            strength = 7,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 22,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3207,
            type = ModifierType.Suffix,
            name = "of the Nerd",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 0,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 22,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3208,
            type = ModifierType.Suffix,
            name = "of the Dabbler",
            buyValue = 60,
            sellValue = 30,
            strength = 3,
            dexterity = 3,
            intelligence = 3,
            critChance = 3,
            critDamage = 3,
            bonusPhysical = 3,
            bonusMagical = 3,
            itemFind = 3,
            magicFind = 3,
            bonusGold = 3,
            bonusExp = 3,
            magicPen = 3,
            armorPen = 3,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3209,
            type = ModifierType.Suffix,
            name = "of the Boar",
            buyValue = 60,
            sellValue = 30,
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
            armorPen = 8
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 5,
            intelligence = 0,
            critChance = 5,
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
            modId = 3211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 60,
            sellValue = 30,
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
            magicPen = 12,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 0,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 5,
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
            modId = 3213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 60,
            sellValue = 30,
            strength = 5,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 5,
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
            modId = 3214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 60,
            sellValue = 30,
            strength = 0,
            dexterity = 5,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 5,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 5,
            armorPen = 0
        };
        modifierList.Add(modifier);


        /************/
        /***TIER 4***/
        /************/
        modifier = new Modifier
        {
            modId = 4201,
            type = ModifierType.Suffix,
            name = "of the Bear",
            buyValue = 120,
            sellValue = 60,
            strength = 18,
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
            modId = 4202,
            type = ModifierType.Suffix,
            name = "of the Snake",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 18,
            intelligence = 0,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 18,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4204,
            type = ModifierType.Suffix,
            name = "of Crittingham",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 15,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 10,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 4,
            magicFind = 0,
            bonusGold = 16,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4206,
            type = ModifierType.Suffix,
            name = "of the Mercenary",
            buyValue = 120,
            sellValue = 60,
            strength = 10,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 30,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4207,
            type = ModifierType.Suffix,
            name = "of the Nerd",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 10,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 30,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4208,
            type = ModifierType.Suffix,
            name = "of the Dabbler",
            buyValue = 120,
            sellValue = 60,
            strength = 4,
            dexterity = 4,
            intelligence = 4,
            critChance = 4,
            critDamage = 4,
            bonusPhysical = 4,
            bonusMagical = 4,
            itemFind = 4,
            magicFind = 4,
            bonusGold = 4,
            bonusExp = 4,
            magicPen = 4,
            armorPen = 4,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4209,
            type = ModifierType.Suffix,
            name = "of the Boar",
            buyValue = 120,
            sellValue = 60,
            strength = 12,
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
            armorPen = 12
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 7,
            intelligence = 0,
            critChance = 7,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 7
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 120,
            sellValue = 60,
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
            magicPen = 17,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 0,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 7,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 7
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 120,
            sellValue = 60,
            strength = 7,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 7,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 7,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 120,
            sellValue = 60,
            strength = 0,
            dexterity = 7,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 7,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 7,
            armorPen = 0
        };
        modifierList.Add(modifier);

        return modifierList;
    }
}

