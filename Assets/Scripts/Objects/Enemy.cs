using System;
using System.Collections.Generic;

public class Enemy {

    // Properties
    public int enemyId = 0;
    public string enemyName = "Enemy";
    public List<string> spriteList = new List<string>();
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

    // Scale the monster based on the world's enemyScaling
    public Enemy ScaleDifficulty(World world)
    {
        int scale = world.enemyScaling;

        health = health * scale;
        armor = Convert.ToInt32((armor * scale) * .5);
        magicResist = Convert.ToInt32((magicResist * scale) * .5);
        xpToGive = xpToGive * scale;
        goldToGive = goldToGive * scale;

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
            spriteList = { "Enemy/bulbasaur" },
            health = 35,
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
            spriteList = { "Enemy/ivysaur" },
            health = 200,
            armor = 35,
            magicResist = 35,
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
            spriteList = { "Enemy/venusaur" },
            health = 500,
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
            spriteList = { "Enemy/charmander" },
            health = 40,
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
            spriteList = { "Enemy/charmeleon" },
            health = 250,
            armor = 25,
            magicResist = 35,
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
            spriteList = { "Enemy/charizard" },
            health = 550,
            armor = 35,
            magicResist = 55,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Water", "Ice" , "Air", "Gun", "Bow", "Chakram",},
            resistances = { "Fire", "Spear", "Staff", "Earth", "Mace" }
        };
        enemyList.Add(enemy);

        // Squirtle
        enemy = new Enemy
        {
            enemyId = 007,
            enemyName = "Squirtle",
            spriteList = { "Enemy/squirtle" } ,
            health = 30,
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
            spriteList = { "Enemy/wartortle" },
            health = 175,
            armor = 55,
            magicResist = 55,
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
            spriteList = { "Enemy/blastoise" },
            health = 350,
            armor = 110,
            magicResist = 110,
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
            spriteList = { "Enemy/caterpie" },
            health = 25,
            armor = 15,
            magicResist = 15,
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
            spriteList = { "Enemy/metapod" },
            health = 55,
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
            spriteList = { "Enemy/butterfree" },
            health = 100,
            armor = 25,
            magicResist = 25,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Fire", "Bow", "Gun", "Chakram"},
            resistances = { "Dark", "Earth", "Dagger", "Spell" }
        };
        enemyList.Add(enemy);

        // Weedle
        enemy = new Enemy
        {
            enemyId = 013,
            enemyName = "Weedle",
            spriteList = { "Enemy/Weedle" },
            health = 25,
            armor = 15,
            magicResist = 15,
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
            spriteList = { "Enemy/kakuna" },
            health = 55,
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
            spriteList = { "Enemy/beedrill" },
            health = 100,
            armor = 25,
            magicResist = 25,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Fire", "Bow", "Gun", "Chakram" , "Air", "Light" },
            resistances = { "Dark", "Poison", "Dagger", "Sword", "Claw", "Axe" }
        };
        enemyList.Add(enemy);

         // Pidgey
         enemy = new Enemy
         {
             enemyId = 016,
             enemyName = "Pidgey",
             spriteList = { "Enemy/pidgey" },
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
            spriteList = { "Enemy/pidgeotto" },
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
            spriteList = { "Enemy/pidgeot" },
            health = 95,
            armor = 35,
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
            spriteList = { "Enemy/rattata" },
            health = 35,
            armor = 5,
            magicResist = 10,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Sword", "Claw" },
            resistances = { "Spell"}
        };
        enemyList.Add(enemy);

        // Raticate
        enemy = new Enemy
        {
            enemyId = 020,
            enemyName = "Raticate",
            spriteList = { "Enemy/raticate" },
            health = 70,
            armor = 15,
            magicResist = 25,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = {"Sword", "Claw" },
            resistances = {"Spell" }
        };
        enemyList.Add(enemy);

        // Spearow
        enemy = new Enemy
        {
            enemyId = 021,
            enemyName = "Spearow",
            spriteList = { "Enemy/spearow" },
            health = 35,
            armor = 5,
            magicResist = 5,
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
            spriteList = { "Enemy/fearow" },
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
            spriteList = { "Enemy/ekans" },
            health = 35,
            armor = 5,
            magicResist = 5,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Shield", "Fire", "Claws", "Sword", "Light" },
            resistances = { "Spear", "Dagger", "Mace"}
        };
        enemyList.Add(enemy);
 
