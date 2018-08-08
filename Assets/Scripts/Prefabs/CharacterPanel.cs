using UnityEngine;
using UnityEngine.UI;

// This code attached to the CharacterPanel prefab object
public class CharacterPanel : MonoBehaviour {

    private Player player;

    // Use this for initialization
    void Start () {
        // Set player
        player = GameManager.gm.player;

        // Character sheet
        GameObject.Find("Name").GetComponentInChildren<Text>().text = "Name: " + player.name;
        GameObject.Find("Class").GetComponentInChildren<Text>().text = "Class: " + player.playerClass;
        GameObject.Find("Level").GetComponentInChildren<Text>().text = "Level: " + player.level.ToString();
        GameObject.Find("TNL").GetComponentInChildren<Text>().text = "XP TNL: " + player.xpTNL.ToString();
        GameObject.Find("Strength").GetComponentInChildren<Text>().text = "Strength: " + player.strength.ToString() + " (" + player.modifiedStrength.ToString() + ")";
        GameObject.Find("Dexterity").GetComponentInChildren<Text>().text = "Dexterity: " + player.dexterity.ToString() + " (" + player.modifiedDexterity.ToString() + ")";
        GameObject.Find("Intelligence").GetComponentInChildren<Text>().text = "Intelligence: " + player.intelligence.ToString() + " (" + player.modifiedIntelligence.ToString() + ")";
        GameObject.Find("ArmorPen").GetComponentInChildren<Text>().text = "Armor Pen: " + player.armorPen.ToString();
        GameObject.Find("MagicPen").GetComponentInChildren<Text>().text = "Magic Pen: " + player.magicPen.ToString();
        GameObject.Find("CritChance").GetComponentInChildren<Text>().text = "Crit Chance: " + player.critChance.ToString() + "%";
        GameObject.Find("CritDamage").GetComponentInChildren<Text>().text = "Crit Damage: " + player.critDamage.ToString() + "%";
        GameObject.Find("Gold").GetComponentInChildren<Text>().text = "Gold: " + player.gold.ToString();
        GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints.ToString();
    }

    public void Save()
    {
        GameManager.gm.Save();
    }

    public void UpgradeStrength()
    {
        if (player.talentPoints > 0)
        {
            player.strength += 5;
            player.talentPoints--;
            GameObject.Find("Strength").GetComponentInChildren<Text>().text = "Strength: " + player.strength.ToString() + " (" + player.modifiedStrength.ToString() + ")";
            GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints.ToString();
        }
    }

    public void UpgradeDexterity()
    {
        if (player.talentPoints > 0)
        {
            player.dexterity += 5;
            player.talentPoints--;
            GameObject.Find("Dexterity").GetComponentInChildren<Text>().text = "Dexterity: " + player.dexterity.ToString() + " (" + player.modifiedDexterity.ToString() + ")";
            GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints.ToString();
        }
    }

    public void UpgradeIntelligence()
    {
        if (player.talentPoints > 0)
        {
            player.intelligence += 5;
            player.talentPoints--;
            GameObject.Find("Intelligence").GetComponentInChildren<Text>().text = "Intelligence: " + player.intelligence.ToString() + " (" + player.modifiedIntelligence.ToString() + ")";
            GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints.ToString();
        }
    }

    public void UpgradeArmorPen()
    {
        if (player.talentPoints > 0)
        {
            player.armorPen += 5;
            player.talentPoints--;
            GameObject.Find("ArmorPen").GetComponentInChildren<Text>().text = "Armor Pen: " + player.armorPen.ToString();
            GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints.ToString();
        }
    }

    public void UpgradeMagicPen()
    {
        if (player.talentPoints > 0)
        {
            player.magicPen += 5;
            player.talentPoints--;
            GameObject.Find("MagicPen").GetComponentInChildren<Text>().text = "Magic Pen: " + player.magicPen.ToString();
            GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints.ToString();
        }
    }

    public void UpgradeCritChance()
    {
        if (player.talentPoints > 0)
        {
            player.critChance += 1;
            player.talentPoints--;
            GameObject.Find("CritChance").GetComponentInChildren<Text>().text = "Crit Chance: " + player.critChance.ToString() + "%"; ;
            GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints.ToString();
        }
    }

    public void UpgradeCritDamage()
    {
        if (player.talentPoints > 0)
        {
            player.critDamage += 5;
            player.talentPoints--;
            GameObject.Find("CritDamage").GetComponentInChildren<Text>().text = "Crit Damage: " + player.critDamage.ToString() + "%";
            GameObject.Find("TalentButton").GetComponentInChildren<Text>().text = "TALENTS: " + player.talentPoints.ToString();
        }
    }

}
