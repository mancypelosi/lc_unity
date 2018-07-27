using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class Item : Stats
{

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Set
    }

    // Properties
    public int itemId = 0;
    public string name = "Garbage";
    public string spritePath = "Icons/garbage";
    public Rarity rarity = Rarity.Common;
    public string flavorText = "";
    public int buyValue = 0;
    public int sellValue = 0;
    public int requiredStr = 0;
    public int requiredDex = 0;
    public int requiredInt = 0;
    public int requiredLevel = 0;
    public List<Modifier> modList = new List<Modifier>();

    // Get Tooltip (abstract)
    public abstract string GetToolTip();

    // Get the color of the item by the item's rarity
    public Color GetRarityColor()
    {
        Color color = Color.black;
        if (rarity == Rarity.Common)
            color = Color.black;
        else if (rarity == Rarity.Uncommon)
            color = Color.green;
        else if (rarity == Rarity.Rare)
            color = Color.blue;
        else if (rarity == Rarity.Epic)
            color = Color.magenta;
        else if (rarity == Rarity.Legendary)
            color = Color.red;
        else if (rarity == Rarity.Set)
            color = Color.yellow;
        return color;
    }

    // Increment rarity of the item one level higher
    private Rarity IncrementRarity(Rarity rarity)
    {
        //Debug.Log("rarity: " + rarity);
        // Upgrade rarity if it's not legendary or set rarity
        if (rarity != Rarity.Legendary && rarity != Rarity.Set)
        {
            // Get rarity index
            int rarityIndex = (int)rarity;
            // Increment to next rarity
            rarityIndex++;
            return (Rarity)rarityIndex;
        }
        else
            return rarity;
    }

    // Decrement rarity of the item one level lower
    private Rarity DecrementRarity(Rarity rarity)
    {
        //Debug.Log("rarity: " + rarity);
        // Upgrade rarity if it's not legendary or set rarity
        if (rarity != Rarity.Legendary && rarity != Rarity.Set)
        {
            // Get rarity index
            int rarityIndex = (int)rarity;
            // Increment to next rarity
            rarityIndex--;
            return (Rarity)rarityIndex;
        }
        else
            return rarity;
    }

    // Add modifier to item, randomize the values
    public Item AddModifier(Modifier mod)
    {
        // Update name
        if (mod.type == Modifier.ModifierType.Prefix)
            name = mod.name + " " + name;
        else if (mod.type == Modifier.ModifierType.Suffix)
            name = name + " " + mod.name;

        // Stats
        strength += Convert.ToInt32(UnityEngine.Random.Range(.2f, 1f) * mod.strength);
        dexterity += Convert.ToInt32(UnityEngine.Random.Range(.2f, 1f) * mod.dexterity);
        intelligence += Convert.ToInt32(UnityEngine.Random.Range(.2f, 1f) * mod.intelligence);
        armorPen += Convert.ToInt32(UnityEngine.Random.Range(.2f, 1f) * mod.armorPen);
        magicPen += Convert.ToInt32(UnityEngine.Random.Range(.2f, 1f) * mod.magicPen);
        critChance += Convert.ToInt32(UnityEngine.Random.Range(.2f, 1f) * mod.critChance);
        critDamage += Math.Round(UnityEngine.Random.Range(.2f, 1f) * mod.critDamage);
        bonusPhysical += Math.Round(UnityEngine.Random.Range(.2f, 1f) * mod.bonusPhysical);
        bonusMagical += Math.Round(UnityEngine.Random.Range(.2f, 1f) * mod.bonusMagical);

        itemFind += Convert.ToInt32(UnityEngine.Random.Range(.2f, 1f) * mod.itemFind);
        magicFind += Convert.ToInt32(UnityEngine.Random.Range(.2f, 1f) * mod.magicFind);
        bonusGold += Math.Round(UnityEngine.Random.Range(.2f, 1f) * mod.bonusGold);
        bonusExp += Math.Round(UnityEngine.Random.Range(.2f, 1f) * mod.bonusExp);

        buyValue += mod.buyValue;
        sellValue += mod.sellValue;

        // Add mod to item modList
        modList.Add(mod);
        // Upgrade rarity
        rarity = IncrementRarity(rarity);
        // Return item
        return this;
    }

    // Remove mod
    public Item RemoveModifier(Modifier mod)
    {
        // Update name
        if (mod.type == Modifier.ModifierType.Prefix)
            name = name.Remove(0, mod.name.Length);
        else if (mod.type == Modifier.ModifierType.Suffix)
            name = name.Substring(0, name.Length - mod.name.Length);

        // Stats
        strength -= mod.strength;
        dexterity -= mod.dexterity;
        intelligence -= mod.intelligence;
        armorPen -= mod.armorPen;
        magicPen -= mod.magicPen;
        critChance -= mod.critChance;
        critDamage -= mod.critDamage;
        bonusPhysical -= mod.bonusPhysical;
        bonusMagical -= mod.bonusMagical;

        buyValue -= mod.buyValue;
        sellValue -= mod.sellValue;
        itemFind -= mod.itemFind;
        magicFind -= mod.magicFind;
        bonusGold -= mod.bonusGold;
        bonusExp -= mod.bonusExp;

        // Remove mod from item modList
        modList.Remove(mod);
        // Upgrade rarity
        rarity = DecrementRarity(rarity);
        // Return item
        return this;
    }

}
