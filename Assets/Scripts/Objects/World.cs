using System;
using System.Collections.Generic;
using UnityEngine;

public class World {

    public string worldName = "";
    public int enemyScaling = 1;
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

        // Create Plains
        world = new World
        {
            worldName = "Plains",
            enemyScaling = 1,
            backgroundPath = "Background/plains",
            soundPath = "Music/plains",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 153), enemy.GetEnemyById(el, 154), enemy.GetEnemyById(el, 155), enemy.GetEnemyById(el, 156),
            enemy.GetEnemyById(el, 157), enemy.GetEnemyById(el, 158), enemy.GetEnemyById(el, 159), enemy.GetEnemyById(el, 160), enemy.GetEnemyById(el, 161)},
            miniBoss = enemy.GetEnemyById(el, 162),
            boss = enemy.GetEnemyById(el, 163),
            weaponList = weapon.GetListByTier(wl, 01),
            armorList = armor.GetListByTier(al, 1),
            prefixList = mod.GetListByTier(pl, 1),
            suffixList = mod.GetListByTier(sl, 1)

        };
        worldList.Add(world);

        // Create Forest
        world = new World
        {
            worldName = "Forest",
            enemyScaling = 2,
            backgroundPath = "Background/forest1",
            soundPath = "Music/forestmusic",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 164), enemy.GetEnemyById(el, 165), enemy.GetEnemyById(el, 166), enemy.GetEnemyById(el, 167),
            enemy.GetEnemyById(el, 168), enemy.GetEnemyById(el, 169), enemy.GetEnemyById(el, 170), enemy.GetEnemyById(el, 171), enemy.GetEnemyById(el, 172)
            enemy.GetEnemyById(el, 173)},
            miniBoss = enemy.GetEnemyById(el, 174),
            boss = enemy.GetEnemyById(el, 175),
            weaponList = weapon.GetListByTier(wl, 02),
            armorList = armor.GetListByTier(al, 2),
            prefixList = mod.GetListByTier(pl, 2),
            suffixList = mod.GetListByTier(sl, 2)

        };
        worldList.Add(world);

        // Create Cave
        world = new World
        {
            worldName = "Cave",
            enemyScaling = 3,
            backgroundPath = "Background/cave1",
            soundPath = "Music/cavemusic",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 004), enemy.GetEnemyById(el, 050), enemy.GetEnemyById(el, 051), enemy.GetEnemyById(el, 041),
            enemy.GetEnemyById(el, 042), enemy.GetEnemyById(el, 027), enemy.GetEnemyById(el, 028)},
            miniBoss = enemy.GetEnemyById(el, 005),
            boss = enemy.GetEnemyById(el, 006),
            weaponList = weapon.GetListByTier(wl, 03),
            armorList = armor.GetListByTier(al, 3),
            prefixList = mod.GetListByTier(pl, 3),
            suffixList = mod.GetListByTier(sl, 3)
        };
        worldList.Add(world);

        // Create River
        world = new World
        {
            worldName = "River",
            enemyScaling = 4,
            backgroundPath = "Background/river",
            soundPath = "Music/rivermusic",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 007), enemy.GetEnemyById(el, 019), enemy.GetEnemyById(el, 020), enemy.GetEnemyById(el, 021),
            enemy.GetEnemyById(el, 022), enemy.GetEnemyById(el, 014), enemy.GetEnemyById(el, 025), enemy.GetEnemyById(el, 026)},
            miniBoss = enemy.GetEnemyById(el, 008),
            boss = enemy.GetEnemyById(el, 009),
            weaponList = weapon.GetListByTier(wl, 04),
            armorList = armor.GetListByTier(al, 4),
            prefixList = mod.GetListByTier(pl, 4),
        suffixList = mod.GetListByTier(sl, 4)
        };
        worldList.Add(world);

        // Create Swamp
        world = new World
        {
            worldName = "Swamp",
            enemyScaling = 5,
            backgroundPath = "Background/forest2",
            soundPath = "Music/swampmusic",
            enemyList = new List<Enemy> { enemy.GetEnemyById(el, 043), enemy.GetEnemyById(el, 046), enemy.GetEnemyById(el, 047), enemy.GetEnemyById(el, 048),
            enemy.GetEnemyById(el, 049), enemy.GetEnemyById(el, 023), enemy.GetEnemyById(el, 024)},
            miniBoss = enemy.GetEnemyById(el, 044),
            boss = enemy.GetEnemyById(el, 045),
            weaponList = weapon.GetListByTier(wl, 05),
            armorList = armor.GetListByTier(al, 5),
            prefixList = mod.GetListByTier(pl, 5),
            suffixList = mod.GetListByTier(sl, 5)
        };
        worldList.Add(world);

        return worldList;
    }

}


