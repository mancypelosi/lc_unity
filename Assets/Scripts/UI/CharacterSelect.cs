using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {

    public Player[] players;

	// Use this for initialization
	void Start () {
        if (GameManager.gm.player.playerClass == "None")
        {
            GameObject.Find("CharacterSlot1").GetComponentInChildren<Text>().text = "NEW CHARACTER";
        }
        else
        {
            GameObject.Find("CharacterSlot1").GetComponentInChildren<Text>().text = 
                "Name:" + GameManager.gm.player.playerName + " Level:" + GameManager.gm.player.playerLevel;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Load NewCharacter scene
    public void LoadCharacter(int characterChoice)
    {
        if (GameManager.gm.player.playerClass != "None")
        {
            SceneManager.LoadScene("Town");
        }
        else
        {
            SceneManager.LoadScene("NewCharacter");
        }
    }
}
