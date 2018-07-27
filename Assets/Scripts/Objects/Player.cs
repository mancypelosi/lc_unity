using System.Collections.Generic;
using System;

[Serializable]
public class Player : Stats {

    // Properties
    public string playerName = "Hero";
    public string playerClass = "None";
    public string spritePath = "charmander";
    public int playerLevel = 1;
    public int currentXP = 0;
    public int xpTNL = 50;
    public int talentPoints = 0;
    public int playerGold = 0;

    // World Gates
    public bool world1 = true;
    public bool world2 = false;
    public bool world3 = false;
    public bool world4 = false;

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
    public List<Item> stash = new List<Item>();

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

        return item;
    }

    // Set Equipped Weapon
    public void SetEquippedWeapon(Weapon weapon)
    {
        equippedWeapon = weapon;
    }

    // Level player up
    public void LevelUp()
    {
        // Give player talent point
        playerLevel++;
        talentPoints++;
        // Reset xp tnl
        xpTNL = playerLevel * 50;
    }

}
