using System;
using UnityEngine;

public class Damage {

    public int value = 0;
    public bool weak = false;
    public bool resist = false;
    public bool crit = false;
    public bool dot = false;
    public float dotTimer = 0;

    public void Calculate(Player player, Enemy enemy)
    {
        // Start damage with rng value of equipped weapon min-max damage
        double damage = UnityEngine.Random.Range(player.equippedWeapon.minDamage, player.equippedWeapon.maxDamage);
        //Debug.Log("Weapon damage: " + damage);

        // Attribute modifiers
        if (player.equippedWeapon.statMod.ToString() == "Strength")
            damage = damage * (1 + (.01 * player.strength));
        else if (player.equippedWeapon.statMod.ToString() == "Dexterity")
            damage = damage * (1 + (.01 * player.dexterity));
        else if (player.equippedWeapon.statMod.ToString() == "Intelligence")
            damage = damage * (1 + (.01 * player.intelligence));
        //Debug.Log("Stat mod damage: " + damage);

        // Check if physical weapon for armor calc
        if (player.equippedWeapon.damageType == Weapon.DamageType.Physical)
        {
            //Debug.Log("Physical attack");
            int armorCalc = enemy.armor - player.armorPen > 0 ? (enemy.armor - player.armorPen) : 0;
            damage = damage * 100 / (armorCalc + 100);
            damage = damage * (player.bonusPhysical / 100);
        }
        // Check if magical weapon for magic resist calc
        if (player.equippedWeapon.damageType == Weapon.DamageType.Magical)
        {
            //Debug.Log("Magical attack");
            int magicCalc = enemy.magicResist - player.magicPen > 0 ? (enemy.magicResist - player.magicPen) : 0;
            damage = damage * 100 / (magicCalc + 100);
            damage = damage * (player.bonusMagical / 100);
        }
        //Debug.Log("Phys/Mag damage : " + damage);

        // Check for resistances
        if (enemy.resistances.Contains(player.equippedWeapon.weaponType.ToString()))
        {
            resist = true;
            damage = damage * 0.75;     
        }
        if (enemy.resistances.Contains(player.equippedWeapon.elementType.ToString()))
        {
            resist = true;
            damage = damage * 0.75;
        }
        //Debug.Log("Resist damage : " + damage);

        // Check for weaknesses
        if (enemy.weaknesses.Contains(player.equippedWeapon.weaponType.ToString()))
        {
            weak = true;
            if (!resist)
                damage = damage * 1.25;
            else
            {
                damage = damage * 1.33;
                weak = false;
                resist = false;
            }
        }
        if (enemy.weaknesses.Contains(player.equippedWeapon.elementType.ToString()))
        {
            weak = true;
            if (!resist)
                damage = damage * 1.25;
            else
            {
                damage = damage * 1.33;
                weak = false;
                resist = false;
            }
        }
        //Debug.Log("Weakness damage : " + damage);

        // If damage is 0 set it to at least 1 >.<
        if (damage <= 0)
            damage = 1;

        // Check for crit
        if (UnityEngine.Random.Range(0, 100) < player.critChance)
        {
            damage = damage * (player.critDamage / 100);
            crit = true;
        }
        //Debug.Log("Crit damage : " + damage);

        // Attacks per click applied to damage
        //damage = damage * player.equippedWeapon.apc;
        //Debug.Log("APC damage : " + damage);

        // Convert double to int
        value = Convert.ToInt32(damage);
    }
}
