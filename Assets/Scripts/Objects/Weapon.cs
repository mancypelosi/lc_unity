
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

    // Get a list of all items in the tier (tier is a 2 digit value)
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
            itemId = 000101,
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
            itemId = 000205,
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
            itemId = 000309,
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
            itemId = 010101,
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
            itemId = 011101,
            name = "Flaming Iron Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Uncommon,
            buyValue = 30,
            sellValue = 15,
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
            itemId = 010202,
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
            minDamage = 2,
            maxDamage = 6
        };
        weaponList.Add(weapon);

        // Create flaming dagger weapon
        weapon = new Weapon
        {
            itemId = 011202,
            name = "Flaming Iron Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Uncommon,
            buyValue = 30,
            sellValue = 15,
            requiredLevel = 1,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 2,
            maxDamage = 6
        };
        weaponList.Add(weapon);

        // Create poison dagger weapon
        weapon = new Weapon
        {
            itemId = 013202,
            name = "Poisoned Iron Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Uncommon,
            buyValue = 30,
            sellValue = 15,
            requiredLevel = 1,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Poison,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            isDot = true,
            minDamage = 2,
            maxDamage = 6
        };
        weaponList.Add(weapon);

        // Create staff weapon
        weapon = new Weapon
        {
            itemId = 010309,
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
            itemId = 015309,
            name = "Frost Oak Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Uncommon,
            buyValue = 30,
            sellValue = 15,
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
            itemId = 010104,
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
            itemId = 010208,
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
            itemId = 017208,
            name = "Thunder Oak Bow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/thundersfx",
            rarity = Rarity.Uncommon,
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
            itemId = 011312,
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
            itemId = 015312,
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
            itemId = 019312,
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
            itemId = 019303,
            name = "Summon Zombie",
            spritePath = "Icons/zombie",
            soundPath = "Sfx/groansfx",
            rarity = Rarity.Uncommon,
            buyValue = 30,
            sellValue = 15,
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
            itemId = 010113,
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
            itemId = 010213,
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
            itemId = 010313,
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
            itemId = 020101,
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
            itemId = 021101,
            name = "Flaming Steel Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
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
            itemId = 026101,
            name = "Windblade",
            flavorText = "windbladesfx",
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
            minDamage = 7,
            maxDamage = 14,
            critChance = 3
        };
        weaponList.Add(weapon);


        // Create axe weapon
        weapon = new Weapon
        {
            itemId = 020102,
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
            itemId = 027102,
            name = "Steel Conductive Axe",
            spritePath = "Icons/axe",
            soundPath = "Sfx/axesfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
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
            itemId = 020103,
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
            itemId = 028103,
            name = "Steel Crusader Mace",
            spritePath = "Icons/mace",
            soundPath = "Sfx/macesfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
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
            itemId = 028103,
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
            itemId = 020205,
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
            minDamage = 3,
            maxDamage = 9
        };
        weaponList.Add(weapon);

        // Create flaming dagger weapon
        weapon = new Weapon
        {
            itemId = 021205,
            name = "Flaming Steel Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 3,
            maxDamage = 9
        };
        weaponList.Add(weapon);

        // Create poison dagger weapon
        weapon = new Weapon
        {
            itemId = 023202,
            name = "Poisoned Steel Dagger",
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
            maxDamage = 10
        };
        weaponList.Add(weapon);

        // Create staff weapon
        weapon = new Weapon
        {
            itemId = 020309,
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
            itemId = 024309,
            name = "Water Yew Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
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
            itemId = 020104,
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

        // Create rifle
        weapon = new Weapon
        {
            itemId = 020104,
            name = "Steel Boulder Launcher",
            flavorText = "Beats throwing them",
            spritePath = "Icons/rifle",
            soundPath = "Sfx/gunsfx",
            rarity = Rarity.Common,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Gun,
            elementType = ElementType.Earth,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 8,
            maxDamage = 15
        };
        weaponList.Add(weapon);


        // Create spear
        weapon = new Weapon
        {
            itemId = 020206,
            name = "Steel Spear",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearsfx",
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
            itemId = 020206,
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
            itemId = 024206,
            name = "Steel Water Trident",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearsfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
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
            itemId = 020208,
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
            itemId = 027208,
            name = "Thunder Yew Bow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/thundersfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
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
            itemId = 020206,
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
            minDamage = 2,
            maxDamage = 9,
            critDamage = 15
        };
        weaponList.Add(weapon);

        // Create claw
        weapon = new Weapon
        {
            itemId = 029206,
            name = "Steel Shadow Claws",
            spritePath = "Icons/claws",
            soundPath = "Sfx/clawsfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Claw,
            elementType = ElementType.Dark,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 2,
            maxDamage = 9,
            critDamage = 15
        };
        weaponList.Add(weapon);

        // Create fireball
        weapon = new Weapon
        {
            itemId = 021312,
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
            itemId = 025312,
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
            itemId = 021310,
            name = "Yew Wand",
            spritePath = "Icons/wand",
            soundPath = "Sfx/wandsfx1",
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
            itemId = 029312,
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
            itemId = 029303,
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
            itemId = 020311,
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
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 2,
            minDamage = 1,
            maxDamage = 11,
            critChance = 3
        };
        weaponList.Add(weapon);

        // Create chakram
        weapon = new Weapon
        {
            itemId = 028311,
            name = "Steel Angelic Chakram",
            spritePath = "Icons/chakram",
            soundPath = "Sfx/chakramsfx",
            rarity = Rarity.Uncommon,
            buyValue = 60,
            sellValue = 30,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Chakram,
            elementType = ElementType.Light,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 2,
            minDamage = 1,
            maxDamage = 11,
            critChance = 3
        };
        weaponList.Add(weapon);


        // Create str shield
        weapon = new Weapon
        {
            itemId = 020113,
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
            itemId = 020213,
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
            itemId = 020313,
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
        // Create sword weapon
        weapon = new Weapon
        {
            itemId = 030101,
            name = "Mithril Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Sword,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create flaming sword weapon
        weapon = new Weapon
        {
            itemId = 031101,
            name = "Flaming Mithril Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Sword,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create windblade weapon
        weapon = new Weapon
        {
            itemId = 036101,
            name = "Hurricane Sword",
            flavorText = "Measure twice, cut once",
            spritePath = "Icons/windblade",
            soundPath = "Sfx/windbladesfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Sword,
            elementType = ElementType.Air,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 11,
            maxDamage = 20,
            critChance = 3
        };
        weaponList.Add(weapon);


        // Create axe weapon
        weapon = new Weapon
        {
            itemId = 030102,
            name = "Mithril Axe",
            spritePath = "Icons/axe",
            soundPath = "Sfx/axesfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Axe,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 13,
            maxDamage = 25,
            armorPen = -10
        };
        weaponList.Add(weapon);

        // Create axe weapon
        weapon = new Weapon
        {
            itemId = 037102,
            name = "Mithril Conductive Axe",
            spritePath = "Icons/axe",
            soundPath = "Sfx/axesfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Axe,
            elementType = ElementType.Lightning,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 13,
            maxDamage = 25,
            magicPen = -10
        };
        weaponList.Add(weapon);

        // Create mace weapon
        weapon = new Weapon
        {
            itemId = 030103,
            name = "Mithril Mace",
            spritePath = "Icons/mace",
            soundPath = "Sfx/macesfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Mace,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 11,
            maxDamage = 19,
            armorPen = 10
        };
        weaponList.Add(weapon);

        // Create mace weapon
        weapon = new Weapon
        {
            itemId = 038103,
            name = "Mithril Crusader Mace",
            spritePath = "Icons/mace",
            soundPath = "Sfx/macesfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Mace,
            elementType = ElementType.Light,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 11,
            maxDamage = 19,
            magicPen = 10
        };
        weaponList.Add(weapon);

        // Create warhammer weapon
        weapon = new Weapon
        {
            itemId = 038103,
            name = "Mithril Warhammer",
            spritePath = "Icons/mace",
            soundPath = "Sfx/macesfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Mace,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 1,
            maxDamage = 20,
            armorPen = 13
        };
        weaponList.Add(weapon);

        // Create dagger weapon
        weapon = new Weapon
        {
            itemId = 030205,
            name = "Mithril Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 5,
            maxDamage = 13
        };
        weaponList.Add(weapon);

        // Create flaming dagger weapon
        weapon = new Weapon
        {
            itemId = 031205,
            name = "Flaming Mithril Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 5,
            maxDamage = 13
        };
        weaponList.Add(weapon);

        // Create poison dagger weapon
        weapon = new Weapon
        {
            itemId = 033202,
            name = "Poisoned Mithril Dagger",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Poison,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            isDot = true,
            minDamage = 6,
            maxDamage = 15
        };
        weaponList.Add(weapon);

        // Create staff weapon
        weapon = new Weapon
        {
            itemId = 030309,
            name = "Maple Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Staff,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create Earth staff weapon
        weapon = new Weapon
        {
            itemId = 034309,
            name = "Earthen Maple Staff",
            spritePath = "Icons/staff",
            soundPath = "Sfx/bamboosfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Staff,
            elementType = ElementType.Water,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create rifle
        weapon = new Weapon
        {
            itemId = 030104,
            name = "Mithril Rifle",
            spritePath = "Icons/rifle",
            soundPath = "Sfx/gunsfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Gun,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create rifle
        weapon = new Weapon
        {
            itemId = 030104,
            name = "Mithril Boulder Launcher",
            flavorText = "Beats throwing them",
            spritePath = "Icons/rifle",
            soundPath = "Sfx/gunsfx",
            rarity = Rarity.Common,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Gun,
            elementType = ElementType.Earth,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);


        // Create spear
        weapon = new Weapon
        {
            itemId = 030206,
            name = "Mithril Spear",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearsfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Spear,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 15,
            maxDamage = 19
        };
        weaponList.Add(weapon);

        // Create glaive
        weapon = new Weapon
        {
            itemId = 030206,
            name = "Mithril Warglaive",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearsfx",
            rarity = Rarity.Common,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Spear,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 15,
            maxDamage = 17,
            critChance = 5
        };
        weaponList.Add(weapon);

        // Create spear
        weapon = new Weapon
        {
            itemId = 034206,
            name = "Mithril Water Trident",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearsfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Spear,
            elementType = ElementType.Water,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 15,
            maxDamage = 19
        };
        weaponList.Add(weapon);

        // Create bow
        weapon = new Weapon
        {
            itemId = 030208,
            name = "Maple Bow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/bowsfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Bow,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create thunder bow
        weapon = new Weapon
        {
            itemId = 037208,
            name = "Thunder Maple Bow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/thundersfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Bow,
            elementType = ElementType.Lightning,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create claw
        weapon = new Weapon
        {
            itemId = 030206,
            name = "Mithril Claws",
            spritePath = "Icons/claws",
            soundPath = "Sfx/clawsfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Claw,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 3,
            maxDamage = 13,
            critDamage = 20
        };
        weaponList.Add(weapon);

        // Create claw
        weapon = new Weapon
        {
            itemId = 039206,
            name = "Mithril Shadow Claws",
            spritePath = "Icons/claws",
            soundPath = "Sfx/clawsfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Claw,
            elementType = ElementType.Dark,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 3,
            maxDamage = 13,
            critDamage = 20
        };
        weaponList.Add(weapon);

        // Create fireball
        weapon = new Weapon
        {
            itemId = 031312,
            name = "Inferno",
            spritePath = "Icons/spell",
            soundPath = "Sfx/fireballsfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 12,
            maxDamage = 22
        };
        weaponList.Add(weapon);

        // Create ice storm
        weapon = new Weapon
        {
            itemId = 035312,
            name = "Hailstorm",
            spritePath = "Icons/spell",
            soundPath = "Sfx/icesfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Ice,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 1,
            maxDamage = 33
        };
        weaponList.Add(weapon);

        // Create wand
        weapon = new Weapon
        {
            itemId = 031310,
            name = "Maple Wand",
            spritePath = "Icons/wand",
            soundPath = "Sfx/wandsfx1",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Wand,
            elementType = ElementType.None,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 10,
            maxDamage = 24
        };
        weaponList.Add(weapon);

        // Create enfeebling ray
        weapon = new Weapon
        {
            itemId = 039312,
            name = "Enervating Beam",
            spritePath = "Icons/spell",
            soundPath = "Sfx/lasersfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Dark,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 15,
            maxDamage = 15,
            magicPen = 12
        };
        weaponList.Add(weapon);

        // Create ZOMBIES
        weapon = new Weapon
        {
            itemId = 039303,
            name = "Summon Zombie Champion",
            spritePath = "Icons/zombie",
            soundPath = "Sfx/groansfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Mace,
            elementType = ElementType.Dark,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            isDot = true,
            minDamage = 6,
            maxDamage = 13,

        };
        weaponList.Add(weapon);

        // Create chakram
        weapon = new Weapon
        {
            itemId = 030311,
            name = "Mithril Chakram",
            spritePath = "Icons/chakram",
            soundPath = "Sfx/chakramsfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Chakram,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 2,
            minDamage = 1,
            maxDamage = 16,
            critChance = 3
        };
        weaponList.Add(weapon);

        // Create chakram
        weapon = new Weapon
        {
            itemId = 038311,
            name = "Mithril Angelic Chakram",
            spritePath = "Icons/chakram",
            soundPath = "Sfx/chakramsfx",
            rarity = Rarity.Uncommon,
            buyValue = 120,
            sellValue = 60,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Chakram,
            elementType = ElementType.Light,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 2,
            minDamage = 1,
            maxDamage = 16,
            critChance = 3
        };
        weaponList.Add(weapon);


        // Create str shield
        weapon = new Weapon
        {
            itemId = 030113,
            name = "Mithril Shield",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredStr = 50,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 1,
            maxDamage = 2,
            strength = 12
        };
        weaponList.Add(weapon);

        // Create dex shield
        weapon = new Weapon
        {
            itemId = 030213,
            name = "Mithril Buckler",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredDex = 50,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 1,
            maxDamage = 2,
            dexterity = 12
        };
        weaponList.Add(weapon);

        // Create int shield
        weapon = new Weapon
        {
            itemId = 030313,
            name = "Maple Spirit Totem",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 100,
            sellValue = 40,
            requiredLevel = 15,
            requiredInt = 50,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 1,
            maxDamage = 2,
            intelligence = 12
        };
        weaponList.Add(weapon);
        /***************/
        /*** TIER 4 ***/
        /*************/

        /********************/
        /*** LEGENDARIES ***/
        /******************/

        /*******************/
        /*** TIER 1 YO ***/
        /*******************/
        // Executioner Sword
        weapon = new Weapon
        {
            itemId = 010001,
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
            critDamage = 15,
            isSundering = true
        };
        weaponList.Add(weapon);

        // Polished Rapier
        weapon = new Weapon
        {
            itemId = 010002,
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
            itemId = 010003,
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

        // Ivy Sword
        weapon = new Weapon
        {
            itemId = 991001,
            name = "Ivy Sword",
            flavorText = "Get it? It sounds like Ivysaur",
            spritePath = "Icons/plantsword",
            soundPath = "Sfx/swordsfx",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            weaponType = WeaponType.Sword,
            elementType = ElementType.Poison,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 6,
            maxDamage = 13,
            strength = 5,
            critChance = 0,
            critDamage = 0,
            magicPen = 5,
            isNegating = true
        };
        weaponList.Add(weapon);

        // Seed Bomb
        weapon = new Weapon
        {
            itemId = 991002,
            name = "Seed Bomb",
            spritePath = "Icons/spell",
            soundPath = "Sfx/seedbombsfx",
            rarity = Rarity.Legendary,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Earth,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 3,
            minDamage = 1,
            maxDamage = 4,
            intelligence = 0,
            armorPen = 15,
        };
        weaponList.Add(weapon);

        // Create dex shield
        weapon = new Weapon
        {
            itemId = 991003,
            name = "Venusaurhide Buckler",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Common,
            buyValue = 1000,
            sellValue = 100,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Shield,
            elementType = ElementType.Earth,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 1,
            maxDamage = 8,
            dexterity = 5,
            critChance = 3,
            critDamage = 10,
        };
        weaponList.Add(weapon);

        weapon = new Weapon
        {
            itemId = 04001,
            name = "OP Sword of Breath Holding",
            flavorText = "Garrett, hold your breath",
            spritePath = "Icons/sword",
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

        /*******************/
        /*** TIER 2 YO ***/
        /*******************/

        weapon = new Weapon
        {
            itemId = 020001,
            name = "Summon Skeleton",
            flavorText = "*Bones rattle*",
            spritePath = "Icons/spell",
            soundPath = "Sfx/skeletonsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Sword,
            elementType = ElementType.Dark,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            isDot = true,
            apc = 1,
            minDamage = 5,
            maxDamage = 12
        };
        weaponList.Add(weapon);

        // Create axe weapon
        weapon = new Weapon
        {
            itemId = 020002,
            name = "Berserker Axes",
            spritePath = "Icons/axes",
            soundPath = "Sfx/axesfx",
            rarity = Rarity.Common,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Axe,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 2,
            minDamage = 8,
            maxDamage = 15,
            armorPen = -20
        };
        weaponList.Add(weapon);

        // Create wand
        weapon = new Weapon
        {
            itemId = 020003,
            name = "Colt .45 Lead Wand",
            flavorText = "This uh, might be a gun",
            spritePath = "Icons/wand",
            soundPath = "Sfx/gunsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Wand,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 10,
            maxDamage = 20,
            critDamage = 30
        };
        weaponList.Add(weapon);

        // Create thunder bow
        weapon = new Weapon
        {
            itemId = 020004,
            name = "The Moonbow",
            spritePath = "Icons/bow",
            soundPath = "Sfx/moonlightsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Bow,
            elementType = ElementType.Light,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 8,
            maxDamage = 18,
            dexterity = 5,
            magicPen = 10,
            isNegating = true
        };
        weaponList.Add(weapon);

        // Create dagger weapon
        weapon = new Weapon
        {
            itemId = 020005,
            name = "Fan of Knives",
            spritePath = "Icons/3dagger",
            soundPath = "Sfx/3stabsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Dexterity,
            apc = 3,
            minDamage = 3,
            maxDamage = 8,
            critChance = 5,
            critDamage = 10
        };
        weaponList.Add(weapon);

        // Create sword weapon
        weapon = new Weapon
        {
            itemId = 020006,
            name = "Toy Sword",
            spritePath = "Icons/sword",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Sword,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 5,
            maxDamage = 10,
            bonusExp = 25,
            bonusGold = 50,
            itemFind = 50,
            magicFind = 25
        };
        weaponList.Add(weapon);

        // Create axe weapon
        weapon = new Weapon
        {
            itemId = 992001,
            name = "Lava-Hewn Axe",
            spritePath = "Icons/axes",
            soundPath = "Sfx/axesfx",
            rarity = Rarity.Common,
            buyValue = 100000,
            sellValue = 1000,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Axe,
            elementType = ElementType.Fire,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 10,
            maxDamage = 30,
            armorPen = -20
        };
        weaponList.Add(weapon);

        // Create spear
        weapon = new Weapon
        {
            itemId = 992002,
            name = "Hades’ Trident",
            spritePath = "Icons/spear",
            soundPath = "Sfx/spearsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Spear,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 1,
            minDamage = 13,
            maxDamage = 16,
            critChance = 3,
            dexterity = 5
        };
        weaponList.Add(weapon);

        // Create int shield
        weapon = new Weapon
        {
            itemId = 992003,
            name = "Charizard’s Eternal Flame",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Shield,
            elementType = ElementType.Fire,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            minDamage = 1,
            maxDamage = 10,
            intelligence = 8,
            magicPen = 15
        };
        weaponList.Add(weapon);

        /*******************/
        /*** TIER 3 YO ***/
        /*******************/

        // Create str shield
        weapon = new Weapon
        {
            itemId = 993001,
            name = "Blast-Shell",
            spritePath = "Icons/shield",
            soundPath = "Sfx/donksfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Shield,
            elementType = ElementType.None,
            damageType = DamageType.Physical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 1,
            maxDamage = 2,
            strength = 22
        };
        weaponList.Add(weapon);

        // Create chakram
        weapon = new Weapon
        {
            itemId = 993002,
            name = "Wet Chakrams",
            flavorText = "Dipped in Blastoise water, these Chakrams are currently wet.",
            spritePath = "Icons/chakram",
            soundPath = "Sfx/chakramsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Chakram,
            elementType = ElementType.Water,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 2,
            minDamage = 1,
            maxDamage = 25,
            critChance = 5
        };
        weaponList.Add(weapon);

        // Create spell
        weapon = new Weapon
        {
            itemId = 993003,
            name = "Steam Burst",
            spritePath = "Icons/spell",
            soundPath = "Sfx/steamsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredInt = 10,
            weaponType = WeaponType.Spell,
            elementType = ElementType.Air,
            damageType = DamageType.Magical,
            statMod = StatModifier.Intelligence,
            apc = 1,
            isDot = true,
            minDamage = 12,
            maxDamage = 22,
            isNegating = true
        };
        weaponList.Add(weapon);

        // Create rifle
        weapon = new Weapon
        {
            itemId = 993004,
            name = "Super Soaker",
            flavorText = "Where does the water come from?",
            spritePath = "Icons/rifle",
            soundPath = "Sfx/watergunsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredStr = 10,
            weaponType = WeaponType.Gun,
            elementType = ElementType.Water,
            damageType = DamageType.Magical,
            statMod = StatModifier.Strength,
            apc = 1,
            minDamage = 18,
            maxDamage = 33
        };
        weaponList.Add(weapon);

        // Create ice dagger weapon
        weapon = new Weapon
        {
            itemId = 993005,
            name = "Frozen Shard of Blastoise-water",
            spritePath = "Icons/dagger",
            soundPath = "Sfx/stabsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 1,
            weaponType = WeaponType.Dagger,
            elementType = ElementType.Ice,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 5,
            maxDamage = 18,
            magicPen = 15,
            isNegating = true
        };
        weaponList.Add(weapon);

        // Create claw
        weapon = new Weapon
        {
            itemId = 993006,
            name = "Steam Claws",
            spritePath = "Icons/claws",
            soundPath = "Sfx/clawsfx",
            rarity = Rarity.Legendary,
            buyValue = 100000,
            sellValue = 100,
            requiredLevel = 5,
            requiredDex = 10,
            weaponType = WeaponType.Claw,
            elementType = ElementType.Air,
            damageType = DamageType.Magical,
            statMod = StatModifier.Dexterity,
            apc = 2,
            minDamage = 5,
            maxDamage = 13,
            critChance = 10,
            critDamage = 50
        };
        weaponList.Add(weapon);

        return weaponList;
    }


}

