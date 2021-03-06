﻿using System;
using System.Collections.Generic;

public class Enemy {

    // Properties
    public int enemyId = 0;
    public string enemyName = "Enemy";
    public string spritePath;
    public int health = 10;
    public int armor = 1;
    public int magicResist = 1;
    public int xpToGive = 1;
    public int goldToGive = 1;
    public List<string> weaknesses = new List<string>();
    public List<string> resistances = new List<string>();

    // Get Enemy by enemyId from list
    public Enemy GetEnemyById(List<Enemy> list, int id)
    {
        Enemy e = new Enemy();
        if ((list.Find(enemy => enemy.enemyId == id) != null))
        {
            e = list.Find(enemy => enemy.enemyId == id);
        }
        return e;
    }

    // Scale the monster based on the world level
    public Enemy Scale(World world)
    {
        int value = 1;
        if (world.worldName == "Forest")
            value = 1;
        if (world.worldName == "Cave")
            value = 2;
        if (world.worldName == "River")
            value = 3;
        if (world.worldName == "Swamp")
            value = 4;

        health = health * value;
        armor = Convert.ToInt32(armor * value * .35);
        magicResist = Convert.ToInt32(magicResist * value * .35);
        xpToGive = xpToGive * value;
        goldToGive = goldToGive * value;

        return this;
    }

