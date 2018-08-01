using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ItemsPanel class for the GameObject that contains Equipment and Inventory Panels
public class ItemsPanel : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Player player = GameManager.gm.player;

        // Inventory (Set item border color to match rarity)
        for (int i = 0; i < player.inventory.Count; i++)
        {
            SetItem(GameObject.Find("Item" + i), player.inventory[i]);
        }

        // Equipment
        SetItem(GameObject.Find("Weapon1Item"), player.weapon1);
        SetItem(GameObject.Find("Weapon2Item"), player.weapon2);
        SetItem(GameObject.Find("Weapon3Item"), player.weapon3);
        SetItem(GameObject.Find("HeadItem"), player.head);
        SetItem(GameObject.Find("ChestItem"), player.chest);
        SetItem(GameObject.Find("LegsItem"), player.legs);
        SetItem(GameObject.Find("GlovesItem"), player.gloves);
        SetItem(GameObject.Find("BootsItem"), player.boots);
    }

    // Set the game ui objects based on the item
    void SetItem(GameObject gameObject, Item item)
    {
        if (item != null)
        {
            // Item to GameObject
            gameObject.GetComponent<ItemPanel>().item = item;
            // Sprite
            gameObject.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(item.spritePath);
            // Rarities
            gameObject.GetComponentInParent<Outline>().effectColor = item.GetRarityColor();
        }
    }
}
