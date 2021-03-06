﻿using System;
using System.Collections.Generic;
using UnityEngine;

public class World {

    public string worldName;
    public int currentStage = 1;
    public string backgroundPath;
    public string soundPath;
    public List<Enemy> enemyList;
    public Enemy miniBoss;
    public Enemy boss;
    public List<Weapon> weaponList;
    public List<Armor> armorList;
    public List<Modifier> prefixList;
    public List<Modifier> suffixList;

    // Get World by name from list
    public World GetWorldByName(List<World> list, string name)
    {
        World w = new World();
        if ((list.Find(world => world.worldName == name) != null))
        {
            w = list.Find(world => world.worldName == name);
        }
        return w;
    }

    // List of all worlds
    public List<World> WorldList()
    {
        List<World> worldList = new List<World>();
        // Instantiate
        Enemy enemy = new Enemy();
        Weapon weapon = new Weapon();
        Armor armor = new Armor();
        Modifier mod = new Modifier();
        // Shortcut lists
        List<Enemy> el = enemy.EnemyList();
        List<Weapon> wl = weapon.WeaponList();
        List<Armor> al = armor.ArmorList();
        List<Modifier> pl = mod.PrefixList();
        List<Modifier> sl = mod.SuffixList();

        World world;

        // Create Forest
        world = new World
        {
            worldName = "Forest",
            backgroundPath = "Background/forest1",
            soundPath = "Music/forestmusic",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 001), enemy.GetEnemyById(el, 010), enemy.GetEnemyById(el, 011), enemy.GetEnemyById(el, 012),
            enemy.GetEnemyById(el, 013), enemy.GetEnemyById(el, 014), enemy.GetEnemyById(el, 016), enemy.GetEnemyById(el, 017)},
            miniBoss = enemy.GetEnemyById(el, 002),
            boss = enemy.GetEnemyById(el, 003),
            weaponList = weapon.GetListByTier(wl, 1),
            armorList = al,
            prefixList = pl,
            suffixList = sl

        };
        worldList.Add(world);

        // Create Cave
        world = new World
        {
            worldName = "Cave",
            backgroundPath = "Background/cave1",
            soundPath = "Music/cavemusic",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 004), enemy.GetEnemyById(el, 050), enemy.GetEnemyById(el, 051), enemy.GetEnemyById(el, 041),
            enemy.GetEnemyById(el, 042), enemy.GetEnemyById(el, 027), enemy.GetEnemyById(el, 028)},
            miniBoss = enemy.GetEnemyById(el, 005),
            boss = enemy.GetEnemyById(el, 006),
            weaponList = weapon.GetListByTier(wl, 1),
            armorList = armor.ArmorList(),
            prefixList = mod.PrefixList(),
            suffixList = mod.SuffixList()

        };
        worldList.Add(world);

        // Create River
        world = new World
        {
            worldName = "River",
            backgroundPath = "Background/river",
            soundPath = "Music/rivermusic",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 007), enemy.GetEnemyById(el, 019), enemy.GetEnemyById(el, 020), enemy.GetEnemyById(el, 021),
            enemy.GetEnemyById(el, 022), enemy.GetEnemyById(el, 014), enemy.GetEnemyById(el, 025), enemy.GetEnemyById(el, 026)},
            miniBoss = enemy.GetEnemyById(el, 008),
            boss = enemy.GetEnemyById(el, 009),
            weaponList = weapon.GetListByTier(wl, 2),
            armorList = armor.ArmorList(),
            prefixList = mod.PrefixList(),
            suffixList = mod.SuffixList()

        };
        worldList.Add(world);

        // Create Swamp
        world = new World
        {
            worldName = "Swamp",
            backgroundPath = "Background/forest2",
            soundPath = "Music/swampmusic",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 043), enemy.GetEnemyById(el, 046), enemy.GetEnemyById(el, 047), enemy.GetEnemyById(el, 048),
            enemy.GetEnemyById(el, 049), enemy.GetEnemyById(el, 023), enemy.GetEnemyById(el, 024)},
            miniBoss = enemy.GetEnemyById(el, 044),
            boss = enemy.GetEnemyById(el, 045),
            weaponList = weapon.GetListByTier(wl, 2),
            armorList = armor.ArmorList(),
            prefixList = mod.PrefixList(),
            suffixList = mod.SuffixList()

        };
        worldList.Add(world);

        return worldList;
    }

}


