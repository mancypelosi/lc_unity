using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewCharacter : MonoBehaviour
{

    private readonly Weapon weapon = new Weapon();
    private readonly Armor armor = new Armor();
    private Player player;

    // Use this for initialization
    void Start()
    {
        player = GameManager.gm.player;
    }

    // Warrior select
    public void CreateWarrior(InputField inputName)
    {
        Debug.Log("Warrior selected");
        // Create warrior player
        string name = inputName.text;
        if (name == "")
            name = "Hero";
        // Base character
        player.playerName = name;
        player.playerClass = "Warrior";
        player.strength = 10;
        player.dexterity = 1;
        player.intelligence = 1;
        player.critChance = 10;
        player.critDamage = 150;
        player.bonusPhysical = 100;
        player.bonusMagical = 100;
        player.itemFind = 10;
        player.magicFind = 10;
        player.bonusGold = 100;
        player.bonusExp = 100;
        // Equip weapons
        player.weapon1 = (Weapon)player.Equip(weapon.GetWeaponById(weapon.WeaponList(), 00101));
        player.weapon2 = (Weapon)player.Equip(new Weapon());
        player.weapon3 = (Weapon)player.Equip(new Weapon());
        player.equippedWeapon = player.weapon1;
        // Equip armor
        player.head = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0001));
        player.chest = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0002));
        player.gloves = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0003));
        player.legs = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0004));
        player.boots = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0005));
        // Inventory
        //Modifier mod = new Modifier();
        //player.inventory.Add(weapon.GetWeaponById(weapon.WeaponList(), 00101).AddModifier(mod.GetModifierById(mod.PrefixList(), 1102)));
        //player.inventory.Add(weapon.GetWeaponById(weapon.WeaponList(), 19303));
        player.inventory.Add(weapon.GetWeaponById(weapon.WeaponList(), 5));

        // Load Main scene
        GameManager.gm.LoadScene("Town");
    }

    // Rogue select
    public void CreateRogue(InputField inputName)
    {
        Debug.Log("Rogue selected");
        // Create rogue player
        string name = inputName.text;
        if (name == "")
            name = "Hero";
        player.playerName = name;
        player.playerClass = "Rogue";
        player.strength = 1;
        player.dexterity = 10;
        player.intelligence = 1;
        player.critChance = 10;
        player.critDamage = 150;
        player.bonusPhysical = 100;
        player.bonusMagical = 100;
        player.itemFind = 10;
        player.magicFind = 10;
        player.bonusGold = 100;
        player.bonusExp = 100;
        // Equip weapons
        player.weapon1 = (Weapon)player.Equip(weapon.GetWeaponById(weapon.WeaponList(), 00205));
        player.weapon2 = (Weapon)player.Equip(new Weapon());
        player.weapon3 = (Weapon)player.Equip(new Weapon());
        player.equippedWeapon = player.weapon1;
        // Equip armor
        player.head = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0001));
        player.chest = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0002));
        player.gloves = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0003));
        player.legs = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0004));
        player.boots = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0005));
        // Inventory

        // Load Main scene
        GameManager.gm.LoadScene("Town");
    }

    // Mage select
    public void CreateMage(InputField inputName)
    {
        Debug.Log("Mage selected");
        // Create mage player
        string name = inputName.text;
        if (name == "")
            name = "Hero";
        player.playerName = name;
        player.playerClass = "Mage";
        player.strength = 1;
        player.dexterity = 1;
        player.intelligence = 10;
        player.critChance = 10;
        player.critDamage = 150;
        player.bonusPhysical = 100;
        player.bonusMagical = 100;
        player.itemFind = 10;
        player.magicFind = 10;
        player.bonusGold = 100;
        player.bonusExp = 100;
        // Equip weapons
        player.weapon1 = (Weapon)player.Equip(weapon.GetWeaponById(weapon.WeaponList(), 00309));
        player.weapon2 = (Weapon)player.Equip(new Weapon());
        player.weapon3 = (Weapon)player.Equip(new Weapon());
        player.equippedWeapon = player.weapon1;
        // Equip armor
        player.head = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0001));
        player.chest = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0002));
        player.gloves = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0003));
        player.legs = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0004));
        player.boots = (Armor)player.Equip(armor.GetArmorById(armor.ArmorList(), 0005));
        // Inventory

        // Load Main scene
        GameManager.gm.LoadScene("Town");
    }
}
