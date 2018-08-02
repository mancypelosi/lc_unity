using UnityEngine;
using UnityEngine.UI;

// CharacterSelect scene, this code attached to Canvas
public class CharacterSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GameManager.gm.playerList[0] == null)
            GameObject.Find("CharacterSlot1").GetComponentInChildren<Text>().text = "NEW CHARACTER";
        else
            GameObject.Find("CharacterSlot1").GetComponentInChildren<Text>().text =
                "Name:" + GameManager.gm.playerList[0].name + " Class:" + GameManager.gm.playerList[0].playerClass + " Level:" + GameManager.gm.playerList[0].level;

        if (GameManager.gm.playerList[1] == null)
            GameObject.Find("CharacterSlot2").GetComponentInChildren<Text>().text = "NEW CHARACTER";
        else
            GameObject.Find("CharacterSlot2").GetComponentInChildren<Text>().text =
                "Name:" + GameManager.gm.playerList[1].name + " Class:" + GameManager.gm.playerList[1].playerClass + " Level:" + GameManager.gm.playerList[1].level;

        if (GameManager.gm.playerList[2] == null)
            GameObject.Find("CharacterSlot3").GetComponentInChildren<Text>().text = "NEW CHARACTER";
        else
            GameObject.Find("CharacterSlot3").GetComponentInChildren<Text>().text =
                "Name:" + GameManager.gm.playerList[2].name + " Class:" + GameManager.gm.playerList[2].playerClass + " Level:" + GameManager.gm.playerList[2].level;
    }

    // Load NewCharacter scene
    public void LoadCharacter(int characterChoice)
    {
        if (GameManager.gm.playerList[characterChoice] != null)
        {
            GameManager.gm.player = GameManager.gm.playerList[characterChoice];
            GameManager.gm.LoadScene("Town");
        }
        else
        {
            GameManager.gm.player = new Player();
            GameManager.gm.playerList[characterChoice] = GameManager.gm.player;
            GameManager.gm.LoadScene("NewCharacter");
        }
    }
}
