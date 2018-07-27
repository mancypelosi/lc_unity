using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Weapon : Item
{

    // Enumerators
    public enum WeaponType
    {
        None,
        Sword,
        Axe,
        Mace,
        Gun,
        Dagger,
        Spear,
        Claw,
        Bow,
        Staff,
        Wand,
        Chakram,
        Spell,
        Shield
    }

    public enum ElementType
    {
        None,
        Fire,
        Earth,
        Poison,
        Water,
        Ice,
        Air,
        Lightning,
        Light,
        Dark
    }

    public enum DamageType
    {
        Physical,
        Magical
    }

    public enum StatModifier
    {
        None,
        Strength,
        Dexterity,
        Intelligence
    }

    // Weapon properties
    public string soundPath;
    public WeaponType weaponType = WeaponType.None;
    public ElementType elementType = ElementType.None;
    public DamageType damageType = DamageType.Physical;
    public StatModifier statMod = StatModifier.Strength;
    public int apc = 1;
    public int minDamage = 1;
    public int maxDamage = 1;
    public bool isDot = false; // Deals DoT damage on a timer
    public bool isSundering = false; // Decreases enemy armor every attack
    public bool isNegating = false; // Decreases enemy magic resist every attack

    // Default Constructor
    public Weapon()
    {
        name = "Fist";
        spritePath = "Icons/fist";
        soundPath = "Sfx/punchsfx";
    }

    // Tooltip override
    override
    public string GetToolTip()
    {
        string tooltip = "";
        tooltip += "Weapon Type: " + weaponType + Environment.NewLine;
        tooltip += "Damage Type: " + damageType + Environment.NewLine;
        if (elementType != ElementType.None)
            tooltip += "Element Type: " + elementType + Environment.NewLine;
        tooltip += "Modifier: " + statMod + Environment.NewLine;
        tooltip += "Damage: [" + minDamage + "-" + maxDamage + "]" + Environment.NewLine;
        tooltip += "APC: " + apc + Environment.NewLine;
        tooltip += "Str: " + strength + " Dex: " + dexterity + " Int: " + intelligence + Environment.NewLine;
        if (isDot)
            tooltip += "DoT" + Environment.NewLine;
        if (isSundering)
            tooltip += "Sundering" + Environment.NewLine;
        if (isNegating)
            tooltip += "Negating" + Environment.NewLine;
        if (requiredLevel > 0)
            tooltip += "Required Level: " + requiredLevel + Environment.NewLine;
        if (requiredStr > 0)
            tooltip += "Required Str: " + requiredStr + Environment.NewLine;
        if (requiredDex > 0)
            tooltip += "Required Dex: " + requiredDex + Environment.NewLine;
        if (requiredInt > 0)
            tooltip += "Required Int: " + requiredInt + Environment.NewLine;
        if (flavorText != "")
            tooltip += '"' + flavorText + '"' + Environment.NewLine;
        tooltip += "Value: " + sellValue + Environment.NewLine;
        return tooltip;
    }

    // Get Weapon by item id from list
    public Weapon GetWeaponById(List<Weapon> list, int id)
    {
        Weapon w = new Weapon();
        if ((list.Find(weapon => weapon.itemId == id) != null))
            w = list.Find(weapon => weapon.itemId == id);
        return w;
    }

    // Get a list of all items in the tier
    public List<Weapon> GetListByTier(List<Weapon> list, int tier)
    {
        List<Weapon> tierList = new List<Weapon>();
        foreach (Weapon w in list)
        {
            // Check if the first digit of the id matches the tier
            if ((Int32.Parse(w.itemId.ToString("000000").Substring(0, 2))) == tier)
                tierList.Add(w);
        }
        return tierList;
    }

    // List of all weapons
    public List<Weapon> WeaponList()
    {
        List<Weapon> weaponList = new List<Weapon>();
        Weapon weapon;

        /***************/
        /*** TIER 0 ***/
        /*************/

        // Create sword weapon
        weapon = new Weapon
        {
            itemId = 00101,
            name = "Rusty Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Common,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            weaponType = WeaponType.Sword,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 1,
            maxDamage = 5
        };
        weaponList.Add(weapon);

        // Create dagger weapon
        weapon = new Weapon
        {
            itemId = 00205,
            name = "Rusty Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Common,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 1,
            maxDamage = 3,
            critChance = 1,
            critDamage = 5
        };
        weaponList.Add(weapon);

        // Create staff weapon
        weapon = new Weapon
        {
            itemId = 00309,
            name = "Rotton Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Common,
            buyValue = 10,
            sellValue = 5,
            requiredLevel = 1,
            weaponType = WeaponType.Staff,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 1,
            maxDamage = 5
        };
        weaponList.Add(weapon);

        /***************/
        /*** TIER 1 ***/
        /*************/

        // Create sword weapon
        weapon = new Weapon
        {
            itemId = 10101,
            name = "Iron Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Common,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Sword,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create flaming sword weapon
        weapon = new Weapon
        {
            itemId = 11101,
            name = "Flaming Iron Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Common,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Sword,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create dagger weapon
        weapon = new Weapon
        {
            itemId = 10202,
            name = "Iron Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Common,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 3,
            maxDamage = 8
        };
        weaponList.Add(weapon);

        // Create flaming dagger weapon
        weapon = new Weapon
        {
            itemId = 11202,
            name = "Flaming Iron Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Common,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 3,
            maxDamage = 8
        };
        weaponList.Add(weapon);

        // Create poison dagger weapon
        weapon = new Weapon
        {
            itemId = 13202,
            name = "Poisoned Iron Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Common,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Poison,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            isDot = true,
            minDamage = 3,
            maxDamage = 8
        };
        weaponList.Add(weapon);

        // Create staff weapon
        weapon = new Weapon
        {
            itemId = 10309,
            name = "Oak Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Common,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Staff,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create frost staff weapon
        weapon = new Weapon
        {
            itemId = 15309,
            name = "Frost Oak Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Common,
            buyValue = 20,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Staff,
            elementType = ElementType.Ice,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create rifle
        weapon = new Weapon
        {
            itemId = 10104,
            name = "Iron Rifle",
            spritePath = "Icons/rifle",
            soundPath = "Sfx/gunsfx",
            rarity = Rarity.Common,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Gun,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create bow
        weapon = new Weapon
        {
            itemId = 10208,
            name = "Oak Bow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/bowsfx",
            rarity = Rarity.Common,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Bow,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create thunder bow
        weapon = new Weapon
        {
            itemId = 17208,
            name = "Thunder Oak Bow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/thundersfx",
            rarity = Rarity.Common,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Bow,
            elementType = ElementType.Lightning,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create fireball
        weapon = new Weapon
        {
            itemId = 11312,
            name = "Fireball",
            spritePath = "Icons/spell",
            soundPath = "Sfx/fireballsfx",
            rarity = Rarity.Common,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create icebolt
        weapon = new Weapon
        {
            itemId = 15312,
            name = "Ice Bolt",
            spritePath = "Icons/spell",
            soundPath = "Sfx/icesfx",
            rarity = Rarity.Uncommon,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Ice,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 1,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create enfeebling ray
        weapon = new Weapon
        {
            itemId = 19312,
            name = "Enfeebling Ray",
            spritePath = "Icons/spell",
            soundPath = "Sfx/lasersfx",
            rarity = Rarity.Common,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Dark,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 7,
            maxDamage = 7,
            magicPen = 5
        };
        weaponList.Add(weapon);

        // Create ZOMBIES
        weapon = new Weapon
        {
            itemId = 19303,
            name = "Summon Zombie",
            spritePath = "Icons/zombie",
            soundPath = "Sfx/groansfx",
            rarity = Rarity.Uncommon,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Mace,
            elementType = ElementType.Dark,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            isDot = true,
            minDamage = 2,
            maxDamage = 6,

        };
        weaponList.Add(weapon);

        // Create str shield
        weapon = new Weapon
        {
            itemId = 10113,
            name = "Iron Shield",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 1,
            maxDamage = 1,
            strength = 5
        };
        weaponList.Add(weapon);

        // Create dex shield
        weapon = new Weapon
        {
            itemId = 10213,
            name = "Iron Buckler",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 1,
            maxDamage = 1,
            dexterity = 5
        };
        weaponList.Add(weapon);

        // Create int shield
        weapon = new Weapon
        {
            itemId = 10313,
            name = "Oak Spirit Shield",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 25,
            sellValue = 10,
            requiredLevel = 1,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 1,
            maxDamage = 1,
            intelligence = 5
        };
        weaponList.Add(weapon);

        /***************/
        /*** TIER 2 ***/
        /*************/

        // Create sword weapon
        weapon = new Weapon
        {
            itemId = 20101,
            name = "Steel Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Sword,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create flaming sword weapon
        weapon = new Weapon
        {
            itemId = 21101,
            name = "Flaming Steel Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Sword,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create windblade weapon
        weapon = new Weapon
        {
            itemId = 26101,
            name = "Windblade",
            flavorText = "Hasaki",
            spritePath = "Icons/windblade",
            soundPath = "Sfx/windbladesfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredStr = 15,
            weaponType = WeaponType.Sword,
            elementType = ElementType.Air,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 8,
            maxDamage = 15,
            critChance = 3
        };
        weaponList.Add(weapon);


        // Create axe weapon
        weapon = new Weapon
        {
            itemId = 20102,
            name = "Steel Axe",
            spritePath = "Icons/axe",
            soundPath = "Sfx/axesfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Axe,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 9,
            maxDamage = 17,
            armorPen = -7
        };
        weaponList.Add(weapon);

        // Create axe weapon
        weapon = new Weapon
        {
            itemId = 27102,
            name = "Steel Conductive Axe",
            spritePath = "Icons/axe",
            soundPath = "Sfx/axesfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Axe,
            elementType = ElementType.Lightning,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 9,
            maxDamage = 17,
            magicPen = -7
        };
        weaponList.Add(weapon);

        // Create mace weapon
        weapon = new Weapon
        {
            itemId = 20103,
            name = "Steel Mace",
            spritePath = "Icons/mace",
            soundPath = "Sfx/macesfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Mace,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 7,
            maxDamage = 13,
            armorPen = 7
        };
        weaponList.Add(weapon);

        // Create mace weapon
        weapon = new Weapon
        {
            itemId = 28103,
            name = "Steel Crusader Mace",
            spritePath = "Icons/mace",
            soundPath = "Sfx/macesfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Mace,
            elementType = ElementType.Light,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 7,
            maxDamage = 13,
            magicPen = 7
        };
        weaponList.Add(weapon);

        // Create warhammer weapon
        weapon = new Weapon
        {
            itemId = 28103,
            name = "Steel Warhammer",
            spritePath = "Icons/mace",
            soundPath = "Sfx/macesfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredStr = 15,
            weaponType = WeaponType.Mace,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 7,
            maxDamage = 14,
            armorPen = 10
        };
        weaponList.Add(weapon);

        // Create dagger weapon
        weapon = new Weapon
        {
            itemId = 20205,
            name = "Steel Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 4,
            maxDamage = 11
        };
        weaponList.Add(weapon);

        // Create flaming dagger weapon
        weapon = new Weapon
        {
            itemId = 21205,
            name = "Flaming Steel Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 1,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 4,
            maxDamage = 11
        };
        weaponList.Add(weapon);

        // Create poison dagger weapon
        weapon = new Weapon
        {
            itemId = 23202,
            name = "Poisoned Iron Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Poison,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            isDot = true,
            minDamage = 4,
            maxDamage = 11
        };
        weaponList.Add(weapon);

        // Create staff weapon
        weapon = new Weapon
        {
            itemId = 20309,
            name = "Yew Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Staff,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create frost staff weapon
        weapon = new Weapon
        {
            itemId = 24309,
            name = "Water Yew Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Staff,
            elementType = ElementType.Water,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create rifle
        weapon = new Weapon
        {
            itemId = 20104,
            name = "Steel Rifle",
            spritePath = "Icons/rifle",
            soundPath = "Sfx/gunsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Gun,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);


        // Create spear
        weapon = new Weapon
        {
            itemId = 20206,
            name = "Steel Spear",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Spear,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 10,
            maxDamage = 13
        };
        weaponList.Add(weapon);

        // Create glaive
        weapon = new Weapon
        {
            itemId = 20206,
            name = "Steel Warglaive",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearsfx",
            rarity = Rarity.Common,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredDex = 15,
            weaponType = WeaponType.Spear,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 10,
            maxDamage = 11,
            critChance = 5
        };
        weaponList.Add(weapon);

        // Create spear
        weapon = new Weapon
        {
            itemId = 24206,
            name = "Steel Water Trident",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Spear,
            elementType = ElementType.Water,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 10,
            maxDamage = 13
        };
        weaponList.Add(weapon);

        // Create bow
        weapon = new Weapon
        {
            itemId = 20208,
            name = "Yew Bow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/bowsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Bow,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create thunder bow
        weapon = new Weapon
        {
            itemId = 27208,
            name = "Thunder Yew Bow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/thundersfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Bow,
            elementType = ElementType.Lightning,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create claw
        weapon = new Weapon
        {
            itemId = 20206,
            name = "Steel Claws",
            spritePath = "Icons/claws",
            soundPath = "Sfx/clawsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Claw,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 3,
            maxDamage = 11,
            critDamage = 15
        };
        weaponList.Add(weapon);

        // Create claw
        weapon = new Weapon
        {
            itemId = 29206,
            name = "Steel Shadow Claws",
            spritePath = "Icons/claws",
            soundPath = "Sfx/clawsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Claw,
            elementType = ElementType.Dark,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 3,
            maxDamage = 11,
            critDamage = 15
        };
        weaponList.Add(weapon);

        // Create fireball
        weapon = new Weapon
        {
            itemId = 21312,
            name = "Firestorm",
            spritePath = "Icons/spell",
            soundPath = "Sfx/fireballsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create ice storm
        weapon = new Weapon
        {
            itemId = 25312,
            name = "Icicle Crash",
            spritePath = "Icons/spell",
            soundPath = "Sfx/icesfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Ice,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 1,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create wand
        weapon = new Weapon
        {
            itemId = 21310,
            name = "Yew Wand",
            spritePath = "Icons/wand",
            soundPath = "Sfx/wandsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Wand,
            elementType = ElementType.None,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create enfeebling ray
        weapon = new Weapon
        {
            itemId = 29312,
            name = "Necrotic Ray",
            spritePath = "Icons/spell",
            soundPath = "Sfx/lasersfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Dark,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 11,
            maxDamage = 11,
            magicPen = 8
        };
        weaponList.Add(weapon);

        // Create ZOMBIES
        weapon = new Weapon
        {
            itemId = 29303,
            name = "Summon Zombie Brute",
            spritePath = "Icons/zombie",
            soundPath = "Sfx/groansfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Mace,
            elementType = ElementType.Dark,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            isDot = true,
            minDamage = 4,
            maxDamage = 9,

        };
        weaponList.Add(weapon);

        // Create chakram
        weapon = new Weapon
        {
            itemId = 20311,
            name = "Steel Chakram",
            spritePath = "Icons/chakram",
            soundPath = "Sfx/chakramsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Chakram,
            elementType = ElementType.None,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 2,
            minDamage = 3,
            maxDamage = 11,
            critChance = 3
        };
        weaponList.Add(weapon);
        // Create chakram
        weapon = new Weapon
        {
            itemId = 28311,
            name = "Steel Angelic Chakram",
            spritePath = "Icons/chakram",
            soundPath = "Sfx/chakramsfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Chakram,
            elementType = ElementType.Light,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 2,
            minDamage = 3,
            maxDamage = 11,
            critChance = 3
        };
        weaponList.Add(weapon);


        // Create str shield
        weapon = new Weapon
        {
            itemId = 20113,
            name = "Steel Shield",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 1,
            maxDamage = 2,
            strength = 8
        };
        weaponList.Add(weapon);

        // Create dex shield
        weapon = new Weapon
        {
            itemId = 20213,
            name = "Steel Buckler",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 1,
            maxDamage = 2,
            dexterity = 8
        };
        weaponList.Add(weapon);

        // Create int shield
        weapon = new Weapon
        {
            itemId = 20313,
            name = "Yew Spirit Totem",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 50,
            sellValue = 20,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 1,
            maxDamage = 2,
            intelligence = 8
        };
        weaponList.Add(weapon);

        /***************/
        /*** TIER 3 ***/
        /*************/

        /***************/
        /*** TIER 4 ***/
        /*************/

        /********************/
        /*** LEGENDARIES ***/
        /******************/

        // Executioner Sword
        weapon = new Weapon
        {
            itemId = 1,
            name = "Executioner Sword",
            flavorText = "Death calls...",
            spritePath = "Icons/bigsword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            weaponType = WeaponType.Sword,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 1,
            maxDamage = 15,
            strength = 3,
            critChance = -5,
            critDamage = 10,
            isSundering = true
        };
        weaponList.Add(weapon);

        // Polished Rapier
        weapon = new Weapon
        {
            itemId = 2,
            name = "Polished Rapier",
            spritePath = "Icons/rapier",
            soundPath = "Sfx/stab1sfx",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            weaponType = WeaponType.Sword,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 1,
            maxDamage = 6,
            dexterity = 3,
            critChance = 10,
            critDamage = 0
        };
        weaponList.Add(weapon);

        // Shotgun Fireball
        weapon = new Weapon
        {
            itemId = 3,
            name = "Shotgun Fireball",
            spritePath = "Icons/spell",
            soundPath = "Sfx/shotgunsfx",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 5,
            minDamage = 1,
            maxDamage = 2,
            intelligence = 3,
            critChance = 5
        };
        weaponList.Add(weapon);

        weapon = new Weapon
        {
            itemId = 4,
            name = "OP Sword of Breath Holding",
            flavorText = "Garrett, hold your breath",
            spritePath = "Icons/bigsword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 1,
            weaponType = WeaponType.Sword,
            elementType = ElementType.Fire,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 100,
            maxDamage = 100
        };
        weaponList.Add(weapon);

        weapon = new Weapon
        {
            itemId = 5,
            name = "Summon Skeleton",
            flavorText = "*Bones rattle*",
            spritePath = "Icons/spell",
            soundPath = "Sfx/skeletonsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 1,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Dark,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            isDot = true,
            apc = 1,
            minDamage = 5,
            maxDamage = 10
        };
        weaponList.Add(weapon);

        return weaponList;
    }

}

