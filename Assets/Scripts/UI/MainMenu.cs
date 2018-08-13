using UnityEngine;
using UnityEngine.UI;

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

        /*
        if (GameManager.gm.player.playerClass != "None")
        {
            GameObject.Find("UpdatePanel").SetActive(false);
        }
        */
    }

    // Load the CharacterSelect scene
    public void LoadCharacterSelect()
    {
        GameManager.gm.LoadScene("CharacterSelect");
    }

    // Exit the game
    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
