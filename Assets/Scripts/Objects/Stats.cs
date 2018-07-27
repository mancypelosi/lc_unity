using System;

// Abstract class to store all the stats for Player, Item, and Modifier
[Serializable]
public abstract class Stats {

    // Stats
    public int strength = 0;
    public int dexterity = 0;
    public int intelligence = 0;
    public int armorPen = 0;
    public int magicPen = 0;
    public int critChance = 0;
    public double critDamage = 0;
    public double bonusPhysical = 0;
    public double bonusMagical = 0;

    // Currency
    public int itemFind = 0;
    public int magicFind = 0;
    public double bonusGold = 0;
    public double bonusExp = 0;

}
