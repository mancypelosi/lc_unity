using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu : MonoBehaviour
{

    // Initialize main menu
    void Start()
    {
        // Load the game from save file
        Debug.Log(Application.persistentDataPath);
        GameManager.gm.Load();

        // Set version label
        GameObject.Find("VersionText").GetComponentInChildren<Text>().text = "version: " + GameManager.version;
    }

    // Load the CharacterSelect scene
    public void LoadCharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    }

    // Exit the game
    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
