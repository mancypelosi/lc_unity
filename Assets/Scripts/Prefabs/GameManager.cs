﻿using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager gm;

    public Preferences prefs;
    public Player player;
    public Enemy enemy;
    public World world;
    public string previousScene = "";
    public static string version = "0.0.1i";

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
        PlayerData data = new PlayerData();
        data.player = this.player;

        // Serialize the data and close the file
        bf.Serialize(file, data);
        file.Close();
    }

    // Load data to Unity from application data file
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerData.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            // Data to load from the file
            this.player= data.player;
        }
    }

    // Standard Unity LoadScene, but also set the previousScene variable 
    public void LoadScene(string scene)
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
        previousScene = currentScene;
    }
}

// Create a class to allow us to save data
[Serializable]
class PlayerData
{
    public Player player;
}
