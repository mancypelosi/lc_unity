using System;
using System.Collections.Generic;

// Class to store player data 
[Serializable]
public class PlayerData {

    public List<Player> playerList = new List<Player> { new Player(), new Player(), new Player() };
    public List<Item> stashList = new List<Item>();

}
