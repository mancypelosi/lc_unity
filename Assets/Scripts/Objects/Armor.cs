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

        // Create leather head armor
        armor = new Armor
        {
            itemId = 1001,
            name = "Leather Helm",
            spritePath = "Icons/helm",
            rarity = Rarity.Uncommon,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            armorType = ArmorType.Head,
            strength = 2,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        // Create leather chest armor
        armor = new Armor
        {
            itemId = 1002,
            name = "Leather Chest",
            spritePath = "Icons/chest",
            rarity = Rarity.Uncommon,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Chest,
            strength = 2,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        // Create leather gloves armor
        armor = new Armor
        {
            itemId = 1003,
            name = "Leather Gloves",
            spritePath = "Icons/gloves2",
            rarity = Rarity.Uncommon,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Gloves,
            strength = 2,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        // Create leather legs armor
        armor = new Armor
        {
            itemId = 1004,
            name = "Leather Legs",
            spritePath = "Icons/legs",
            rarity = Rarity.Uncommon,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Legs,
            strength = 2,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        // Create leather boots armor
        armor = new Armor
        {
            itemId = 1005,
            name = "Leather Boots",
            spritePath = "Icons/boots2",
            rarity = Rarity.Uncommon,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            armorType = ArmorType.Boots,
            strength = 2,
            dexterity = 2,
            intelligence = 2,
            critChance = 0,
            critDamage = 0,

        };
        armorList.Add(armor);

        /********************/
        /*** LEGENDARIES ***/
        /******************/

        return armorList;
    }

}
