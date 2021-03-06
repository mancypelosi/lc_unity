﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Battle : MonoBehaviour
{

    public GameObject floatingTextPrefab;
    public GameObject ItemPanel;
    private Player player;
    private Enemy enemy;
    private World world;
    private bool timer = false;
    private float time = 15;
    private List<Damage> dotTimers = new List<Damage>();
    private List<Damage> deadTimers = new List<Damage>();

    // Use this for initialization
    void Start()
    {

        // Set GameManger properties
        player = GameManager.gm.player;
        enemy = GameManager.gm.enemy;
        world = GameManager.gm.world;

        // Play music
        SoundManager.sm.PlayMusic(Resources.Load<AudioClip>(world.soundPath));

        // World info
        GameObject.Find("WorldLabel").GetComponent<Text>().text = "World: " + world.worldName;
        GameObject.Find("StageLabel").GetComponent<Text>().text = "Stage: " + world.currentStage.ToString();
        GameObject.Find("Background").GetComponent<Image>().sprite = Resources.Load<Sprite>(world.backgroundPath);

        // Instnatiate Enemy
        int listCount = world.enemyList.Count;
        int rng = UnityEngine.Random.Range(0, listCount);
        int id = world.enemyList[rng].enemyId;
        enemy = enemy.GetEnemyById(enemy.EnemyList(), id).Scale(world);

        // Enemy Info
        GameObject.Find("EnemyNameLabel").GetComponent<Text>().text = enemy.enemyName;
        GameObject.Find("EnemyImage").GetComponent<Image>().sprite = Resources.Load<Sprite>(enemy.spritePath);
        GameObject.Find("EnemyHealthLabel").GetComponent<Text>().text = "HP: " + enemy.health.ToString();
        GameObject.Find("EnemyHealthBar").GetComponent<Slider>().maxValue = enemy.health;
        GameObject.Find("EnemyHealthBar").GetComponent<Slider>().value = enemy.health;
        GameObject.Find("EnemyArmor").GetComponent<Text>().text = "A: " + enemy.armor + " MR: " + enemy.magicResist;
        GameObject.Find("EnemyResists").GetComponent<Text>().text = "W: " + string.Join(",", enemy.weaknesses.ToArray()) + Environment.NewLine + "R: " + string.Join(",", enemy.resistances.ToArray());

        // Weapon Buttons
        GameObject.Find("Slot1Button").GetComponentInChildren<Text>().text = player.weapon1.name;
        GameObject.Find("Slot1Button").GetComponentInChildren<Text>().color = player.weapon1.GetRarityColor();
        GameObject.Find("Slot2Button").GetComponentInChildren<Text>().text = player.weapon2.name;
        GameObject.Find("Slot2Button").GetComponentInChildren<Text>().color = player.weapon2.GetRarityColor();
        GameObject.Find("Slot3Button").GetComponentInChildren<Text>().text = player.weapon3.name;
        GameObject.Find("Slot3Button").GetComponentInChildren<Text>().color = player.weapon3.GetRarityColor();
        if (player.equippedWeapon.name == GameObject.Find("Slot1Button").GetComponentInChildren<Text>().text)
            GameObject.Find("Slot1Button").GetComponentInChildren<Outline>().effectColor = Color.white;
        else if (player.equippedWeapon.name == GameObject.Find("Slot2Button").GetComponentInChildren<Text>().text)
            GameObject.Find("Slot2Button").GetComponentInChildren<Outline>().effectColor = Color.white;
        else if (player.equippedWeapon.name == GameObject.Find("Slot3Button").GetComponentInChildren<Text>().text)
            GameObject.Find("Slot3Button").GetComponentInChildren<Outline>().effectColor = Color.white;

    }

    // Update is called once per frame
    void Update()
    {
        // Keybinds
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            EquipWeapon1();
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            EquipWeapon2();
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            EquipWeapon3();
        if (Input.GetKeyDown(KeyCode.T))
            GoToTown();
        if (Input.GetKeyDown(KeyCode.L))
            LevelUp();
        if (Input.GetKeyDown(KeyCode.I))
            SpawnItem();

        // Timers
        BossTimer();
        DotDamage();

        // Check if enemy dies
        if (enemy.health <= 0)
        {
            // DoT's do not persist across enemies
            dotTimers.Clear();
            EnemyKilled();
        }

        // Check for level up
        if (player.xpTNL <= 0)
            LevelUp();

    }

    // Whenever player clicks the enemy
    private void ClickDamage()
    {
        // Instantiate new damage object
        Damage damage = new Damage();

        // Trigger sound fx
        SoundManager.sm.PlaySoundFX(Resources.Load<AudioClip>(player.equippedWeapon.soundPath), damage.weak, damage.resist, damage.crit);

        // Deal an instance of damage for number of apc's the weapon has
        for (int i = 0; i < player.equippedWeapon.apc; i++)
        {
            // Calculate daamge
            damage.Calculate(player, enemy);

            // Trigger floating text
            ShowDamageText(damage);

            // Apply damage to enemy
            enemy.health -= damage.value;
            GameObject.Find("EnemyHealthLabel").GetComponent<Text>().text = "HP: " + enemy.health.ToString();
            GameObject.Find("EnemyHealthBar").GetComponent<Slider>().value = enemy.health;
        }

        // DoT check
        if (player.equippedWeapon.isDot)
        {
            damage.value = damage.value / 2;
            damage.weak = false;
            damage.resist = false;
            damage.crit = false;
            damage.dot = true;
            damage.dotTimer = 3.1f;
            dotTimers.Add(damage);
        }

        // Sunder check
        int sunderValue = 1;
        if (player.equippedWeapon.isSundering)
        {
            if (enemy.armor - sunderValue >= 0)
                enemy.armor -= sunderValue;
            else
                enemy.armor = 0;
        }

        // Negate check
        int negateValue = 1;
        if (player.equippedWeapon.isNegating)
        {
            if (enemy.magicResist - negateValue > 0)
                enemy.magicResist -= negateValue;
            else
                enemy.magicResist = 0;
        }
    }

    private void DotDamage()
    {
        // DoT Damage Test
        if (dotTimers.Count > 0)
        {
            foreach (Damage dot in dotTimers)
            {
                //float seconds = dot.dotTimer % 60;//Use the euclidean division for the seconds.
                float fraction = (dot.dotTimer * 100) % 100;
                //GameObject.Find("BossTimer").GetComponent<Text>().text = string.Format("{0:00} : {1:00}", seconds, fraction);
                if (Int32.Parse(fraction.ToString().Substring(0, 1)) % 10 == 0)
                {
                    //Debug.Log("Dot damage");
                    // Trigger floating text
                    ShowDamageText(dot);

                    // Apply damage to enemy
                    enemy.health -= dot.value;
                    GameObject.Find("EnemyHealthLabel").GetComponent<Text>().text = "HP: " + enemy.health.ToString();
                    GameObject.Find("EnemyHealthBar").GetComponent<Slider>().value = enemy.health;

                }
                dot.dotTimer -= Time.deltaTime;
                if (dot.dotTimer < 0)
                    deadTimers.Add(dot);
            }
        }

        if (deadTimers.Count > 0) { 
            foreach (Damage deadDot in deadTimers)
                dotTimers.Remove(deadDot);
            deadTimers.Clear();
        }
    }

    // Show floating numbers on screen
    private void ShowDamageText(Damage damage)
    {
        // Create location for floating text
        Vector3 location = GameObject.Find("EnemyPanel").transform.position;
        //Vector3 offset = new Vector3(UnityEngine.Random.Range(-100, 100), 100, 0); 
        Vector3 offset = new Vector3(UnityEngine.Random.Range(-100, 100), UnityEngine.Random.Range(75, 110), 0);
        if (damage.dot)
            offset = new Vector3(UnityEngine.Random.Range(-100, 100), UnityEngine.Random.Range(100, 120), 0);
        // Instantiate floatingText
        GameObject floatingText = Instantiate(floatingTextPrefab, location + offset, Quaternion.identity, transform);
        floatingText.transform.SetParent(GameObject.Find("EnemyPanel").transform);

        // Change text if resistance
        if (damage.resist)
        {
            floatingText.GetComponentInChildren<Outline>().effectColor = Color.cyan;
            floatingText.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
            floatingText.GetComponentInChildren<Text>().fontSize = 40;
        }

        // Change text if weakness
        if (damage.weak)
        {
            floatingText.GetComponentInChildren<Outline>().effectColor = Color.magenta;
            floatingText.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
            floatingText.GetComponentInChildren<Text>().fontSize = 40;
        }

        // Change text if critical strike
        if (damage.crit)
        {
            floatingText.GetComponentInChildren<Outline>().effectColor = Color.yellow;
            floatingText.GetComponentInChildren<Text>().fontStyle = FontStyle.Bold;
            floatingText.GetComponentInChildren<Text>().fontSize = 40;
        }

        if (damage.dot)
        {
            floatingText.GetComponentInChildren<Outline>().effectColor = Color.gray;
            floatingText.GetComponentInChildren<Text>().fontStyle = FontStyle.Italic;
            floatingText.GetComponentInChildren<Text>().fontSize = 28;
        }

        // Set text of floating text to damage
        floatingText.GetComponentInChildren<Text>().text = damage.value.ToString();
    }

    // Information to update when an enemy is killed
    private void EnemyKilled()
    {
        // Update player with killed enemy values
        player.xpTNL -= Convert.ToInt32(enemy.xpToGive * (player.bonusExp / 100));
        GameObject.Find("TNL").GetComponentInChildren<Text>().text = "XP TNL: " + player.xpTNL.ToString();
        player.playerGold += Convert.ToInt32(enemy.goldToGive * (player.bonusGold / 100));
        GameObject.Find("Gold").GetComponentInChildren<Text>().text = "Gold: " + player.playerGold.ToString();
        // Increment the stage
        GameManager.gm.world.currentStage++;
        GameObject.Find("StageLabel").GetComponentInChildren<Text>().text = "Stage: " + GameManager.gm.world.currentStage.ToString();

        // Check player drop chance for item spawn
        if (UnityEngine.Random.Range(0, 100) < player.itemFind)
            SpawnItem();

        // Spawn new enemy
        if (world.currentStage == 50)
            enemy = world.miniBoss.Scale(world);
        else if (world.currentStage == 100)
        {
            enemy = world.boss.Scale(world);
            timer = true;
        }
        else
        {
            int listCount = world.enemyList.Count;
            int rng = UnityEngine.Random.Range(0, listCount);
            int id = world.enemyList[rng].enemyId;
            enemy = enemy.GetEnemyById(enemy.EnemyList(), id).Scale(world);
        }

        // If boss is beat go to town
        if (world.currentStage == 101)
        {
            Transform[] transform = GameObject.Find("Canvas").GetComponentsInChildren<Transform>(true);
            foreach (Transform t in transform)
            {
                if (t.name == "CompletePanel")
                {
                    // Stop the timer
                    timer = false;

                    // Update next world gate for player
                    if (world.worldName == "Forest")
                        player.world2 = true;
                    if (world.worldName == "Cave")
                        player.world3 = true;
                    if (world.worldName == "River")
                        player.world4 = true;
                    
                    // Stop music and play the victory sound!
                    SoundManager.sm.StopMusic();
                    SoundManager.sm.PlaySoundFX(Resources.Load<AudioClip>("Sfx/finalfantasy"));
                    // Set overlay to active
                    t.gameObject.SetActive(true);
                }
            }
        }

        // Update Enemy Info
        GameObject.Find("EnemyNameLabel").GetComponentInChildren<Text>().text = enemy.enemyName;
        GameObject.Find("EnemyImage").GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(enemy.spritePath);
        GameObject.Find("EnemyHealthLabel").GetComponentInChildren<Text>().text = "HP: " + enemy.health.ToString();
        GameObject.Find("EnemyHealthBar").GetComponent<Slider>().maxValue = enemy.health;
        GameObject.Find("EnemyHealthBar").GetComponent<Slider>().value = enemy.health;
        GameObject.Find("EnemyArmor").GetComponent<Text>().text = "A: " + enemy.armor + " MR: " + enemy.magicResist;
        GameObject.Find("EnemyResists").GetComponent<Text>().text = "W: " + string.Join(",", enemy.weaknesses.ToArray()) + Environment.NewLine + "R: " + string.Join(",", enemy.resistances.ToArray());
    }

    // Level Up!
    public void LevelUp()
    {
        // Player level up
        player.LevelUp();
        // Update the gui
        GameObject.Find("Level").GetComponentInChildren<Text>().text = "Level: " + player.playerLevel.ToString();
        GameObject.Find("TNL").GetComponentInChildren<Text>().text = "XP TNL: " + player.xpTNL.ToString();
        GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints;
    }

    // Spawn an item and rng check to add magical properties
    public void SpawnItem()
    {
        //Debug.Log("Spawn item");
        Item item = null;
        Modifier mod = new Modifier();
        int type = UnityEngine.Random.Range(0, 2);
        // Create weapon
        if (type == 0)
        {
            Weapon weapon = new Weapon();
            int listCount = world.weaponList.Count;
            int rng = UnityEngine.Random.Range(0, listCount);
            int id = world.weaponList[rng].itemId;
            item = weapon.GetWeaponById(weapon.WeaponList(), id);
        }
        // Create armor
        else if (type == 1)
        {
            Armor armor = new Armor();
            int listCount = world.armorList.Count;
            int rng = UnityEngine.Random.Range(0, listCount);
            int id = world.armorList[rng].itemId;
            item = armor.GetArmorById(armor.ArmorList(), id);
        }

        // Check to add prefix
        if (UnityEngine.Random.Range(0, 100) < player.magicFind)
        {
            int listCount = world.prefixList.Count;
            int rng = UnityEngine.Random.Range(0, listCount);
            int id = world.prefixList[rng].modId;
            item.AddModifier(mod.GetModifierById(mod.PrefixList(), id));
        }

        // Check to add suffix
        if (UnityEngine.Random.Range(0, 100) < player.magicFind)
        {
            int listCount = world.suffixList.Count;
            int rng = UnityEngine.Random.Range(0, listCount);
            int id = world.suffixList[rng].modId;
            item.AddModifier(mod.GetModifierById(mod.SuffixList(), id));
        }

        // Add item to inventory
        if (player.inventory.Count < 15)
            player.inventory.Add(item);
        else
            SoundManager.sm.PlaySoundFX(Resources.Load<AudioClip>("Sfx/dropsfx"));

        // Update Inventory (Set item border color to match rarity)
        for (int i = 0; i < player.inventory.Count; i++)
        {
            GameObject.Find("Item" + i).GetComponent<ItemPanel>().item = player.inventory[i];
            GameObject.Find("Item" + i).GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(player.inventory[i].spritePath);
            GameObject.Find("ItemPanel" + i).GetComponentInChildren<Outline>().effectColor = player.inventory[i].GetRarityColor();
        }
    }

    // Create a timer that starts when the boss spawns 
    // If the player is unable to kill the boss in time they fail the stage
    private void BossTimer()
    {
        if (timer)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                timer = false;
                // Have to traverse through Canvas to get disabled UI elements
                Transform[] transform = GameObject.Find("Canvas").GetComponentsInChildren<Transform>(true);
                foreach (Transform t in transform)
                {
                    if (t.name == "CompletePanel")
                    {
                        SoundManager.sm.StopMusic();
                        SoundManager.sm.PlaySoundFX(Resources.Load<AudioClip>("Sfx/failsfx"));
                        t.gameObject.SetActive(true);
                        GameObject.Find("CompleteText").GetComponent<Text>().text = "YOU FAILED";
                    }
                }
            }
            float seconds = time % 60;//Use the euclidean division for the seconds.
            float fraction = (time * 100) % 100;
            // Update the label value
            GameObject.Find("BossTimer").GetComponent<Text>().text = string.Format("{0:00} : {1:00}", seconds, fraction);
        }
    }

    // Equip player weapon1
    private void EquipWeapon1()
    {
        player.SetEquippedWeapon(player.weapon1);
        // Update outline
        GameObject.Find("Slot1Button").GetComponentInChildren<Outline>().effectColor = Color.white;
        GameObject.Find("Slot2Button").GetComponentInChildren<Outline>().effectColor = Color.black;
        GameObject.Find("Slot3Button").GetComponentInChildren<Outline>().effectColor = Color.black;
        Debug.Log(player.equippedWeapon.name + " equipped!");
    }

    // Equip player weapon2
    private void EquipWeapon2()
    {
        player.SetEquippedWeapon(player.weapon2);
        // Update outline
        GameObject.Find("Slot1Button").GetComponentInChildren<Outline>().effectColor = Color.black;
        GameObject.Find("Slot2Button").GetComponentInChildren<Outline>().effectColor = Color.white;
        GameObject.Find("Slot3Button").GetComponentInChildren<Outline>().effectColor = Color.black;
        Debug.Log(player.equippedWeapon.name + " equipped!");
    }

    // Equip player weapon3
    private void EquipWeapon3()
    {
        player.SetEquippedWeapon(player.weapon3);
        // Update outline
        GameObject.Find("Slot1Button").GetComponentInChildren<Outline>().effectColor = Color.black;
        GameObject.Find("Slot2Button").GetComponentInChildren<Outline>().effectColor = Color.black;
        GameObject.Find("Slot3Button").GetComponentInChildren<Outline>().effectColor = Color.white;
        Debug.Log(player.equippedWeapon.name + " equipped!");
    }

    // Load Town scene
    private void GoToTown()
    {
        SoundManager.sm.StopMusic();
        SceneManager.LoadScene("Town");
    }

}
