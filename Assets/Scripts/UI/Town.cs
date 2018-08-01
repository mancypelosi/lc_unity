using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Town scene, this code attached to Canvas
public class Town : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // Play music
        SoundManager.sm.PlayMusic(Resources.Load<AudioClip>("Music/townmusic"));
    }

    public void Store()
    {
        Item item = SpawnItem();
        SetItem(GameObject.Find("StoreItem0"), item);
        GameObject.Find("StoreItem0Name").GetComponent<Text>().text = item.name;
        GameObject.Find("StoreItem0Value").GetComponent<Text>().text = item.buyValue.ToString() + "G";

        item = SpawnItem();
        SetItem(GameObject.Find("StoreItem1"), item);
        GameObject.Find("StoreItem1Name").GetComponent<Text>().text = item.name;
        GameObject.Find("StoreItem1Value").GetComponent<Text>().text = item.buyValue.ToString() + "G";

        item = SpawnItem();
        SetItem(GameObject.Find("StoreItem2"), item);
        GameObject.Find("StoreItem2Name").GetComponent<Text>().text = item.name;
        GameObject.Find("StoreItem2Value").GetComponent<Text>().text = item.buyValue.ToString() + "G";
    }

    // Activate worlds on the WorldPanel based on player world booleans
    public void SetGates()
    {
        // Have to traverse transforms to find non-active objects
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

    // Load MainMenu scene
    public void MainMenu()
    {
        SoundManager.sm.StopMusic();
        // Load scene 'MainMenu'
        GameManager.gm.LoadScene("MainMenu");
    }

    // Load Main scene and set world name from button
    public void LoadWorld(Text inputWorld)
    {
        SoundManager.sm.StopMusic();

        // Update world settings
        Debug.Log("World: " + inputWorld.text);
        GameManager.gm.world = GameManager.gm.world.GetWorldByName(GameManager.gm.world.WorldList(), inputWorld.text);

        // Load scene 'Main'
        GameManager.gm.LoadScene("Battle");
    }

    // Spawn an item and rng check to add magical properties
    public Item SpawnItem()
    {
        World world = GameManager.gm.world;
        Debug.Log("World: " + world.worldName);
        if (world.worldName == "")
        {
            world = world.WorldList()[0];
        }
        //Debug.Log("Spawn item");
        Item item = null;
        Modifier mod = new Modifier();

        // Rng weapon or armor
        int type = Random.Range(0, 2);
        // Create weapon
        if (type == 0)
        {
            Weapon weapon = new Weapon();
            List<Weapon> wl = new List<Weapon>();
            // Rarity weighting
            int rarityRng = Random.Range(0, 100);
            Debug.Log("Weapon rarity: " + rarityRng);
            if (rarityRng > 95)
                wl = weapon.GetListByRarity(world.weaponList, Item.Rarity.Set);
            else if (rarityRng > 90)
                wl = weapon.GetListByRarity(world.weaponList, Item.Rarity.Legendary);
            else if (rarityRng > 65)
                wl = weapon.GetListByRarity(world.weaponList, Item.Rarity.Uncommon);
            else
                wl = weapon.GetListByRarity(world.weaponList, Item.Rarity.Common);
            int listCount = wl.Count;
            int rng = Random.Range(0, listCount);
            int id = wl[rng].itemId;
            item = weapon.GetWeaponById(weapon.WeaponList(), id);
        }
        // Create armor
        else if (type == 1)
        {
            Armor armor = new Armor();
            List<Armor> al = world.armorList;
            // Rarity weighting
            int rarityRng = Random.Range(0, 100);
            Debug.Log("Armor rarity: " + rarityRng);
            if (rarityRng > 95)
                al = armor.GetListByRarity(world.armorList, Item.Rarity.Set);
            else if (rarityRng > 90)
                al = armor.GetListByRarity(world.armorList, Item.Rarity.Legendary);
            else
                al = armor.GetListByRarity(world.armorList, Item.Rarity.Uncommon);
            // Armor does not contain common rarities
            int listCount = al.Count;
            int rng = Random.Range(0, listCount);
            int id = al[rng].itemId;
            item = armor.GetArmorById(armor.ArmorList(), id);
        }

        // Check to add prefix
        if (Random.Range(0, 100) < GameManager.gm.player.magicFind)
        {
            int listCount = world.prefixList.Count;
            int rng = Random.Range(0, listCount);
            int id = world.prefixList[rng].modId;
            item.AddModifier(mod.GetModifierById(mod.PrefixList(), id));
        }
        // Check to add suffix
        if (Random.Range(0, 100) < GameManager.gm.player.magicFind)
        {
            int listCount = world.suffixList.Count;
            int rng = Random.Range(0, listCount);
            int id = world.suffixList[rng].modId;
            item.AddModifier(mod.GetModifierById(mod.SuffixList(), id));
        }
        return item;
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
