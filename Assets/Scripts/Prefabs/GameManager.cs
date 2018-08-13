using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

// This code attached to the GameManager prefab object
public class GameManager : MonoBehaviour {

    public static GameManager gm;

    public Preferences prefs;
    public Player player;
    public PlayerData playerData = new PlayerData();
    public List<Item> stash = new List<Item>();
    public Enemy enemy;
    public World world;
    public string previousScene = "";
    public static string version = "0.0.1n";

    // Use this for initialization
    void Start()
    {
        prefs = new Preferences();
        player = new Player();
        enemy = new Enemy();
        world = new World();
    }

    // While GameManager is running dont destroy static ref
    void Awake () {
        if (gm == null)
        {
            DontDestroyOnLoad(gameObject);
            gm = this;
        } else if (gm != this)
        {
            Destroy(gameObject);
        }  
	}

    // Save data to Unity application data file
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerData.dat");

        // Data to save to the file
        PlayerSaveData data = new PlayerSaveData();
        data.playerSaveData = this.playerData;

        // Serialize the data and close the file
        bf.Serialize(file, data);
        file.Close();

        Debug.Log("Save game");
    }

    // Load data to Unity from application data file
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerData.dat", FileMode.Open);
            PlayerSaveData data = (PlayerSaveData)bf.Deserialize(file);
            file.Close();

            // Data to load from the file
            this.playerData = data.playerSaveData;

            Debug.Log("Load game");
        }
    }

    // Delete local save data file
    public void DeleteSave()
    {
        if (File.Exists(Application.persistentDataPath + "/playerData.dat"))
        {
            File.Delete(Application.persistentDataPath + "/playerData.dat");
            playerData.playerList = new List<Player> { new Player(), new Player(), new Player() };
            playerData.stashList = new List<Item>();
            Debug.Log("Deleted Save Data");
        }
    }

    // Standard Unity LoadScene, but also set the previousScene variable 
    public void LoadScene(string scene)
    {
        // Save the game on scene transition
        Save();
        // Get currentScene
        string currentScene = SceneManager.GetActiveScene().name;
        // Load scene
        SceneManager.LoadScene(scene);
        // Set previous scene to the currentScene that was captured
        previousScene = currentScene;
    }
}

// Create a class to allow us to save data
[Serializable]
class PlayerSaveData
{
    public PlayerData playerSaveData;
}
