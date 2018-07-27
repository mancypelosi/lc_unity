using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Town : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // Play music
        SoundManager.sm.PlayMusic(Resources.Load<AudioClip>("Music/townmusic"));
    }

    // Load MainMenu scene
    public void MainMenu()
    {
        SoundManager.sm.StopMusic();
        // Load scene 'MainMenu'
        SceneManager.LoadScene("MainMenu");
    }

    public void Previous()
    {
        GameManager.gm.LoadScene(GameManager.gm.previousScene);
    }

    public void SetGates()
    {
        Transform[] transform = GameObject.Find("Canvas").GetComponentsInChildren<Transform>(true);
        foreach (Transform t in transform)
        {
            if (GameManager.gm.player.world2)
            {
                if (t.name == "World2Panel")
                    t.gameObject.SetActive(true);
            }
            if (GameManager.gm.player.world3)
            {
                if (t.name == "World3Panel")
                    t.gameObject.SetActive(true);
            }
            if (GameManager.gm.player.world4)
            {
                if (t.name == "World4Panel")
                    t.gameObject.SetActive(true);
            }
        }
    }

    // Load Main scene and set world name from button
    public void LoadWorld(Text inputWorld)
    {
        SoundManager.sm.StopMusic();

        // Update world settings
        Debug.Log("World: " + inputWorld.text);
        GameManager.gm.world = GameManager.gm.world.GetWorldByName(GameManager.gm.world.WorldList(), inputWorld.text);

        // Load scene 'Main'
        SceneManager.LoadScene("Battle");
    }

}
