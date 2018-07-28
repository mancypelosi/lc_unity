using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Armor : Item {

    // Enumerators
    public enum ArmorType
    {
        None,
        Head,
        Chest,
        Gloves,
        Legs,
        Boots,
        Amulet
    }

    public ArmorType armorType = ArmorType.None;

    // Constructor
    public Armor()
    {
        name = "Garbage";
        spritePath = "Icons/garbage";
    }

    //Tooltip override
    override
    public string GetToolTip()
    {
        return "Armor Type: " + armorType + Environment.NewLine +
            "Str: " + strength + " Dex: " + dexterity + " Int: " + intelligence + Environment.NewLine +
            "Armor Pen: " + armorPen + Environment.NewLine +
            "Magic Pen: " + magicPen + Environment.NewLine +
            "Crit Chance: " + critChance + "%" + Environment.NewLine +
            "Crit Damage: " + critDamage + "%" + Environment.NewLine +
            '"' + flavorText + '"' + Environment.NewLine +
            "Value: " + sellValue + Environment.NewLine;
    }

    // Get Armor by item id from list
    public Armor GetArmorById(List<Armor> list, int id)
    {
        Armor a = new Armor();
        if ((list.Find(armor => armor.itemId == id) != null))
            a = list.Find(armor => armor.itemId == id);
        return a;
    }

    // Get a list of all items in the tier
    public List<Armor> GetListByTier(List<Armor> list, int tier)
    {
        List<Armor> tierList = new List<Armor>();
        foreach (Armor a in list)
        {
            // Check if the first digit of the id matches the tier
            if ((Int32.Parse(a.itemId.ToString("0000").Substring(0, 1))) == tier)
                tierList.Add(a);
        }
        return tierList;
    }

    // List of all armor
    public List<Armor> ArmorList()
    {
        List<Armor> armorList = new List<Armor>();

        Armor armor;

        /***************/
        /*** TIER 0 ***/
        /*************/

        // Create base head armor
        armor = new Armor
        {
            itemId = 0001,
            name = "Loose Cap",
            spritePath = "Icons/helm",
            rarity = Rarity.Common,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Head,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        // Create base chest armor
        armor = new Armor
        {
            itemId = 0002,
            name = "Loose Shirt",
            spritePath = "Icons/chest",
            rarity = Rarity.Common,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Chest,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        // Create base glove armor
        armor = new Armor
        {
            itemId = 0003,
            name = "Loose Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Common,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Gloves,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        // Create base legs armor
        armor = new Armor
        {
            itemId = 0004,
            name = "Loose Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Common,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Legs,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        // Create base boots armor
        armor = new Armor
        {
            itemId = 0005,
            name = "Loose Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Common,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Boots,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        /***************/
        /*** TIER 1 ***/
        /*************/
        // Create iron head armor
        armor = new Armor
        {
            itemId = 1101,
            name = "Iron Head",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Head,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,

        };
        armorList.Add(armor);

        // Create iron chest armor
        armor = new Armor
        {
            itemId = 1102,
            name = "Iron Breastplate",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Chest,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,

        };
        armorList.Add(armor);

        // Create iron gloves armor
        armor = new Armor
        {
            itemId = 1103,
            name = "Iron Gauntlets",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Gloves,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,

        };
        armorList.Add(armor);

        // Create iron greaves armor
        armor = new Armor
        {
            itemId = 1104,
            name = "Iron Greaves",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Legs,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,

        };
        armorList.Add(armor);

        // Create iron boots armor
        armor = new Armor
        {
            itemId = 1105,
            name = "Iron Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Boots,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,

        };
        armorList.Add(armor);


        // Create leather head armor
        armor = new Armor
        {
            itemId = 1201,
            name = "Leather Head",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Head,
            strength = 1,
            dexterity = 3,
            intelligence = 1,
            critChance = 0,
            critDamage = 5,

        };
        armorList.Add(armor);

        // Create leather chest armor
        armor = new Armor
        {
            itemId = 1202,
            name = "Leather Chest",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Chest,
            strength = 1,
            dexterity = 3,
            intelligence = 1,
            critChance = 0,
            critDamage = 5,

        };
        armorList.Add(armor);

        // Create leather gloves armor
        armor = new Armor
        {
            itemId = 1203,
            name = "Leather Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Gloves,
            strength = 1,
            dexterity = 3,
            intelligence = 1,
            critChance = 0,
            critDamage = 5,

        };
        armorList.Add(armor);

        // Create leather legs armor
        armor = new Armor
        {
            itemId = 1204,
            name = "Leather Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Legs,
            strength = 1,
            dexterity = 3,
            intelligence = 1,
            critChance = 0,
            critDamage = 5,

        };
        armorList.Add(armor);

        // Create leather boots armor
        armor = new Armor
        {
            itemId = 1205,
            name = "Leather Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Boots,
            strength = 1,
            dexterity = 3,
            intelligence = 1,
            critChance = 0,
            critDamage = 5,

        };
        armorList.Add(armor);

        // Create cloth hood armor
        armor = new Armor
        {
            itemId = 1301,
            name = "Cloth Hood",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Head,
            strength = 1,
            dexterity = 1,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 1,

        };
        armorList.Add(armor);

        // Create cloth robes armor
        armor = new Armor
        {
            itemId = 1302,
            name = "Cloth Robes",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Chest,
            strength = 1,
            dexterity = 1,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 1,

        };
        armorList.Add(armor);

        // Create cloth gloves armor
        armor = new Armor
        {
            itemId = 1303,
            name = "Cloth Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Gloves,
            strength = 1,
            dexterity = 1,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 1,

        };
        armorList.Add(armor);

        // Create cloth Legs armor
        armor = new Armor
        {
            itemId = 1304,
            name = "Cloth Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Legs,
            strength = 1,
            dexterity = 1,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 1,

        };
        armorList.Add(armor);

        // Create cloth hood armor
        armor = new Armor
        {
            itemId = 1305,
            name = "Cloth Shoes",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Boots,
            strength = 1,
            dexterity = 1,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 1,

        };
        armorList.Add(armor);

        /********************/
        /*** LEGENDARIES ***/
        /******************/
       //create new flashlight hat
        armor = new Armor
        {
            itemId = 1111,
            name = "Flashlight Hardhat",
            spritePath = "Icons/helm",
            flavorText = "Safety first, kids",
            rarity = Rarity.Legendary,
            buyValue = 100,
            sellValue = 50,
            requiredLevel = 1,
            armorType = ArmorType.Head,
            strength = 3,
            dexterity = 1,
            intelligence = 1,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 1,
            itemFind = 5,
            magicFind = 5,

        };
        armorList.Add(armor);

        // Create leather gloves armor
        armor = new Armor
        {
            itemId = 1213,
            name = "Duelist Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Legendary,
            buyValue = 100,
            sellValue = 50,
            requiredLevel = 1,
            armorType = ArmorType.Gloves,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 3,
            critDamage = 10,

        };
        armorList.Add(armor);

        // Create leather gloves armor
        armor = new Armor
        {
            itemId = 1212,
            name = "Duelist Cuirass",
            spritePath = "Icons/chest",
            rarity = Rarity.Legendary,
            buyValue = 100,
            sellValue = 50,
            requiredLevel = 1,
            armorType = ArmorType.Chest,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 3,
            critDamage = 10,

        };
        armorList.Add(armor);

        // Create leather gloves armor
        armor = new Armor
        {
            itemId = 1215,
            name = "Duelist Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Legendary,
            buyValue = 100,
            sellValue = 50,
            requiredLevel = 1,
            armorType = ArmorType.Boots,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            critChance = 3,
            critDamage = 10,

        };
        armorList.Add(armor);

         // Create cloth gloves armor
        armor = new Armor
        {
            itemId = 1313,
            name = "Skeletal Gloves",
            flavorText = "Wait, how are the gloves skeletal?",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 100,
            sellValue = 50,
            requiredLevel = 1,
            armorType = ArmorType.Gloves,
            strength = 1,
            dexterity = 1,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 0,
            bonusPhysical = 3,

        };
        armorList.Add(armor);
        /********************/
        /***   TIER 2    ***/
        /******************/
        // Create iron head armor
        armor = new Armor
        {
            itemId = 2101,
            name = "Steel Head",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            armorType = ArmorType.Head,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,

        };
        armorList.Add(armor);

        // Create iron chest armor
        armor = new Armor
        {
            itemId = 2102,
            name = "Steel Breastplate",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            armorType = ArmorType.Chest,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,

        };
        armorList.Add(armor);

        // Create iron gloves armor
        armor = new Armor
        {
            itemId = 2103,
            name = "Steel Gauntlets",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            armorType = ArmorType.Gloves,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            armorPen = 2,

        };
        armorList.Add(armor);

        // Create iron greaves armor
        armor = new Armor
        {
            itemId = 2104,
            name = "Steel Greaves",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            armorType = ArmorType.Legs,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,

        };
        armorList.Add(armor);

        // Create iron boots armor
        armor = new Armor
        {
            itemId = 2105,
            name = "Steel Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            armorType = ArmorType.Boots,
            strength = 5,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 2,

        };
        armorList.Add(armor);


        // Create leather head armor
        armor = new Armor
        {
            itemId = 2201,
            name = "Studded Leather Head",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            armorType = ArmorType.Head,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 10,

        };
        armorList.Add(armor);

        // Create leather chest armor
        armor = new Armor
        {
            itemId = 2202,
            name = "Studded Leather Chest",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            armorType = ArmorType.Chest,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 10,

        };
        armorList.Add(armor);

        // Create leather gloves armor
        armor = new Armor
        {
            itemId = 2203,
            name = "Studded Leather Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            armorType = ArmorType.Gloves,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 10,

        };
        armorList.Add(armor);

        // Create leather legs armor
        armor = new Armor
        {
            itemId = 2204,
            name = "Studded Leather Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            armorType = ArmorType.Legs,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 10,

        };
        armorList.Add(armor);

        // Create leather boots armor
        armor = new Armor
        {
            itemId = 2205,
            name = "Studded Leather Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            armorType = ArmorType.Boots,
            strength = 2,
            dexterity = 5,
            intelligence = 2,
            critChance = 0,
            critDamage = 10,

        };
        armorList.Add(armor);

        // Create cloth hood armor
        armor = new Armor
        {
            itemId = 2301,
            name = "Fine Cloth Hood",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            armorType = ArmorType.Head,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 2,

        };
        armorList.Add(armor);

        // Create cloth robes armor
        armor = new Armor
        {
            itemId = 2302,
            name = "Fine Cloth Robes",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            armorType = ArmorType.Chest,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 2,

        };
        armorList.Add(armor);

        // Create cloth gloves armor
        armor = new Armor
        {
            itemId = 2303,
            name = "Fine Cloth Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            armorType = ArmorType.Gloves,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 2,

        };
        armorList.Add(armor);

        // Create cloth Legs armor
        armor = new Armor
        {
            itemId = 2304,
            name = "Fine Cloth Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            armorType = ArmorType.Legs,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 2,

        };
        armorList.Add(armor);

        // Create cloth hood armor
        armor = new Armor
        {
            itemId = 2305,
            name = "Fine Cloth Shoes",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 40,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            armorType = ArmorType.Boots,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 2,

        };
        armorList.Add(armor);
        /********************/
        /***   LEYENDOS  ***/
        /******************/
        // Create cloth hood armor
        armor = new Armor
        {
            itemId = 2311,
            name = "Necromancer Hood",
            spritePath = "Icons/helm",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            requiredInt = 10,
            armorType = ArmorType.Head,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 5,
            bonusMagical = -3,
            armorPen = 5,

        };
        armorList.Add(armor);

        armor = new Armor
        {
            itemId = 2312,
            name = "Necromancer Robes",
            spritePath = "Icons/chest",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            requiredInt = 10,
            armorType = ArmorType.Chest,
            strength = 2,
            dexterity = 2,
            intelligence = 5,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 5,
            bonusMagical = -3,
            armorPen = 5,

        };
        armorList.Add(armor);

        // Create leather gloves armor
        armor = new Armor
        {
            itemId = 2213,
            name = "Pickpocket's Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            requiredDex = 10,
            armorType = ArmorType.Gloves,
            strength = 2,
            dexterity = 3,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,
            bonusGold = 35,

        };
        armorList.Add(armor);

         // Create iron gloves armor
        armor = new Armor
        {
            itemId = 2113,
            name = "Kiddie Gloves",
            spritePath = "Icons/gloves2",
            flavorText = "You'll be a big kid someday",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            armorType = ArmorType.Gloves,
            strength = 1,
            dexterity = 1,
            intelligence = 1,
            bonusExp = 30,
        };
        armorList.Add(armor);

        // Create iron head armor
        armor = new Armor
        {
            itemId = 2111,
            name = "Dunce Cap",
            spritePath = "Icons/helm",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            requiredStr = 30,
            armorType = ArmorType.Head,
            strength = 10,
            dexterity = 0,
            intelligence = -10,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 10,
            bonusExp = -10

        };
        armorList.Add(armor);

        // Create iron chest armor
        armor = new Armor
        {
            itemId = 2102,
            name = "Dwarven Steel Breastplate",
            spritePath = "Icons/chest",
            flavorText = "It's a tight fit, but comes with a comfy beard-holster",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            requiredStr = 30,
            armorType = ArmorType.Chest,
            strength = 10,
            dexterity = 0,
            intelligence = 0,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 0,
            armorPen = 5,

        };
        armorList.Add(armor);
        /********************/
        /***   TIER 3    ***/
        /******************/

        // Create iron head armor
        armor = new Armor
        {
            itemId = 3101,
            name = "Mithril Head",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            armorType = ArmorType.Head,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,

        };
        armorList.Add(armor);

        // Create iron chest armor
        armor = new Armor
        {
            itemId = 3102,
            name = "Mithril Breastplate",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            armorType = ArmorType.Chest,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,

        };
        armorList.Add(armor);

        // Create iron gloves armor
        armor = new Armor
        {
            itemId = 3103,
            name = "Mithril Gauntlets",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            armorType = ArmorType.Gloves,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,
        };
        armorList.Add(armor);

        // Create iron greaves armor
        armor = new Armor
        {
            itemId = 3104,
            name = "Mithril Greaves",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            armorType = ArmorType.Legs,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,

        };
        armorList.Add(armor);

        // Create iron boots armor
        armor = new Armor
        {
            itemId = 3105,
            name = "Mithril Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            armorType = ArmorType.Boots,
            strength = 7,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = 3,
        };
        armorList.Add(armor);


        // Create leather head armor
        armor = new Armor
        {
            itemId = 3201,
            name = "Drakehide Head",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredDex = 50,
            armorType = ArmorType.Head,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 0,
            critDamage = 15,

        };
        armorList.Add(armor);

        // Create leather chest armor
        armor = new Armor
        {
            itemId = 3202,
            name = "Drakehide Chest",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredDex = 50,
            armorType = ArmorType.Chest,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 0,
            critDamage = 15,

        };
        armorList.Add(armor);

        // Create leather gloves armor
        armor = new Armor
        {
            itemId = 3203,
            name = "Drakehide Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredDex = 50,
            armorType = ArmorType.Gloves,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 0,
            critDamage = 15,

        };
        armorList.Add(armor);

        // Create leather legs armor
        armor = new Armor
        {
            itemId = 3204,
            name = "Drakehide Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredDex = 50,
            armorType = ArmorType.Legs,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 0,
            critDamage = 15,

        };
        armorList.Add(armor);

        // Create leather boots armor
        armor = new Armor
        {
            itemId = 3205,
            name = "Drakehide Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 15,
            requiredDex = 50,
            armorType = ArmorType.Boots,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 0,
            critDamage = 15,

        };
        armorList.Add(armor);

        // Create cloth hood armor
        armor = new Armor
        {
            itemId = 3301,
            name = "Diviner Hood",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 5,
            requiredInt = 50,
            armorType = ArmorType.Head,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 3,

        };
        armorList.Add(armor);

        // Create cloth robes armor
        armor = new Armor
        {
            itemId = 3302,
            name = "Diviner Robes",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 5,
            requiredInt = 50,
            armorType = ArmorType.Chest,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 3,

        };
        armorList.Add(armor);

        // Create cloth gloves armor
        armor = new Armor
        {
            itemId = 3303,
            name = "Diviner Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 5,
            requiredInt = 50,
            armorType = ArmorType.Gloves,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 3,

        };
        armorList.Add(armor);

        // Create cloth Legs armor
        armor = new Armor
        {
            itemId = 3304,
            name = "Diviner Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 5,
            requiredInt = 50,
            armorType = ArmorType.Legs,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 3,

        };
        armorList.Add(armor);

        // Create cloth boots armor
        armor = new Armor
        {
            itemId = 3305,
            name = "Diviner Shoes",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 80,
            sellValue = 40,
            requiredLevel = 5,
            requiredInt = 50,
            armorType = ArmorType.Boots,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 3,

        };
        armorList.Add(armor);
        /****************/
        /*** LEYENDOS ***/
        /****************/
        // Create iron head armor
        armor = new Armor
        {
            itemId = 3111,
            name = "Paladin Head",
            spritePath = "Icons/helm",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 15,
            requiredStr = 50,
            armorType = ArmorType.Head,
            strength = 8,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = -5,
            bonusMagical = 10,

        };
        armorList.Add(armor);

        armor = new Armor
        {
            itemId = 3112,
            name = "Paladin Plate",
            spritePath = "Icons/chest",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 15,
            requiredStr = 50,
            armorType = ArmorType.Chest,
            strength = 8,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = -5,
            bonusMagical = 10,

        };
        armorList.Add(armor);

        armor = new Armor
        {
            itemId = 3114,
            name = "Paladin Greaves",
            spritePath = "Icons/legs",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 15,
            requiredStr = 50,
            armorType = ArmorType.Legs,
            strength = 8,
            dexterity = 3,
            intelligence = 3,
            critChance = 0,
            critDamage = 0,
            bonusPhysical = -5,
            bonusMagical = 10,

        };
        armorList.Add(armor);

        armor = new Armor
        {
            itemId = 3315,
            name = "Winged Shoes",
            spritePath = "Icons/boots2",
            flavorText = "Note: hilarious on dogs",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 15,
            requiredInt = 50,
            armorType = ArmorType.Boots,
            strength = 3,
            dexterity = 3,
            intelligence = 7,
            critChance = 0,
            critDamage = 0,
            bonusMagical = 5,

        };
        armorList.Add(armor);

        // Create leather legs armor
        armor = new Armor
        {
            itemId = 3214,
            name = "Assassin's Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 15,
            requiredDex = 50,
            armorType = ArmorType.Legs,
            strength = 3,
            dexterity = 5,
            intelligence = 3,
            critChance = 1,
            critDamage = 50,

        };
        armorList.Add(armor);
        // Create leather shoes armor
        armor = new Armor
        {
            itemId = 3215,
            name = "Shadowhide Boots",
            spritePath = "Icons/boots2",
            flavorText = "I walk in the valley of the shadow of death",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 15,
            requiredDex = 50,
            armorType = ArmorType.Boots,
            strength = 3,
            dexterity = 7,
            intelligence = 3,
            critChance = 5,
            critDamage = 15,

        };
        armorList.Add(armor);
        return armorList;
    }

}