    // Create list of Enemy
    public List<Enemy> EnemyList()
    {
        List<Enemy> enemyList = new List<Enemy>();

        Enemy enemy;

        // Bulbasaur
        enemy = new Enemy
        {
            enemyId = 001,
            enemyName = "Bulbasaur",
            spritePath = "Enemy/bulbasaur",
            health = 30,
            armor = 5,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Fire", "Axe", "Claws", "Ice" },
            resistances = { "Earth", "Lightning" , "Poison"}
        };
        enemyList.Add(enemy);

        // Ivysaur
        enemy = new Enemy
        {
            enemyId = 002,
            enemyName = "Ivysaur",
            spritePath = "Enemy/ivysaur",
            health = 200,
            armor = 25,
            magicResist = 25,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Fire", "Axe", "Claws", "Ice"},
            resistances = { "Earth", "Lightning", "Poison", "Dagger" }
        };
        enemyList.Add(enemy);

        // Venusaur
        enemy = new Enemy
        {
            enemyId = 003,
            enemyName = "Venusaur",
            spritePath = "Enemy/venusaur",
            health = 400,
            armor = 50,
            magicResist = 50,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Fire", "Axe", "Claws", "Ice" },
            resistances = { "Earth", "Lightning" , "Poison", "Dagger"}
        };
        enemyList.Add(enemy);

        // Charmander
        enemy = new Enemy
        {
            enemyId = 004,
            enemyName = "Charmander",
            spritePath = "Enemy/charmander",
            health = 30,
            armor = 5,
            magicResist = 8,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Water", "Sword", "Claw", "Earth", "Ice" },
            resistances = { "Fire", "Spear", "Staff" }
        };
        enemyList.Add(enemy);

        // Charmeleon
        enemy = new Enemy
        {
            enemyId = 005,
            enemyName = "Charmeleon",
            spritePath = "Enemy/charmeleon",
            health = 250,
            armor = 25,
            magicResist = 30,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Water", "Sword", "Claw" ,"Earth", "Ice"},
            resistances = { "Fire","Spear", "Staff"}
        };
        enemyList.Add(enemy);

        // Charizard
        enemy = new Enemy
        {
            enemyId = 006,
            enemyName = "Charizard",
            spritePath = "Enemy/charizard",
            health = 550,
            armor = 50,
            magicResist = 60,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Water", "Sword", "Claw", "Ice" , "Air"},
            resistances = { "Fire", "Spear", "Staff", "Earth" }
        };
        enemyList.Add(enemy);

        // Squirtle
        enemy = new Enemy
        {
            enemyId = 007,
            enemyName = "Squirtle",
            spritePath = "Enemy/squirtle",
            health = 25,
            armor = 10,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Lightning", "Mace", "Dagger", "Poison"},
            resistances = { "Water", "Sword", "Gun", "Bow", "Claw", "Chakram", "Ice"}
        };
        enemyList.Add(enemy);

        // Wartortle
        enemy = new Enemy
        {
            enemyId = 008,
            enemyName = "Wartortle",
            spritePath = "Enemy/wartortle",
            health = 175,
            armor = 25,
            magicResist = 25,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Lightning", "Mace", "Dagger", "Poison" },
            resistances = { "Water", "Sword", "Gun", "Bow", "Claw", "Chakram" , "Ice"}
        };
        enemyList.Add(enemy);

        // Blasttoise
        enemy = new Enemy
        {
            enemyId = 009,
            enemyName = "Blastoise",
            spritePath = "Enemy/blastoise",
            health = 350,
            armor = 60,
            magicResist = 60,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Lightning", "Mace", "Dagger" , "Poison"},
            resistances = { "Water", "Sword", "Gun", "Bow", "Claw", "Chakram", "Ice" }
        };
        enemyList.Add(enemy);

        // Caterpie
        enemy = new Enemy
        {
            enemyId = 010,
            enemyName = "Caterpie",
            spritePath = "Enemy/caterpie",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Fire", "Dagger" },
            resistances = { "Dark" }
        };
        enemyList.Add(enemy);

        // Metapod
        enemy = new Enemy
        {
            enemyId = 011,
            enemyName = "Metapod",
            spritePath = "Enemy/metapod",
            health = 75,
            armor = 100,
            magicResist = 0,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Fire", "Mace", "Ice" },
            resistances = { "Dark", "Sword", "Claw", "Spear", "Axe" }
        };
        enemyList.Add(enemy);

        // Butterfree
        enemy = new Enemy
        {
            enemyId = 012,
            enemyName = "Butterfree",
            spritePath = "Enemy/butterfree",
            health = 100,
            armor = 25,
            magicResist = 25,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Fire", "Bow", "Gun", "Chakram"},
            resistances = { "Dark", "Earth", "Dagger" }
        };
        enemyList.Add(enemy);

        // Weedle
        enemy = new Enemy
        {
            enemyId = 013,
            enemyName = "Weedle",
            spritePath = "Enemy/Weedle",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Fire", "Dagger" },
            resistances = { "Dark", "Poison"}
        };
        enemyList.Add(enemy);

        // Kakuna
        enemy = new Enemy
        {
            enemyId = 014,
            enemyName = "Kakuna",
            spritePath = "Enemy/kakuna",
            health = 75,
            armor = 0,
            magicResist = 100,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Fire", "Mace", "Ice" },
            resistances = { "Dark", "Sword", "Claw", "Spear", "Axe" }
        };
        enemyList.Add(enemy);

        // Beedrill
        enemy = new Enemy
        {
            enemyId = 015,
            enemyName = "Beedrill",
            spritePath = "Enemy/beedrill",
            health = 100,
            armor = 25,
            magicResist = 25,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Fire", "Bow", "Gun", "Chakram" , "Air" },
            resistances = { "Dark", "Poison", "Dagger" }
        };
        enemyList.Add(enemy);

        // Pidgey
        enemy = new Enemy
        {
            enemyId = 016,
            enemyName = "Pidgey",
            spritePath = "Enemy/pidgey",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Air", "Bow", "Gun", "Chakram" },
            resistances = { "Dagger", "Earth" }
        };
        enemyList.Add(enemy);

        // Pidgeotto
        enemy = new Enemy
        {
            enemyId = 017,
            enemyName = "Pidgeotto",
            spritePath = "Enemy/pidgeotto",
            health = 60,
            armor = 10,
            magicResist = 10,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Air", "Bow", "Gun", "Chakram", "Lightning" },
            resistances = { "Dagger", "Earth", "Sword", "Axe", "Mace", "Staff", "Claws"}
        };
        enemyList.Add(enemy);

        // Pidgeot
        enemy = new Enemy
        {
            enemyId = 018,
            enemyName = "Pidgeot",
            spritePath = "Enemy/pidgeot",
            health = 95,
            armor = 20,
            magicResist = 10,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Air", "Bow", "Gun", "Chakram" , "Lightning"},
            resistances = { "Dagger", "Earth", "Sword", "Axe", "Mace", "Staff", "Claws"}
        };
        enemyList.Add(enemy);

        // Rattata
        enemy = new Enemy
        {
            enemyId = 019,
            enemyName = "Rattata",
            spritePath = "Enemy/rattata",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { },
            resistances = { }
        };
        enemyList.Add(enemy);

        // Raticate
        enemy = new Enemy
        {
            enemyId = 020,
            enemyName = "Raticate",
            spritePath = "Enemy/raticate",
            health = 50,
            armor = 5,
            magicResist = 15,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { },
            resistances = { }
        };
        enemyList.Add(enemy);

        // Spearow
        enemy = new Enemy
        {
            enemyId = 021,
            enemyName = "Spearow",
            spritePath = "Enemy/spearow",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Air", "Bow", "Gun", "Chakram" },
            resistances = { "Earth"}
        };
        enemyList.Add(enemy);

        // Fearow
        enemy = new Enemy
        {
            enemyId = 022,
            enemyName = "Fearow",
            spritePath = "Enemy/fearow",
            health = 80,
            armor = 5,
            magicResist = 5,
            xpToGive = 8,
            goldToGive = 8,
            weaknesses = { "Air", "Bow", "Gun", "Chakram" },
            resistances = { "Earth", "Dagger", "Sword", "Axe", "Mace", "Staff", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Ekans
        enemy = new Enemy
        {
            enemyId = 023,
            enemyName = "Ekans",
            spritePath = "Enemy/ekans",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Shield", "Fire", "Claws", "Sword" },
            resistances = { "Spear", "Dagger", "Mace"}
        };
        enemyList.Add(enemy);
 
        // Arbok
        enemy = new Enemy
        {
            enemyId = 024,
            enemyName = "Arbok",
            spritePath = "Enemy/arbok",
            health = 50,
            armor = 25,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
           weaknesses = {"Shield", "Fire", "Claws", "Sword" },
            resistances = { "Spear", "Dagger", "Mace"}
        };
        enemyList.Add(enemy);
 
        // Pikachu
        enemy = new Enemy
        {
            enemyId = 025,
            enemyName = "Pikachu",
            spritePath = "Enemy/pikachu",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Earth", "Spear", "Staff"},
            resistances = {"Lightning", "Sword", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Raichu
        enemy = new Enemy
        {
            enemyId = 026,
            enemyName = "Raichu",
            spritePath = "Enemy/raichu",
            health = 40,
            armor = 5,
            magicResist = 35,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Earth", "Spear", "Staff"},
            resistances = { "Lightning", "Sword", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Sandshrew
        enemy = new Enemy
        {
            enemyId = 027,
            enemyName = "Sandshrew",
            spritePath = "Enemy/sandshrew",
            health = 25,
            armor = 50,
            magicResist = 50,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Mace", "Staff", "Poison" },
            resistances = { "Dagger", "Sword", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Sandslash
        enemy = new Enemy
        {
            enemyId = 028,
            enemyName = "Sandslash",
            spritePath = "Enemy/sandslash",
            health = 45,
            armor = 75,
            magicResist = 75,
            xpToGive = 8,
            goldToGive = 8,
            weaknesses = {"Mace", "Staff", "Ice" },
            resistances = { "Dagger", "Sword", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Zubat
        enemy = new Enemy
        {
            enemyId = 041,
            enemyName = "Zubat",
            spritePath = "Enemy/zubat",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Air", "Bow", "Gun", "Chakram" },
            resistances = { "Earth", "Poison"}
        };
        enemyList.Add(enemy);
 
        // Golbat
        enemy = new Enemy
        {
            enemyId = 042,
            enemyName = "Golbat",
            spritePath = "Enemy/golbat",
            health = 50,
            armor = 5,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Air", "Bow", "Gun", "Chakram" , "Lightning"},
            resistances = { "Earth", "Poison"}
        };
        enemyList.Add(enemy);
 
        // Oddish
        enemy = new Enemy
        {
            enemyId = 043,
            enemyName = "Oddish",
            spritePath = "Enemy/oddish",
            health = 60,
            armor = 5,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Fire", "Sword", "Axe", "Claws" },
            resistances = { "Water", "Dark", "Poison" }
        };
        enemyList.Add(enemy);
 
        // Gloom
        enemy = new Enemy
        {
            enemyId = 044,
            enemyName = "Gloom",
            spritePath = "Enemy/gloom",
            health = 300,
            armor = 25,
            magicResist = 25,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Fire", "Sword", "Axe", "Claws" },
            resistances = { "Water", "Dark", "Poison" }
        };
        enemyList.Add(enemy);
 
        // Vileplume
        enemy = new Enemy
        {
            enemyId = 045,
            enemyName = "Vileplume",
            spritePath = "Enemy/vileplume",
            health = 600,
            armor = 50,
            magicResist = 500,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Fire", "Sword", "Axe", "Claws" },
            resistances = { "Water", "Dark", "Poison"}
        };
        enemyList.Add(enemy);
 
        // Paras
        enemy = new Enemy
        {
            enemyId = 046,
            enemyName = "Paras",
            spritePath = "Enemy/paras",
            health = 25,
            armor = 1,
            magicResist = 5,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Fire"},
            resistances = {"Poison" }
        };
        enemyList.Add(enemy);
 
        // Parasect
        enemy = new Enemy
        {
            enemyId = 047,
            enemyName = "Parasect",
            spritePath = "Enemy/parasect",
            health = 50,
            armor = 5,
            magicResist = 25,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = {"Fire", "Mace", "Earth" },
            resistances = { "Spear", "Dagger", "Poison"}
        };
        enemyList.Add(enemy);
 
        // Venonat
        enemy = new Enemy
        {
            enemyId = 048,
            enemyName = "Venonat",
            spritePath = "Enemy/venonat",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Fire" },
            resistances = { "Poison"}
        };
        enemyList.Add(enemy);
 
        // Venomoth
        enemy = new Enemy
        {
            enemyId = 049,
            enemyName = "Venomoth",
            spritePath = "Enemy/venomoth",
            health = 50,
            armor = 5,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Fire", "Air", "Lightning", "Chakram", "Bow", "Gun"},
            resistances = { "Poison", "Earth", "Dagger", "Sword", "Axe", "Mace", "Staff", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Diglett
        enemy = new Enemy
        {
            enemyId = 050,
            enemyName = "Diglett",
            spritePath = "Enemy/diglett",
            health = 25,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Earth" , "Water"},
            resistances = {"Mace", "Air" }
        };
        enemyList.Add(enemy);
 
        // Dugtrio
        enemy = new Enemy
        {
            enemyId = 051,
            enemyName = "Dugtrio",
            spritePath = "Enemy/dugtrio",
            health = 45,
            armor = 25,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Earth", "Water"},
            resistances = {"Mace", "Air" }
        };
        enemyList.Add(enemy);
 
        /********************/
        /*** LEGENDARIES ***/
        /******************/
 
        // Abby
        enemy = new Enemy
        {
            enemyId = 1,
            enemyName = "Abby the Destroyer",
            spritePath = "Enemy/abby",
            health = 800,
            armor = 100,
            magicResist = 100,
            xpToGive = 100,
            goldToGive = 100,
            weaknesses = { "Chakram", "Spell", "Wand", "Bow", "Gun", "Light", "Dagger"},
            resistances = { "Dark", "Sword", "Claws", "Mace", "Axe", "Staff", "Fire"}
        };
        enemyList.Add(enemy);
 
        // Jace
        enemy = new Enemy
        {
            enemyId = 2,
            enemyName = "Jace the Cryer",
            spritePath = "Enemy/jace",
            health = 800,
            armor = 100,
            magicResist = 100,
            xpToGive = 100,
            goldToGive = 100,
            weaknesses = {"Claws", "Dagger", "Spear" },
            resistances = {"Poison", "Light", "Axe", "Mace", "Chakram", "Gun", "Bow", "Staff"}
        };
        enemyList.Add(enemy);
 
        return enemyList;
    }
 
}

