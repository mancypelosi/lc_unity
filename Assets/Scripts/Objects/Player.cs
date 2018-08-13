using System.Collections.Generic;
using System;

[Serializable]
public class Player : Stats {

    // Properties
    public string name = "Hero";
    public string playerClass = "None";
    public string spritePath = "charmander";
    public int level = 1;
    public int currentXP = 0;
    public int xpTNL = 50;
    public int talentPoints = 0;
    public int gold = 0;
    public int comboCount = 0;

    public int modifiedStrength = 0;
    public int modifiedDexterity = 0;
    public int modifiedIntelligence = 0;

    // World Gates
    public bool world1 = true;
    public bool world2 = false;
    public bool world3 = false;
    public bool world4 = false;
    public bool world5 = false;
    public bool world6 = false;
    public bool world7 = false;
    public bool world8 = false;

    // Weapons
    public Weapon equippedWeapon = new Weapon();
    public Weapon weapon1 = new Weapon();
    public Weapon weapon2 = new Weapon();
    public Weapon weapon3 = new Weapon();

    // Armor
    public Armor head = null;
    public Armor chest = null;
    public Armor legs = null;
    public Armor gloves = null;
    public Armor boots = null;
    public Armor amulet = null;

    // Inventory
    public List<Item> inventory = new List<Item>();

    // Add item stats to player stats
    public Item Equip(Item item)
    {
        // Add stats to player
        strength += item.strength;
        dexterity += item.dexterity;
        intelligence += item.intelligence;
        armorPen += item.armorPen;
        magicPen += item.magicPen;
        critChance += item.critChance;
        critDamage += item.critDamage;
        bonusPhysical += item.bonusPhysical;
        bonusMagical += item.bonusMagical;
        itemFind += item.itemFind;
        magicFind += item.magicFind;
        bonusGold += item.bonusGold;
        bonusExp += item.bonusExp;

        modifiedStrength += item.strength;
        modifiedDexterity += item.dexterity;
        modifiedIntelligence += item.intelligence;

        return item;
    }

    // Remove item stats from player stats
    public Item Unequip(Item item)
    {
        // Remove stats from player
        strength -= item.strength;
        dexterity -= item.dexterity;
        intelligence -= item.intelligence;
        armorPen -= item.armorPen;
        magicPen -= item.magicPen;
        critChance -= item.critChance;
        critDamage -= item.critDamage;
        bonusPhysical -= item.bonusPhysical;
        bonusMagical -= item.bonusMagical;
        itemFind -= item.itemFind;
        magicFind -= item.magicFind;
        bonusGold -= item.bonusGold;
        bonusExp -= item.bonusExp;

        modifiedStrength -= item.strength;
        modifiedDexterity -= item.dexterity;
        modifiedIntelligence -= item.intelligence;

        return item;
    }

    // Set Equipped Weapon
    public void SetEquippedWeapon(Weapon weapon)
    {
        this.Unequip(equippedWeapon);
        equippedWeapon = weapon;
        this.Equip(equippedWeapon);
    }

    // Level player up
    public void LevelUp()
    {
        // Give player talent point
        level++;
        talentPoints++;
        // Reset xp tnl
        xpTNL = level * 50;
    }

    // Get base stat value 
    public int GetBaseStat(int total, int modified)
    {
        return total - modified;
    }

}
