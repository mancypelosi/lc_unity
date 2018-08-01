using UnityEngine;
using UnityEngine.UI;

// CharacterSelect scene, this code attached to Canvas
public class CharacterSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GameManager.gm.player.playerClass == "None")
            GameObject.Find("CharacterSlot1").GetComponentInChildren<Text>().text = "NEW CHARACTER";
        else
            GameObject.Find("CharacterSlot1").GetComponentInChildren<Text>().text = 
                "Name:" + GameManager.gm.player.playerName + " Level:" + GameManager.gm.player.playerLevel;
    }

    // Load NewCharacter scene
    public void LoadCharacter(int characterChoice)
    {
        if (GameManager.gm.player.playerClass != "None")
            GameManager.gm.LoadScene("Town");
        else
            GameManager.gm.LoadScene("NewCharacter");
    }
}