        // Arbok
        enemy = new Enemy
        {
            enemyId = 024,
            enemyName = "Arbok",
            spriteList = { "Enemy/arbok" },
            health = 75,
            armor = 25,
            magicResist = 15,
            xpToGive = 5,
            goldToGive = 5,
           weaknesses = {"Shield", "Fire", "Claws", "Sword", "Light" },
            resistances = { "Spear", "Dagger", "Mace"}
        };
        enemyList.Add(enemy);
 
        // Pikachu
        enemy = new Enemy
        {
            enemyId = 025,
            enemyName = "Pikachu",
            spriteList = { "Enemy/pikachu" },
            health = 35,
            armor = 5,
            magicResist = 5,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Earth", "Spear", "Staff", "Dark"},
            resistances = {"Lightning", "Sword", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Raichu
        enemy = new Enemy
        {
            enemyId = 026,
            enemyName = "Raichu",
            spriteList = { "Enemy/raichu" },
            health = 60,
            armor = 5,
            magicResist = 35,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Earth", "Spear", "Staff", "Dark"},
            resistances = { "Lightning", "Sword", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Sandshrew
        enemy = new Enemy
        {
            enemyId = 027,
            enemyName = "Sandshrew",
            spriteList = { "Enemy/sandshrew" },
            health = 30,
            armor = 50,
            magicResist = 50,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Mace", "Staff", "Poison", "Light" },
            resistances = { "Dagger", "Sword", "Claws", "Dark"}
        };
        enemyList.Add(enemy);
 
        // Sandslash
        enemy = new Enemy
        {
            enemyId = 028,
            enemyName = "Sandslash",
            spriteList = { "Enemy/sandslash" },
            health = 55,
            armor = 75,
            magicResist = 75,
            xpToGive = 8,
            goldToGive = 8,
            weaknesses = {"Mace", "Staff", "Ice", "Light" },
            resistances = { "Dagger", "Sword", "Claws", "Dark"}
        };
        enemyList.Add(enemy);
 
        // Zubat
        enemy = new Enemy
        {
            enemyId = 041,
            enemyName = "Zubat",
            spriteList = { "Enemy/zubat" },
            health = 35,
            armor = 5,
            magicResist = 5,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Air", "Bow", "Gun", "Chakram", "Lightning", "Light" },
            resistances = { "Earth", "Poison"}
        };
        enemyList.Add(enemy);
 
        // Golbat
        enemy = new Enemy
        {
            enemyId = 042,
            enemyName = "Golbat",
            spriteList = { "Enemy/golbat" },
            health = 70,
            armor = 10,
            magicResist = 10,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Air", "Bow", "Gun", "Chakram" , "Lightning", "Light"},
            resistances = { "Earth", "Poison", "Dark", "Sword", "Mace", "Dagger", "Axe", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Oddish
        enemy = new Enemy
        {
            enemyId = 043,
            enemyName = "Oddish",
            spriteList = { "Enemy/oddish" },
            health = 35,
            armor = 5,
            magicResist = 25,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Fire", "Sword", "Axe", "Claws", "Spear" },
            resistances = { "Water", "Dark", "Poison" }
        };
        enemyList.Add(enemy);
 
        // Gloom
        enemy = new Enemy
        {
            enemyId = 044,
            enemyName = "Gloom",
            spriteList = { "Enemy/gloom" },
            health = 200,
            armor = 25,
            magicResist = 75,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Fire", "Sword", "Axe", "Claws", "Spear" },
            resistances = { "Water", "Dark", "Poison" }
        };
        enemyList.Add(enemy);
 
        // Vileplume
        enemy = new Enemy
        {
            enemyId = 045,
            enemyName = "Vileplume",
            spriteList = { "Enemy/vileplume" },
            health = 350,
            armor = 50,
            magicResist = 150,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Fire", "Sword", "Axe", "Claws", "Spear", "Light"},
            resistances = { "Water", "Dark", "Poison"}
        };
        enemyList.Add(enemy);
 
        // Paras
        enemy = new Enemy
        {
            enemyId = 046,
            enemyName = "Paras",
            spriteList = { "Enemy/paras" },
            health = 35,
            armor = 5,
            magicResist = 15,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Fire", "Dark"},
            resistances = {"Poison", "Spear", "Dagger" }
        };
        enemyList.Add(enemy);
 
        // Parasect
        enemy = new Enemy
        {
            enemyId = 047,
            enemyName = "Parasect",
            spriteList = { "Enemy/parasect" },
            health = 70,
            armor = 5,
            magicResist = 25,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = {"Fire", "Mace", "Earth", "Dark" },
            resistances = { "Spear", "Dagger", "Poison"}
        };
        enemyList.Add(enemy);
 
        // Venonat
        enemy = new Enemy
        {
            enemyId = 048,
            enemyName = "Venonat",
            spriteList = { "Enemy/venonat" },
            health = 35,
            armor = 5,
            magicResist = 5,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Fire", "Light" },
            resistances = { "Poison"}
        };
        enemyList.Add(enemy);
 
        // Venomoth
        enemy = new Enemy
        {
            enemyId = 049,
            enemyName = "Venomoth",
            spriteList = { "Enemy/venomoth" },
            health = 60,
            armor = 15,
            magicResist = 15,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Fire", "Air", "Lightning", "Chakram", "Bow", "Gun", "Light"},
            resistances = { "Poison", "Earth", "Dagger", "Sword", "Axe", "Mace", "Staff", "Claws"}
        };
        enemyList.Add(enemy);
 
        // Diglett
        enemy = new Enemy
        {
            enemyId = 050,
            enemyName = "Diglett",
            spriteList = { "Enemy/diglett" },
            health = 35,
            armor = 15,
            magicResist = 5,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Earth" , "Water", "Light"},
            resistances = {"Mace", "Air", "Poison" }
        };
        enemyList.Add(enemy);
 
        // Dugtrio
        enemy = new Enemy
        {
            enemyId = 051,
            enemyName = "Dugtrio",
            spriteList = { "Enemy/dugtrio" },
            health = 65,
            armor = 35,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Earth", "Water", "Light"},
            resistances = {"Mace", "Air", "Poison" }
        };
        enemyList.Add(enemy);
        
        // Nomad Chief
        enemy = new Enemy
        {
            enemyId = 152,
            enemyName = "Nomad Chief",
            spriteList = { "Enemy/rhydon/rhydon (1)", "Enemy/rhydon/rhydon (2)", "Enemy/rhydon/rhydon (3)", "Enemy/rhydon/rhydon (4)", "Enemy/rhydon/rhydon (5)", "Enemy/rhydon/rhydon (6)", "Enemy/rhydon/rhydon (7)", "Enemy/rhydon/rhydon (8)", "Enemy/rhydon/rhydon (9)", "Enemy/rhydon/rhydon (10)", "Enemy/rhydon/rhydon (11)", "Enemy/rhydon/rhydon (12)", "Enemy/rhydon/rhydon (13)", "Enemy/rhydon/rhydon (14)", "Enemy/rhydon/rhydon (15)", "Enemy/rhydon/rhydon (16)", "Enemy/rhydon/rhydon (17)", "Enemy/rhydon/rhydon (18)", "Enemy/rhydon/rhydon (19)", "Enemy/rhydon/rhydon (20)", "Enemy/rhydon/rhydon (21)", "Enemy/rhydon/rhydon (22)", "Enemy/rhydon/rhydon (23)", "Enemy/rhydon/rhydon (24)", "Enemy/rhydon/rhydon (25)", "Enemy/rhydon/rhydon (26)", "Enemy/rhydon/rhydon (27)", "Enemy/rhydon/rhydon (28)", "Enemy/rhydon/rhydon (29)", "Enemy/rhydon/rhydon (30)", "Enemy/rhydon/rhydon (31)", "Enemy/rhydon/rhydon (32)", "Enemy/rhydon/rhydon (33)", "Enemy/rhydon/rhydon (34)", "Enemy/rhydon/rhydon (35)", "Enemy/rhydon/rhydon (36)", "Enemy/rhydon/rhydon (37)", "Enemy/rhydon/rhydon (38)", "Enemy/rhydon/rhydon (39)", "Enemy/rhydon/rhydon (40)", "Enemy/rhydon/rhydon (41)", "Enemy/rhydon/rhydon (42)", "Enemy/rhydon/rhydon (43)", "Enemy/rhydon/rhydon (44)", "Enemy/rhydon/rhydon (45)", "Enemy/rhydon/rhydon (46)", "Enemy/rhydon/rhydon (47)", "Enemy/rhydon/rhydon (48)", "Enemy/rhydon/rhydon (49)", "Enemy/rhydon/rhydon (50)", "Enemy/rhydon/rhydon (51)", "Enemy/rhydon/rhydon (52)", "Enemy/rhydon/rhydon (53)", "Enemy/rhydon/rhydon (54)", "Enemy/rhydon/rhydon (55)", "Enemy/rhydon/rhydon (56)", "Enemy/rhydon/rhydon (57)", "Enemy/rhydon/rhydon (58)", "Enemy/rhydon/rhydon (59)", "Enemy/rhydon/rhydon (60)", "Enemy/rhydon/rhydon (61)", "Enemy/rhydon/rhydon (62)", "Enemy/rhydon/rhydon (63)", "Enemy/rhydon/rhydon (64)", "Enemy/rhydon/rhydon (65)", "Enemy/rhydon/rhydon (66)", "Enemy/rhydon/rhydon (67)", "Enemy/rhydon/rhydon (68)", "Enemy/rhydon/rhydon (69)", "Enemy/rhydon/rhydon (70)", "Enemy/rhydon/rhydon (71)", "Enemy/rhydon/rhydon (72)", "Enemy/rhydon/rhydon (73)", "Enemy/rhydon/rhydon (74)", "Enemy/rhydon/rhydon (75)", "Enemy/rhydon/rhydon (76)", "Enemy/rhydon/rhydon (77)", "Enemy/rhydon/rhydon (78)", "Enemy/rhydon/rhydon (79)", "Enemy/rhydon/rhydon (80)", "Enemy/rhydon/rhydon (81)", "Enemy/rhydon/rhydon (82)", "Enemy/rhydon/rhydon (83)", "Enemy/rhydon/rhydon (84)", "Enemy/rhydon/rhydon (85)", "Enemy/rhydon/rhydon (86)", "Enemy/rhydon/rhydon (87)", "Enemy/rhydon/rhydon (88)", "Enemy/rhydon/rhydon (89)", "Enemy/rhydon/rhydon (90)", "Enemy/rhydon/rhydon (91)", "Enemy/rhydon/rhydon (92)", "Enemy/rhydon/rhydon (93)", "Enemy/rhydon/rhydon (94)", "Enemy/rhydon/rhydon (95)", "Enemy/rhydon/rhydon (96)", "Enemy/rhydon/rhydon (97)", "Enemy/rhydon/rhydon (98)", "Enemy/rhydon/rhydon (99)", "Enemy/rhydon/rhydon (100)", "Enemy/rhydon/rhydon (101)", "Enemy/rhydon/rhydon (102)", "Enemy/rhydon/rhydon (103)", "Enemy/rhydon/rhydon (104)", "Enemy/rhydon/rhydon (105)", "Enemy/rhydon/rhydon (106)", "Enemy/rhydon/rhydon (107)", "Enemy/rhydon/rhydon (108)", "Enemy/rhydon/rhydon (109)", "Enemy/rhydon/rhydon (110)", "Enemy/rhydon/rhydon (111)", "Enemy/rhydon/rhydon (112)", "Enemy/rhydon/rhydon (113)", "Enemy/rhydon/rhydon (114)", "Enemy/rhydon/rhydon (115)", "Enemy/rhydon/rhydon (116)", "Enemy/rhydon/rhydon (117)", "Enemy/rhydon/rhydon (118)", "Enemy/rhydon/rhydon (119)", "Enemy/rhydon/rhydon (120)", "Enemy/rhydon/rhydon (121)", "Enemy/rhydon/rhydon (122)", "Enemy/rhydon/rhydon (123)", "Enemy/rhydon/rhydon (124)", "Enemy/rhydon/rhydon (125)", "Enemy/rhydon/rhydon (126)", "Enemy/rhydon/rhydon (127)", "Enemy/rhydon/rhydon (128)", "Enemy/rhydon/rhydon (129)", "Enemy/rhydon/rhydon (130)", "Enemy/rhydon/rhydon (131)", "Enemy/rhydon/rhydon (132)", "Enemy/rhydon/rhydon (133)", "Enemy/rhydon/rhydon (134)", "Enemy/rhydon/rhydon (135)", "Enemy/rhydon/rhydon (136)", "Enemy/rhydon/rhydon (137)", "Enemy/rhydon/rhydon (138)", "Enemy/rhydon/rhydon (139)", "Enemy/rhydon/rhydon (140)", "Enemy/rhydon/rhydon (141)", "Enemy/rhydon/rhydon (142)", "Enemy/rhydon/rhydon (143)", "Enemy/rhydon/rhydon (144)", "Enemy/rhydon/rhydon (145)", "Enemy/rhydon/rhydon (146)", "Enemy/rhydon/rhydon (147)", "Enemy/rhydon/rhydon (148)", "Enemy/rhydon/rhydon (149)", "Enemy/rhydon/rhydon (150)", "Enemy/rhydon/rhydon (151)", "Enemy/rhydon/rhydon (152)", "Enemy/rhydon/rhydon (153)", "Enemy/rhydon/rhydon (154)", "Enemy/rhydon/rhydon (155)", "Enemy/rhydon/rhydon (156)", "Enemy/rhydon/rhydon (157)", "Enemy/rhydon/rhydon (158)", "Enemy/rhydon/rhydon (159)", "Enemy/rhydon/rhydon (160)", "Enemy/rhydon/rhydon (161)", "Enemy/rhydon/rhydon (162)", "Enemy/rhydon/rhydon (163)", "Enemy/rhydon/rhydon (164)", "Enemy/rhydon/rhydon (165)", "Enemy/rhydon/rhydon (166)", "Enemy/rhydon/rhydon (167)", "Enemy/rhydon/rhydon (168)", "Enemy/rhydon/rhydon (169)", "Enemy/rhydon/rhydon (170)", "Enemy/rhydon/rhydon (171)", "Enemy/rhydon/rhydon (172)", "Enemy/rhydon/rhydon (173)", "Enemy/rhydon/rhydon (174)", "Enemy/rhydon/rhydon (175)", "Enemy/rhydon/rhydon (176)", "Enemy/rhydon/rhydon (177)", "Enemy/rhydon/rhydon (178)", "Enemy/rhydon/rhydon (179)", "Enemy/rhydon/rhydon (180)", "Enemy/rhydon/rhydon (181)", "Enemy/rhydon/rhydon (182)", "Enemy/rhydon/rhydon (183)", "Enemy/rhydon/rhydon (184)", "Enemy/rhydon/rhydon (185)", "Enemy/rhydon/rhydon (186)", "Enemy/rhydon/rhydon (187)", "Enemy/rhydon/rhydon (188)", "Enemy/rhydon/rhydon (189)", "Enemy/rhydon/rhydon (190)", "Enemy/rhydon/rhydon (191)", "Enemy/rhydon/rhydon (192)" },
            health = 65,
            armor = 55,
            magicResist = 5,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Mace", "Gun", "Spear", "Poison", "Ice", "Lightning"},
            resistances = {"Sword", "Claws", "Staff", "Fire", "Earth", "Bow" }
        };
        enemyList.Add(enemy);
        
        // Giant Rattlesnake
        enemy = new Enemy
        {
            enemyId = 153,
            enemyName = "Giant Rattlesnake",
            spriteList = { "Enemy/ekans/ekans (1)", "Enemy/ekans/ekans (2)", "Enemy/ekans/ekans (3)", "Enemy/ekans/ekans (4)", "Enemy/ekans/ekans (5)", "Enemy/ekans/ekans (6)", "Enemy/ekans/ekans (7)", "Enemy/ekans/ekans (8)", "Enemy/ekans/ekans (9)", "Enemy/ekans/ekans (10)", "Enemy/ekans/ekans (11)", "Enemy/ekans/ekans (12)", "Enemy/ekans/ekans (13)", "Enemy/ekans/ekans (14)", "Enemy/ekans/ekans (15)", "Enemy/ekans/ekans (16)", "Enemy/ekans/ekans (17)", "Enemy/ekans/ekans (18)", "Enemy/ekans/ekans (19)", "Enemy/ekans/ekans (20)", "Enemy/ekans/ekans (21)", "Enemy/ekans/ekans (22)", "Enemy/ekans/ekans (23)", "Enemy/ekans/ekans (24)", "Enemy/ekans/ekans (25)", "Enemy/ekans/ekans (26)", "Enemy/ekans/ekans (27)", "Enemy/ekans/ekans (28)", "Enemy/ekans/ekans (29)", "Enemy/ekans/ekans (30)", "Enemy/ekans/ekans (31)", "Enemy/ekans/ekans (32)", "Enemy/ekans/ekans (33)", "Enemy/ekans/ekans (34)", "Enemy/ekans/ekans (35)", "Enemy/ekans/ekans (36)", "Enemy/ekans/ekans (37)", "Enemy/ekans/ekans (38)", "Enemy/ekans/ekans (39)", "Enemy/ekans/ekans (40)", "Enemy/ekans/ekans (41)", "Enemy/ekans/ekans (42)", "Enemy/ekans/ekans (43)", "Enemy/ekans/ekans (44)", "Enemy/ekans/ekans (45)", "Enemy/ekans/ekans (46)", "Enemy/ekans/ekans (47)", "Enemy/ekans/ekans (48)", "Enemy/ekans/ekans (49)", "Enemy/ekans/ekans (50)", "Enemy/ekans/ekans (51)", "Enemy/ekans/ekans (52)", "Enemy/ekans/ekans (53)", "Enemy/ekans/ekans (54)", "Enemy/ekans/ekans (55)", "Enemy/ekans/ekans (56)", "Enemy/ekans/ekans (57)", "Enemy/ekans/ekans (58)", "Enemy/ekans/ekans (59)", "Enemy/ekans/ekans (60)", "Enemy/ekans/ekans (61)", "Enemy/ekans/ekans (62)", "Enemy/ekans/ekans (63)", "Enemy/ekans/ekans (64)", "Enemy/ekans/ekans (65)", "Enemy/ekans/ekans (66)", "Enemy/ekans/ekans (67)", "Enemy/ekans/ekans (68)", "Enemy/ekans/ekans (69)", "Enemy/ekans/ekans (70)" },
            health = 25,
            armor = 5,
            magicResist = 25,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = {"Shield", "Fire", "Claws", "Sword", "Light" },
            resistances = { "Spear", "Dagger", "Mace", "Bow", "Gun", "Chakram"}
        };
        enemyList.Add(enemy);
        
        // Snow Leopard
        enemy = new Enemy
        {
            enemyId = 154,
            enemyName = "Snow Leopard",
            spriteList = { "Enemy/persian" },
            health = 75,
            armor = 45,
            magicResist = 45,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Spear", "Bow", "Fire", "Dark", "Gun", "Chakram", "Wand"},
            resistances = {"Ice", "Light", "Poison" }
        };
        enemyList.Add(enemy);

        // Nomad Archer
        enemy = new Enemy
        {
            enemyId = 155,
            enemyName = "Nomad Archer",
            spriteList = { "Enemy/ponyta" },
            health = 35,
            armor = 15,
            magicResist = 5,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Spear", "Dagger", "Claws", "Sword" },
            resistances = { "Gun", "Bow", "Chakram", "Water" }
        };
        enemyList.Add(enemy);

        // Skeletal Cowboy
        enemy = new Enemy
        {
            enemyId = 156,
            enemyName = "Skeletal Cowboy",
            spriteList = { "Enemy/meowth" },
            health = 25,
            armor = 20,
            magicResist = 20,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Fire", "Mace", "Light", "Wand", "Shield" },
            resistances = { "Dark", "Poison", "Sword", "Dagger", "Bow", "Gun", "Spear" }
        };
        enemyList.Add(enemy);

        // Buffalo Spirit
        enemy = new Enemy
        {
            enemyId = 157,
            enemyName = "Buffalo Spirit",
            spriteList = { "Enemy/tauros" },
            health = 55,
            armor = 110,
            magicResist = 0,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Fire", "Air", "Light", },
            resistances = { "Dark", "Poison", "Staff" }
        };
        enemyList.Add(enemy);

        // Praire Dog Swarm
        enemy = new Enemy
        {
            enemyId = 158,
            enemyName = "Praire Dog Swarm",
            spriteList = { "Enemy/dugtrio" },
            health = 25,
            armor = 15,
            magicResist = 15,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Poison", "Water", "Spear" },
            resistances = { "Mace", "Fire", "Dark" }
        };
        enemyList.Add(enemy);

        // Nomad Warlock
        enemy = new Enemy
        {
            enemyId = 159,
            enemyName = "Nomad Warlock",
            spriteList = { "Enemy/rapidash" },
            health = 55,
            armor = 0,
            magicResist = 120,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Sword", "Claw", "Dagger", "Staff" },
            resistances = { "Dark", "Light", "Wand", "Water" }
        };
        enemyList.Add(enemy);

        // Eagle Demon
        enemy = new Enemy
        {
            enemyId = 160,
            enemyName = "Eagle-Demon",
            spriteList = { "Enemy/pidgeot" },
            health = 35,
            armor = 1,
            magicResist = 1,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Air", "Bow", "Gun", "Chakram", "Lightning" },
            resistances = { "Dagger", "Earth", "Sword", "Staff" }
        };
        enemyList.Add(enemy);

        // Possessed Wagon
        enemy = new Enemy
        {
            enemyId = 161,
            enemyName = "Possessed Wagon",
            spriteList = { "Enemy/snorlax" },
            health = 70,
            armor = 40,
            magicResist = 40,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Fire", "Axe", "Air", "Light", "Spear" },
            resistances = { "Dark", "Sword", "Claw", "Spell", "Wand" }
        };
        enemyList.Add(enemy);

        // Cowboy
        enemy = new Enemy
        {
            enemyId = 162,
            enemyName = "Living Cowboy",
            spriteList = { "Enemy/mewtwo" },
            health = 200,
            armor = 35,
            magicResist = 35,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Dagger", "Sword", "Claws", "Poison", "Bow", "Chakram" },
            resistances = { "Spear", "Water", "Dark", "Gun", "Mace" }
        };
        enemyList.Add(enemy);

        // Ilkhan
        enemy = new Enemy
        {
            enemyId = 163,
            enemyName = "Ilkhan",
            spriteList = { "Enemy/kangaskhan" },
            health = 500,
            armor = 50,
            magicResist = 50,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Lightning", "Mace", "Dagger", "Poison", "Ice", "Water", "Gun", "Wand" },
            resistances = { "Axe", "Sword", "Fire", "Earth", "Claws", "Axe", "Bow", "Chakram" }
        };
        enemyList.Add(enemy);

        // Monkey Archer
        enemy = new Enemy
        {
            enemyId = 164,
            enemyName = "Monkey Archer",
            spriteList = { "Enemy/mankey" },
            health = 40,
            armor = 10,
            magicResist = 10,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Spear", "Dagger", "Claws", "Sword", "Dark" },
            resistances = { "Gun", "Bow", "Chakram", "Light", "Poison" }
        };
        enemyList.Add(enemy);
        
        // Nomad Chief
        enemy = new Enemy
        {
            enemyId = 165,
            enemyName = "Rabbit Knight",
            spriteList = { "Enemy/rattata" },
            health = 35,
            armor = 95,
            magicResist = 15,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Mace", "Dark", "Spear", "Poison", "Air", "Lightning"},
            resistances = {"Sword", "Claws", "Staff", "Gun", "Chakram",  "Bow" }
        };
        enemyList.Add(enemy);
        
        // Elf bandit
        enemy = new Enemy
        {
            enemyId = 166,
            enemyName = "Elf Bandit",
            spriteList = { "Enemy/abra" },
            health = 35,
            armor = 25,
            magicResist = 25,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Spear", "Water", "Claws", "Sword" },
            resistances = { "Axe", "Mace", "Dagger", "Light" }
        };
        enemyList.Add(enemy);
        
        // Nomad Archer
        enemy = new Enemy
        {
            enemyId = 167,
            enemyName = "Smokebear",
            spriteList = { "Enemy/drowzee" },
            health = 50,
            armor = 350,
            magicResist = 5,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Spear", "Dagger", "Claws", "Sword" },
            resistances = { "Gun", "Bow", "Chakram", "Water" }
        };
        enemyList.Add(enemy);
        
        // Gnoll Farmer
        enemy = new Enemy
        {
            enemyId = 168,
            enemyName = "Gnoll Farmer",
            spriteList = { "Enemy/pinsir" },
            health = 75,
            armor = 15,
            magicResist = 35,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Gun", "Bow", "Chakram", "Wand", "Air", "Ice" },
            resistances = { "Spear", "Axe", "Dark", "Water", "Lightning" }
        };
        enemyList.Add(enemy);
        
        // Dryad
        enemy = new Enemy
        {
            enemyId = 169,
            enemyName = "Dryad",
            spriteList = { "Enemy/exeggcute" },
            //tfw no sudowudo
            health = 35,
            armor = 25,
            magicResist = 25,
            xpToGive = 3,
            goldToGive = 3,
            weaknesses = { "Axe", "Fire", "Ice", "Air" },
            resistances = { "Mace", "Water", "Earth", "Dagger" }
        };
        enemyList.Add(enemy);
        
        // Water Nymph
        enemy = new Enemy
        {
            enemyId = 170,
            enemyName = "Water Nymph",
            spriteList = { "Enemy/vaporeon" },
            health = 60,
            armor = 15,
            magicResist = 250,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Sword", "Dagger", "Claws", "Lightning", "Earth", "Staff" },
            resistances = { "Fire", "Poison", "Mace", "Water", "Spear", "Wand", "Ice" }
        };
        enemyList.Add(enemy);
        
        // Forest Troll
        enemy = new Enemy
        {
            enemyId = 171,
            enemyName = "Forest Troll",
            spriteList = { "Enemy/hitmonchan" },
            health = 100,
            armor = 0,
            magicResist = 0,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Fire", "Bow", "Gun", "Chakram", "Spear", "Wand", "Water" },
            resistances = { "Earth", "Poison", "Dark", "Air", "Ice"}
        };
        enemyList.Add(enemy);
        
        // Druid
        enemy = new Enemy
        {
            enemyId = 172,
            enemyName = "Druid",
            spriteList = { "Enemy/exeggutor" },
            health = 55,
            armor = 15,
            magicResist = 75,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Gun", "Dagger", "Staff", "Wand", "Bow", "Chakram", "Poison" },
            resistances = { "Dark", "Light", "Water", "Fire", "Earth", "Air", "Lightning", "Ice"  }
        };
        enemyList.Add(enemy);
        
        // Defender of the Forest
        enemy = new Enemy
        {
            enemyId = 173,
            enemyName = "Defender of the Forest",
            spriteList = { "Enemy/kabutops" },
            health = 80,
            armor = 25,
            magicResist = 25,
            xpToGive = 5,
            goldToGive = 5,
            weaknesses = { "Spear", "Fire", "Axe", "Air", "Poison", "Ice" },
            resistances = { "Dagger", "Sword", "Claws", "Mace", "Earth", "Water" }
        };
        enemyList.Add(enemy);
        
        // Ent
        enemy = new Enemy
        {
            enemyId = 174,
            enemyName = "Ent",
            spriteList = { "Enemy/exeggutor" },
            health = 200,
            armor = 60,
            magicResist = 20,
            xpToGive = 10,
            goldToGive = 10,
            weaknesses = { "Fire", "Axe", "Dark", "Poison", "Wand", "Bow", "Gun", "Ice"},
            resistances = { "Mace", "Sword", "Claws", "Dagger", "Earth", "Water" }
        };
        enemyList.Add(enemy);

        // Forest Dragon
        enemy = new Enemy
        {
            enemyId = 175,
            enemyName = "Forest Dragon",
            spriteList = { "Enemy/dragonite" },
            health = 500,
            armor = 85,
            magicResist = 85,
            xpToGive = 20,
            goldToGive = 20,
            weaknesses = { "Lightning", "Air", "Ice", "Wand", "Water",},
            resistances = { "Mace", "Axe", "Fire", "Earth", "Spell"},
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
            spriteList = { "Enemy/abby" },
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
            spriteList = { "Enemy/jace" },
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

