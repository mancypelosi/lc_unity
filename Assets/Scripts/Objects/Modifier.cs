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
    public int tier = 0;
    public int ilvl = 0;
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 1,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 3,
            critChance = 1,
            bonusMagical = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 1,
            critDamage = 5
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 1,
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
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,
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
            modId = 1108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 3,
            intelligence = 0,
            critChance = 0,
            critDamage = 5,
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
            modId = 1109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 1,
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
            buyValue = 2,
            sellValue = 2,
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
            bonusExp = 5,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1111,
            type = ModifierType.Prefix,
            name = "Savant",
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 2,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 2,
            critDamage = 0,
            bonusMagical = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 2,
            critDamage = 10
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 8
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 8,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 8
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 1,
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
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
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
            modId = 3102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 3,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 3,
            critDamage = 0,
            bonusMagical = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 3,
            critDamage = 15
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 3,
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
            buyValue = 2,
            sellValue = 2,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 12
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 0,
            critDamage = 10,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 12
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
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
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
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
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 5,
            intelligence = 5,
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
            modId = 4102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 12,
            intelligence = 5,
            critChance = 4,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 5,
            intelligence = 12,
            critChance = 4,
            critDamage = 0,
            bonusMagical = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 4,
            critDamage = 20,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 4,
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
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 5,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 18
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 12,
            intelligence = 5,
            critChance = 0,
            critDamage = 12,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 18
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 5,
            intelligence = 12,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 2,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 18,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4110,
            type = ModifierType.Prefix,
            name = ":Thinking",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 5,
            intelligence = 12,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 5,
            intelligence = 5,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 12,
            intelligence = 5,
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
        
        /***************/
        /*** TIER 5 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 5101,
            type = ModifierType.Prefix,
            name = "Warrior",
            buyValue = 2,
            sellValue = 2,
            strength = 18,
            dexterity = 8,
            intelligence = 8,
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
            modId = 5102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 18,
            intelligence = 8,
            critChance = 5,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 8,
            intelligence = 18,
            critChance = 5,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 5,
            critDamage = 25,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 6,
            magicFind = 6,
            bonusGold = 25,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5106,
            type = ModifierType.Prefix,
            name = "Lucky",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 5,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 6,
            magicFind = 6,
            bonusGold = 0,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5107,
            type = ModifierType.Prefix,
            name = "Berserker",
            buyValue = 2,
            sellValue = 2,
            strength = 18,
            dexterity = 8,
            intelligence = 8,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 27,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 18,
            intelligence = 8,
            critChance = 0,
            critDamage = 15,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 27,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 8,
            intelligence = 18,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 3,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 27,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5110,
            type = ModifierType.Prefix,
            name = ":Thinking",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 8,
            intelligence = 18,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 24,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5111,
            type = ModifierType.Prefix,
            name = "Savant",
            buyValue = 2,
            sellValue = 2,
            strength = 6,
            dexterity = 6,
            intelligence = 6,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 40,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5112,
            type = ModifierType.Prefix,
            name = "Chad",
            buyValue = 2,
            sellValue = 2,
            strength = 18,
            dexterity = 8,
            intelligence = 8,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 24,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5113,
            type = ModifierType.Prefix,
            name = "Sneaky",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 18,
            intelligence = 8,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 6,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);
        
        /***************/
        /*** TIER 6 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 6101,
            type = ModifierType.Prefix,
            name = "Warrior",
            buyValue = 2,
            sellValue = 2,
            strength = 27,
            dexterity = 11,
            intelligence = 11,
            critChance = 6,
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
            modId = 6102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 2,
            sellValue = 2,
            strength = 11,
            dexterity = 27,
            intelligence = 11,
            critChance = 6,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 2,
            sellValue = 2,
            strength = 11,
            dexterity = 11,
            intelligence = 27,
            critChance = 6,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 6,
            critDamage = 30,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 8,
            magicFind = 8,
            bonusGold = 40,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6106,
            type = ModifierType.Prefix,
            name = "Lucky",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 6,
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
            modId = 6107,
            type = ModifierType.Prefix,
            name = "Berserker",
            buyValue = 2,
            sellValue = 2,
            strength = 27,
            dexterity = 11,
            intelligence = 11,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 40,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 2,
            sellValue = 2,
            strength = 11,
            dexterity = 27,
            intelligence = 11,
            critChance = 0,
            critDamage = 18,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 40,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 2,
            sellValue = 2,
            strength = 11,
            dexterity = 11,
            intelligence = 27,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 3,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 40,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6110,
            type = ModifierType.Prefix,
            name = ":Thinking",
            buyValue = 2,
            sellValue = 2,
            strength = 11,
            dexterity = 11,
            intelligence = 27,
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
            modId = 6111,
            type = ModifierType.Prefix,
            name = "Savant",
            buyValue = 2,
            sellValue = 2,
            strength = 9,
            dexterity = 9,
            intelligence = 9,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 50,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6112,
            type = ModifierType.Prefix,
            name = "Chad",
            buyValue = 2,
            sellValue = 2,
            strength = 27,
            dexterity = 11,
            intelligence = 11,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 32,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6113,
            type = ModifierType.Prefix,
            name = "Sneaky",
            buyValue = 2,
            sellValue = 2,
            strength = 11,
            dexterity = 27,
            intelligence = 11,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 9,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);
        
        /***************/
        /*** TIER 7 ***/
        /*************/
        modifier = new Modifier
        {
            modId = 7101,
            type = ModifierType.Prefix,
            name = "Warrior",
            buyValue = 2,
            sellValue = 2,
            strength = 40,
            dexterity = 17,
            intelligence = 17,
            critChance = 7,
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
            modId = 7102,
            type = ModifierType.Prefix,
            name = "Rogue",
            buyValue = 2,
            sellValue = 2,
            strength = 17,
            dexterity = 40,
            intelligence = 17,
            critChance = 7,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7103,
            type = ModifierType.Prefix,
            name = "Mage",
            buyValue = 2,
            sellValue = 2,
            strength = 17,
            dexterity = 17,
            intelligence = 40,
            critChance = 7,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7104,
            type = ModifierType.Prefix,
            name = "Critical",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 7,
            critDamage = 35,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7105,
            type = ModifierType.Prefix,
            name = "Greedy",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 8,
            magicFind = 8,
            bonusGold = 40,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7106,
            type = ModifierType.Prefix,
            name = "Lucky",
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 7,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 10,
            magicFind = 10,
            bonusGold = 0,
            bonusExp = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7107,
            type = ModifierType.Prefix,
            name = "Berserker",
            buyValue = 2,
            sellValue = 2,
            strength = 40,
            dexterity = 17,
            intelligence = 17,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 4,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 60,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7108,
            type = ModifierType.Prefix,
            name = "Assassin",
            buyValue = 2,
            sellValue = 2,
            strength = 17,
            dexterity = 40,
            intelligence = 17,
            critChance = 0,
            critDamage = 20,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            armorPen = 60,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7109,
            type = ModifierType.Prefix,
            name = "Warlock",
            buyValue = 2,
            sellValue = 2,
            strength = 17,
            dexterity = 17,
            intelligence = 40,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 4,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 60,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7110,
            type = ModifierType.Prefix,
            name = ":Thinking",
            buyValue = 2,
            sellValue = 2,
            strength = 17,
            dexterity = 17,
            intelligence = 40,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 35,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7111,
            type = ModifierType.Prefix,
            name = "Savant",
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 12,
            intelligence = 12,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 60,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7112,
            type = ModifierType.Prefix,
            name = "Chad",
            buyValue = 2,
            sellValue = 2,
            strength = 40,
            dexterity = 17,
            intelligence = 17,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 40,
            bonusExp = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7113,
            type = ModifierType.Prefix,
            name = "Sneaky",
            buyValue = 2,
            sellValue = 2,
            strength = 17,
            dexterity = 40,
            intelligence = 17,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 11,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 0,
            dexterity = 0,
            intelligence = 0,
            critChance = 1,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 1,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 2,
            sellValue = 2,
            strength = 1,
            dexterity = 3,
            intelligence = 1,
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
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
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
            buyValue = 2,
            sellValue = 2,
            strength = 1,
            dexterity = 1,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 5,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 5,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 2,
            sellValue = 2,
            strength = 1,
            dexterity = 3,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 5,
            armorPen = 5,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 2,
            sellValue = 2,
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
            armorPen = 8,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 2,
            sellValue = 2,
            strength = 1,
            dexterity = 1,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 5,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 1213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 1,
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
            modId = 1214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 2,
            sellValue = 2,
            strength = 1,
            dexterity = 3,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 1,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 5,
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
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 3,
            intelligence = 3,
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
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 8,
            intelligence = 3,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 3,
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
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 2,
            intelligence = 2,
            critChance = 2,
            critDamage = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 2,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 8,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 8,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 8,
            armorPen = 8,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 2,
            sellValue = 2,
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
            armorPen = 12,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,
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
            modId = 2213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 1,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 8,
            armorPen = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 2214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 2,
            sellValue = 2,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 1,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 8,
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
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 5,
            intelligence = 5,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 12,
            intelligence = 5,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 5,
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
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 5,
            intelligence = 5,
            critChance = 3,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
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
            buyValue = 2,
            sellValue = 2,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
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
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 3,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 10,
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
            modId = 3210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 12,
            armorPen = 12,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 2,
            sellValue = 2,
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
            magicPen = 18,
            armorPen = 18,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 12,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 2,
            sellValue = 2,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 2,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 12,
            armorPen = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 3214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 2,
            sellValue = 2,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 2,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 12,
            armorPen = 0,
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
            buyValue = 2,
            sellValue = 2,
            strength = 18,
            dexterity = 8,
            intelligence = 8,
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
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 18,
            intelligence = 8,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 8,
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
            strength = 7,
            dexterity = 7,
            intelligence = 7,
            critChance = 4,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 2,
            sellValue = 2,
            strength = 4,
            dexterity = 10,
            intelligence = 4,
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
            buyValue = 2,
            sellValue = 2,
            strength = 10,
            dexterity = 4,
            intelligence = 4,
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
            buyValue = 2,
            sellValue = 2,
            strength = 4,
            dexterity = 4,
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
            buyValue = 2,
            sellValue = 2,
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
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 5,
            intelligence = 5,
            critChance = 0,
            critDamage = 12,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 15
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 12,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 18,
            armorPen = 18,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 2,
            sellValue = 2,
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
            magicPen = 27,
            armorPen = 27,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 5,
            intelligence = 12,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 18,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 5,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 2,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 18,
            armorPen = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 4214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 12,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 2,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 18,
            armorPen = 0
        };
        modifierList.Add(modifier);
        
        
        /************/
        /***TIER 5***/
        /************/
        modifier = new Modifier
        {
            modId = 5201,
            type = ModifierType.Suffix,
            name = "of the Bear",
            buyValue = 2,
            sellValue = 2,
            strength = 27,
            dexterity = 12,
            intelligence = 12,
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
            modId = 5202,
            type = ModifierType.Suffix,
            name = "of the Snake",
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 27,
            intelligence = 12,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 2,
            sellValue = 2,
            strength = 12,
            dexterity = 12,
            intelligence = 27,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5204,
            type = ModifierType.Suffix,
            name = "of Crittingham",
            buyValue = 2,
            sellValue = 2,
            strength = 10,
            dexterity = 10,
            intelligence = 10,
            critChance = 5,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 2,
            sellValue = 2,
            strength = 6,
            dexterity = 15,
            intelligence = 6,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 6,
            magicFind = 0,
            bonusGold = 24,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5206,
            type = ModifierType.Suffix,
            name = "of the Mercenary",
            buyValue = 2,
            sellValue = 2,
            strength = 15,
            dexterity = 6,
            intelligence = 6,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 45,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5207,
            type = ModifierType.Suffix,
            name = "of the Nerd",
            buyValue = 2,
            sellValue = 2,
            strength = 6,
            dexterity = 6,
            intelligence = 15,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 40,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5208,
            type = ModifierType.Suffix,
            name = "of the Dabbler",
            buyValue = 2,
            sellValue = 2,
            strength = 5,
            dexterity = 5,
            intelligence = 5,
            critChance = 5,
            critDamage = 5,
            bonusPhysical = 5,
            bonusMagical = 5,
            itemFind = 5,
            magicFind = 5,
            bonusGold = 5,
            bonusExp = 5,
            magicPen = 5,
            armorPen = 5,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5209,
            type = ModifierType.Suffix,
            name = "of the Boar",
            buyValue = 2,
            sellValue = 2,
            strength = 20,
            dexterity = 8,
            intelligence = 8,
            critChance = 0,
            critDamage = 15,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 27
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 20,
            intelligence = 8,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 27,
            armorPen = 27,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 2,
            sellValue = 2,
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
            magicPen = 40,
            armorPen = 40,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 8,
            intelligence = 20,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 27,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 2,
            sellValue = 2,
            strength = 20,
            dexterity = 8,
            intelligence = 8,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 3,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 27,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 5214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 2,
            sellValue = 2,
            strength = 8,
            dexterity = 20,
            intelligence = 8,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 3,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 27,
            armorPen = 0,
        };
        modifierList.Add(modifier);

        /************/
        /***TIER 6***/
        /************/
        modifier = new Modifier
        {
            modId = 6201,
            type = ModifierType.Suffix,
            name = "of the Bear",
            buyValue = 2,
            sellValue = 2,
            strength = 40,
            dexterity = 16,
            intelligence = 16,
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
            modId = 6202,
            type = ModifierType.Suffix,
            name = "of the Snake",
            buyValue = 2,
            sellValue = 2,
            strength = 16,
            dexterity = 40,
            intelligence = 16,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 2,
            sellValue = 2,
            strength = 16,
            dexterity = 16,
            intelligence = 40,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6204,
            type = ModifierType.Suffix,
            name = "of Crittingham",
            buyValue = 2,
            sellValue = 2,
            strength = 14,
            dexterity = 14,
            intelligence = 14,
            critChance = 6,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 2,
            sellValue = 2,
            strength = 9,
            dexterity = 22,
            intelligence = 9,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 8,
            magicFind = 0,
            bonusGold = 36,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6206,
            type = ModifierType.Suffix,
            name = "of the Mercenary",
            buyValue = 2,
            sellValue = 2,
            strength = 22,
            dexterity = 9,
            intelligence = 9,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 70,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6207,
            type = ModifierType.Suffix,
            name = "of the Nerd",
            buyValue = 2,
            sellValue = 2,
            strength = 9,
            dexterity = 9,
            intelligence = 22,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 50,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6208,
            type = ModifierType.Suffix,
            name = "of the Dabbler",
            buyValue = 2,
            sellValue = 2,
            strength = 6,
            dexterity = 6,
            intelligence = 6,
            critChance = 6,
            critDamage = 6,
            bonusPhysical = 6,
            bonusMagical = 6,
            itemFind = 6,
            magicFind = 6,
            bonusGold = 6,
            bonusExp = 6,
            magicPen = 6,
            armorPen = 6,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6209,
            type = ModifierType.Suffix,
            name = "of the Boar",
            buyValue = 2,
            sellValue = 2,
            strength = 30,
            dexterity = 13,
            intelligence = 13,
            critChance = 0,
            critDamage = 18,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 40
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 2,
            sellValue = 2,
            strength = 13,
            dexterity = 30,
            intelligence = 13,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 40,
            armorPen = 40,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 2,
            sellValue = 2,
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
            magicPen = 60,
            armorPen = 60,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 2,
            sellValue = 2,
            strength = 13,
            dexterity = 13,
            intelligence = 30,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 40,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 2,
            sellValue = 2,
            strength = 30,
            dexterity = 13,
            intelligence = 13,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 3,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 40,
            armorPen = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 6214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 2,
            sellValue = 2,
            strength = 13,
            dexterity = 30,
            intelligence = 13,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 3,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 40,
            armorPen = 0
        };
        modifierList.Add(modifier);
        
        /************/
        /***TIER 7***/
        /************/
        modifier = new Modifier
        {
            modId = 7201,
            type = ModifierType.Suffix,
            name = "of the Bear",
            buyValue = 2,
            sellValue = 2,
            strength = 60,
            dexterity = 24,
            intelligence = 24,
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
            modId = 7202,
            type = ModifierType.Suffix,
            name = "of the Snake",
            buyValue = 2,
            sellValue = 2,
            strength = 24,
            dexterity = 60,
            intelligence = 24,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7203,
            type = ModifierType.Suffix,
            name = "of the Owl",
            buyValue = 2,
            sellValue = 2,
            strength = 24,
            dexterity = 24,
            intelligence = 60,
            critChance = 0,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7204,
            type = ModifierType.Suffix,
            name = "of Crittingham",
            buyValue = 2,
            sellValue = 2,
            strength = 19,
            dexterity = 19,
            intelligence = 19,
            critChance = 7,
            critDamage = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7205,
            type = ModifierType.Suffix,
            name = "of the Thief",
            buyValue = 2,
            sellValue = 2,
            strength = 13,
            dexterity = 33,
            intelligence = 13,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 10,
            magicFind = 0,
            bonusGold = 42,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7206,
            type = ModifierType.Suffix,
            name = "of the Mercenary",
            buyValue = 2,
            sellValue = 2,
            strength = 33,
            dexterity = 13,
            intelligence = 13,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 80,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7207,
            type = ModifierType.Suffix,
            name = "of the Nerd",
            buyValue = 2,
            sellValue = 2,
            strength = 13,
            dexterity = 13,
            intelligence = 33,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 57,
            magicPen = 0,
            armorPen = 0
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7208,
            type = ModifierType.Suffix,
            name = "of the Dabbler",
            buyValue = 2,
            sellValue = 2,
            strength = 7,
            dexterity = 7,
            intelligence = 7,
            critChance = 7,
            critDamage = 7,
            bonusPhysical = 7,
            bonusMagical = 7,
            itemFind = 7,
            magicFind = 7,
            bonusGold = 7,
            bonusExp = 7,
            magicPen = 7,
            armorPen = 7,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7209,
            type = ModifierType.Suffix,
            name = "of the Boar",
            buyValue = 2,
            sellValue = 2,
            strength = 45,
            dexterity = 20,
            intelligence = 20,
            critChance = 0,
            critDamage = 20,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 60
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7210,
            type = ModifierType.Suffix,
            name = "of the Duelist",
            buyValue = 2,
            sellValue = 2,
            strength = 20,
            dexterity = 45,
            intelligence = 20,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 60,
            armorPen = 60,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7211,
            type = ModifierType.Suffix,
            name = "of the Negator",
            buyValue = 2,
            sellValue = 2,
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
            magicPen = 90,
            armorPen = 90,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7212,
            type = ModifierType.Suffix,
            name = "of the Lich",
            buyValue = 2,
            sellValue = 2,
            strength = 20,
            dexterity = 20,
            intelligence = 45,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 4,
            bonusMagical = 0,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 0,
            armorPen = 60,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7213,
            type = ModifierType.Suffix,
            name = "of the Spellsword",
            buyValue = 2,
            sellValue = 2,
            strength = 45,
            dexterity = 20,
            intelligence = 20,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 4,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 60,
            armorPen = 0,
        };
        modifierList.Add(modifier);

        modifier = new Modifier
        {
            modId = 7214,
            type = ModifierType.Suffix,
            name = "of the Illusionist",
            buyValue = 2,
            sellValue = 2,
            strength = 20,
            dexterity = 45,
            intelligence = 20,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            bonusMagical = 4,
            itemFind = 0,
            magicFind = 0,
            bonusGold = 0,
            bonusExp = 0,
            magicPen = 60,
            armorPen = 0
        };
        modifierList.Add(modifier);

        return modifierList;
    }
}

