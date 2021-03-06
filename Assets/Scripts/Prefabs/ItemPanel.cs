﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// ItemPanel class for the Items using Pointer and Drag EventHandlers
public class ItemPanel : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,
    IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{

    // Public variables
    public Item item;
    public string type;
    public GameObject tooltipPrefab;
    // Pointer variables
    private GameObject tooltip;
    private Vector3 offset = new Vector3(-86, -154, 0);
    // Drag static variables
    private static Item startItem;
    private static GameObject startObject;
    private static Vector3 startPosition;
    private static Transform startParent;
    // Private variables
    private List<string> weaponTypes = new List<string> { "Weapon1Item", "Weapon2Item", "Weapon3Item" };
    private List<string> armorTypes = new List<string> { "HeadItem", "ChestItem", "LegsItem", "GlovesItem", "BootsItem" };
    private List<string> equipTypes = new List<string> { "Weapon1Item", "Weapon2Item", "Weapon3Item", "HeadItem", "ChestItem", "LegsItem", "GlovesItem", "BootsItem" };

    // Event for item begin drag
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
        // Capture the start object and it's item
        startObject = gameObject;
        startItem = startObject.GetComponent<ItemPanel>().item;
        // Capture for reset purposes
        startPosition = transform.position;
        startParent = transform.parent;
        // Set parent to the panel so the item is in front of the other items
        transform.SetParent(GameObject.Find("InventoryPanel").transform);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    // Event for item drag
    public void OnDrag(PointerEventData eventData)
    {
        // Move item GameObject position with the drag
        transform.position = Input.mousePosition;
    }

    // Event for item end drag
    public void OnEndDrag(PointerEventData eventData)
    {
        // Reset the item GameObject position and parent
        transform.SetParent(startParent);
        transform.position = startPosition;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On drop");
        // Equip
        if (!equipTypes.Contains(startObject.name) && equipTypes.Contains(gameObject.name))
        {
            Debug.Log("Equip");
            Equip();
        }
        if (weaponTypes.Contains(startObject.name) && weaponTypes.Contains(gameObject.name))
        {
            Debug.Log("Eqip - swap weapon");
            Equip();
        }
        // Unequip
        else if (equipTypes.Contains(startObject.name) && !equipTypes.Contains(gameObject.name))
        {
            Debug.Log("Unequip");
            Unequip();
        }
        // Sort Inventory
        else
        {
            Debug.Log("Sort Inventory");
            SortInventory();
        }

    }

    // Equip item
    void Equip()
    {
        // Check if weapon
        if (weaponTypes.Contains(gameObject.name) && startItem is Weapon)
        {
            if (startItem != null && item != null)
            {
                Debug.Log("Weapon Swap");
                startObject.transform.SetParent(startParent);
                // Update inventory
                GameManager.gm.player.inventory.Remove(startItem);
                GameManager.gm.player.inventory.Add(item);
                // Unequip swapped item
                GameManager.gm.player.Unequip(item);
                // Set the items
                SetItem(startObject, item);
                SetItem(gameObject, startItem);
            }

            if (startItem != null && item == null)
            {
                Debug.Log("Weapon No Swap");
                // Update invetory
                GameManager.gm.player.inventory.Remove(startItem);
                // Update ui object
                RemoveItem(startObject);
                // Set the item
                SetItem(gameObject, startItem);
            }
        }

        // Check if armor
        if (armorTypes.Contains(gameObject.name) && startItem is Armor)
        {
            Armor armor = (Armor)startItem;
            if (gameObject.name.Contains(armor.armorType.ToString()))
            {
                if (startItem != null && item != null)
                {
                    Debug.Log("Armor Swap");
                    startObject.transform.SetParent(startParent);
                    // Update inventory
                    GameManager.gm.player.inventory.Remove(startItem);
                    GameManager.gm.player.inventory.Add(item);
                    // Unequip swapped item
                    GameManager.gm.player.Unequip(item);
                    // Set the items
                    SetItem(startObject, item);
                    SetItem(gameObject, startItem);
                }

                if (startItem != null && item == null)
                {
                    Debug.Log("Armor No Swap");
                    // Update invetory
                    GameManager.gm.player.inventory.Remove(startItem);
                    // Update ui object
                    RemoveItem(startObject);
                    // Set the item
                    SetItem(gameObject, startItem);
                }
            }
        }


    }

    // Unequip item
    void Unequip()
    {
        // Inventory slots
        if (equipTypes.Contains(startObject.name) && !equipTypes.Contains(gameObject.name))
        {
            // Swap Items
            if (startItem != null && item != null)
            {
                Debug.Log("Swap");
                GameManager.gm.player.inventory.Add(startItem);
                GameManager.gm.player.inventory.Remove(item);
                startObject.transform.SetParent(startParent);
                GameManager.gm.player.Unequip(startItem);
                SetItem(startObject, item);
                SetItem(gameObject, startItem);
            }
            // No Swap
            if (startItem != null && item == null)
            {
                Debug.Log("No Swap");
                GameManager.gm.player.inventory.Add(startItem);
                RemoveItem(startObject);
                GameManager.gm.player.Unequip(startItem);
                // Set Item
                if (!gameObject.name.Equals("Trash"))
                {
                    SetItem(gameObject, startItem);
                }
                // Trash Item if dragged to Trash
                else
                {
                    Debug.Log("Trash");
                    GameManager.gm.player.inventory.Remove(startItem);
                    UpdateEquipment();
                    SoundManager.sm.PlaySoundFX(Resources.Load<AudioClip>("Sfx/dropsfx"));
                }
            }
        }
    }

    // Move inventory item positions
    void SortInventory()
    {
        // Inventory slots
        if (!equipTypes.Contains(gameObject.name))
        {
            // Swap Items
            if (startItem != null && item != null)
            {
                Debug.Log("Swap");
                startObject.transform.SetParent(startParent);
                SetItem(startObject, item);
                SetItem(gameObject, startItem);
            }
            // No Swap
            if (startItem != null && item == null)
            {
                Debug.Log("No Swap");
                RemoveItem(startObject);
                // Set Item
                if (!gameObject.name.Equals("Trash"))
                {
                    SetItem(gameObject, startItem);
                }
                // Trash Item if dragged to Trash
                else
                {
                    Debug.Log("Trash");
                    GameManager.gm.player.inventory.Remove(startItem);
                    UpdateEquipment();
                    SoundManager.sm.PlaySoundFX(Resources.Load<AudioClip>("Sfx/dropsfx"));
                }
            }
        }
    }

    // Set the game objects based on the item
    private void SetItem(GameObject gameObject, Item item)
    {
        Debug.Log("Set Item: " + item.name);
        // Set gameObject item to item
        gameObject.GetComponent<ItemPanel>().item = item;
        // Sprite
        gameObject.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(item.spritePath);

        // Equip item
        if (gameObject.GetComponent<ItemPanel>().type == "Head")
        {
            GameManager.gm.player.head = (Armor)GameManager.gm.player.Equip(item);
        }
        else if (gameObject.GetComponent<ItemPanel>().type == "Chest")
        {
            GameManager.gm.player.chest = (Armor)GameManager.gm.player.Equip(item);
        }
        else if (gameObject.GetComponent<ItemPanel>().type == "Gloves")
        {
            GameManager.gm.player.gloves = (Armor)GameManager.gm.player.Equip(item);
        }
        else if (gameObject.GetComponent<ItemPanel>().type == "Boots")
        {
            GameManager.gm.player.boots = (Armor)GameManager.gm.player.Equip(item);
        }
        else if (gameObject.GetComponent<ItemPanel>().type == "Legs")
        {
            GameManager.gm.player.legs = (Armor)GameManager.gm.player.Equip(item);
        }
        else if (gameObject.GetComponent<ItemPanel>().type == "Weapon1")
        {
            GameManager.gm.player.weapon1 = (Weapon)GameManager.gm.player.Equip(item);
        }
        else if (gameObject.GetComponent<ItemPanel>().type == "Weapon2")
        {
            GameManager.gm.player.weapon2 = (Weapon)GameManager.gm.player.Equip(item);
        }
        else if (gameObject.GetComponent<ItemPanel>().type == "Weapon3")
        {
            GameManager.gm.player.weapon3 = (Weapon)GameManager.gm.player.Equip(item);
        }

        // Rarities
        gameObject.GetComponentInParent<Outline>().effectColor = item.GetRarityColor();

        UpdateEquipment();

    }

    // Update equipped equipment and weapon buttons
    private void UpdateEquipment()
    {
        // Set Equipped Armor
        if ((Armor)GameObject.Find("HeadItem").GetComponent<ItemPanel>().item != null)
            GameManager.gm.player.head = (Armor)(GameObject.Find("HeadItem").GetComponent<ItemPanel>().item);
        else
            GameManager.gm.player.head = null;
        if ((Armor)GameObject.Find("ChestItem").GetComponent<ItemPanel>().item != null)
            GameManager.gm.player.chest = (Armor)(GameObject.Find("ChestItem").GetComponent<ItemPanel>().item);
        else
            GameManager.gm.player.chest = null;
        if ((Armor)GameObject.Find("GlovesItem").GetComponent<ItemPanel>().item != null)
            GameManager.gm.player.gloves = (Armor)(GameObject.Find("GlovesItem").GetComponent<ItemPanel>().item);
        else
            GameManager.gm.player.gloves = null;
        if ((Armor)GameObject.Find("BootsItem").GetComponent<ItemPanel>().item != null)
            GameManager.gm.player.boots = (Armor)(GameObject.Find("BootsItem").GetComponent<ItemPanel>().item);
        else
            GameManager.gm.player.boots = null;
        if ((Armor)GameObject.Find("LegsItem").GetComponent<ItemPanel>().item != null)
            GameManager.gm.player.legs = (Armor)(GameObject.Find("LegsItem").GetComponent<ItemPanel>().item);
        else
            GameManager.gm.player.legs = null;
        // Set Equipped Weapons
        if ((Weapon)GameObject.Find("Weapon1Item").GetComponent<ItemPanel>().item != null)
            GameManager.gm.player.weapon1 = (Weapon)(GameObject.Find("Weapon1Item").GetComponent<ItemPanel>().item);
        else
            GameManager.gm.player.weapon1 = new Weapon();
        if ((Weapon)GameObject.Find("Weapon2Item").GetComponent<ItemPanel>().item != null)
            GameManager.gm.player.weapon2 = (Weapon)(GameObject.Find("Weapon2Item").GetComponent<ItemPanel>().item);
        else
            GameManager.gm.player.weapon2 = new Weapon();
        if ((Weapon)GameObject.Find("Weapon3Item").GetComponent<ItemPanel>().item != null)
            GameManager.gm.player.weapon3 = (Weapon)(GameObject.Find("Weapon3Item").GetComponent<ItemPanel>().item);
        else
            GameManager.gm.player.weapon3 = new Weapon();

        // Update Weapon Buttons
        if (SceneManager.GetActiveScene().name == "Battle")
        {
            GameObject.Find("Slot1Button").GetComponentInChildren<Text>().text = GameManager.gm.player.weapon1.name;
            GameObject.Find("Slot1Button").GetComponentInChildren<Text>().color = GameManager.gm.player.weapon1.GetRarityColor();
            GameObject.Find("Slot2Button").GetComponentInChildren<Text>().text = GameManager.gm.player.weapon2.name;
            GameObject.Find("Slot2Button").GetComponentInChildren<Text>().color = GameManager.gm.player.weapon2.GetRarityColor();
            GameObject.Find("Slot3Button").GetComponentInChildren<Text>().text = GameManager.gm.player.weapon3.name;
            GameObject.Find("Slot3Button").GetComponentInChildren<Text>().color = GameManager.gm.player.weapon3.GetRarityColor();
            if (GameManager.gm.player.equippedWeapon.name == GameObject.Find("Slot1Button").GetComponentInChildren<Text>().text)
            {
                GameObject.Find("Slot1Button").GetComponentInChildren<Outline>().effectColor = Color.white;
                GameObject.Find("Slot2Button").GetComponentInChildren<Outline>().effectColor = Color.black;
                GameObject.Find("Slot3Button").GetComponentInChildren<Outline>().effectColor = Color.black;

            }
            else if (GameManager.gm.player.equippedWeapon.name == GameObject.Find("Slot2Button").GetComponentInChildren<Text>().text)
            {
                GameObject.Find("Slot1Button").GetComponentInChildren<Outline>().effectColor = Color.black;
                GameObject.Find("Slot2Button").GetComponentInChildren<Outline>().effectColor = Color.white;
                GameObject.Find("Slot3Button").GetComponentInChildren<Outline>().effectColor = Color.black;
            }
            else if (GameManager.gm.player.equippedWeapon.name == GameObject.Find("Slot3Button").GetComponentInChildren<Text>().text)
            {
                GameObject.Find("Slot1Button").GetComponentInChildren<Outline>().effectColor = Color.black;
                GameObject.Find("Slot2Button").GetComponentInChildren<Outline>().effectColor = Color.black;
                GameObject.Find("Slot3Button").GetComponentInChildren<Outline>().effectColor = Color.white;
            }
        }

        // Update Character sheet
        GameObject.Find("Name").GetComponentInChildren<Text>().text = "Name: " + GameManager.gm.player.playerName;
        GameObject.Find("Class").GetComponentInChildren<Text>().text = "Class: " + GameManager.gm.player.playerClass;
        GameObject.Find("Level").GetComponentInChildren<Text>().text = "Level: " + GameManager.gm.player.playerLevel.ToString();
        GameObject.Find("TNL").GetComponentInChildren<Text>().text = "XP TNL: " + GameManager.gm.player.xpTNL.ToString();
        GameObject.Find("Strength").GetComponentInChildren<Text>().text = "Strength: " + GameManager.gm.player.strength.ToString();
        GameObject.Find("Dexterity").GetComponentInChildren<Text>().text = "Dexterity: " + GameManager.gm.player.dexterity.ToString();
        GameObject.Find("Intelligence").GetComponentInChildren<Text>().text = "Intelligence: " + GameManager.gm.player.intelligence.ToString();
        GameObject.Find("ArmorPen").GetComponentInChildren<Text>().text = "Armor Pen: " + GameManager.gm.player.armorPen.ToString();
        GameObject.Find("MagicPen").GetComponentInChildren<Text>().text = "Magic Pen: " + GameManager.gm.player.magicPen.ToString();
        GameObject.Find("CritChance").GetComponentInChildren<Text>().text = "Crit Chance: " + GameManager.gm.player.critChance.ToString() + "%";
        GameObject.Find("CritDamage").GetComponentInChildren<Text>().text = "Crit Damage: " + GameManager.gm.player.critDamage.ToString() + "%";
        GameObject.Find("Gold").GetComponentInChildren<Text>().text = "Gold: " + GameManager.gm.player.playerGold.ToString();
        GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + GameManager.gm.player.talentPoints.ToString();
    }

    // Remove item from ui component and set to default
    private void RemoveItem(GameObject gameObject)
    {
        gameObject.GetComponent<ItemPanel>().item = null;
        gameObject.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("None");
        gameObject.transform.SetParent(startParent);
        gameObject.GetComponentInParent<Outline>().effectColor = Color.black;
    }

    // Event for mouseover on item panel
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Mouse enter");
        // Create offsets so the tooltip doesn't go off the screen
        if (Input.mousePosition.y < 240)
            offset.y = 140;
        else
            offset.y = -154;

        // Set the tooltip values from the item
        if (item != null)
        {
            // Instantiate the tooltip
            tooltip = Instantiate(tooltipPrefab, Input.mousePosition + offset, Quaternion.identity, transform);
            // Set parent to InventoryPanel so it isn't placed behind item panels
            tooltip.transform.SetParent(GameObject.Find("InventoryPanel").transform);
            // Rarities
            GameObject.Find("TooltipName").GetComponent<Text>().color = item.GetRarityColor();
            // Set the tooltipo name and tooltip text
            GameObject.Find("TooltipName").GetComponentInChildren<Text>().text = item.name;
            GameObject.Find("Tooltip").GetComponentInChildren<Text>().text = item.GetToolTip();
        }

    }

    // Event for mouseexit that destroys the tooltip
    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Mouse exit");
        // Destroy tooltip
        if (tooltip)
            Destroy(tooltip, 0f);
    }

    // Update the position of the tooltip while we hover
    void Update()
    {
        // Check if tooltip exists
        if (tooltip)
        {
            // Create offsets so the tooltip doesn't go off the screen
            if (Input.mousePosition.y < 240)
                offset.y = 140;
            else
                offset.y = -154;

            // Update the tooltip position as the mouse moves inside
            tooltip.transform.position = Input.mousePosition + offset;
            // Rarities
            GameObject.Find("TooltipName").GetComponent<Text>().color = item.GetRarityColor();
            // Set the tooltipo name and tooltip text
            GameObject.Find("TooltipName").GetComponentInChildren<Text>().text = item.name;
            GameObject.Find("Tooltip").GetComponentInChildren<Text>().text = item.GetToolTip();
        }
    }
}
