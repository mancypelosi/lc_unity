using Corale.Colore.Core;
using Corale.Colore.Razer.Keyboard;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChromaManager : MonoBehaviour {

    private void OnEnable()
    {
        InitializeKeys();
    }

    public static void InitializeKeys()
    {
        Chroma.Instance.SetAll(Corale.Colore.Core.Color.White);

        if (GameManager.gm != null)
        {
            Debug.Log("Chroma Class: " + GameManager.gm.player.playerClass);
            if (GameManager.gm.player.playerClass == "Warrior")
                Chroma.Instance.SetAll(Corale.Colore.Core.Color.Red);
            else if (GameManager.gm.player.playerClass == "Rogue")
                Chroma.Instance.SetAll(Corale.Colore.Core.Color.Green);
            else if (GameManager.gm.player.playerClass == "Mage")
                Chroma.Instance.SetAll(Corale.Colore.Core.Color.Blue);
        }

        if (SceneManager.GetActiveScene().name == "Battle")
        {
            // Weapon Keys
            Keyboard.Instance[Key.D1] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.D2] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.D3] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num1] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num2] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num3] = Corale.Colore.Core.Color.Black;

            // Health Keys
            Keyboard.Instance[Key.F1] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F2] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F3] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F4] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F5] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F6] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F7] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F8] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F9] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F10] = Corale.Colore.Core.Color.Green;
            Keyboard.Instance[Key.F11] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.F12] = Corale.Colore.Core.Color.Black;

            // Helper Keys
            Keyboard.Instance[Key.T] = Corale.Colore.Core.Color.Orange;
            Keyboard.Instance[Key.L] = Corale.Colore.Core.Color.Orange;
            Keyboard.Instance[Key.I] = Corale.Colore.Core.Color.Orange;
        }
    }

    public static void InitializeWeapon()
    {
        if (GameManager.gm.player.equippedWeapon.name == GameObject.Find("Slot1Button").GetComponentInChildren<Text>().text)
        {
            Keyboard.Instance[Key.D1] = Corale.Colore.Core.Color.White;
            Keyboard.Instance[Key.Num1] = Corale.Colore.Core.Color.White;
        }
        else if (GameManager.gm.player.equippedWeapon.name == GameObject.Find("Slot2Button").GetComponentInChildren<Text>().text)
        {
            Keyboard.Instance[Key.D2] = Corale.Colore.Core.Color.White;
            Keyboard.Instance[Key.Num2] = Corale.Colore.Core.Color.White;
        }
        else if (GameManager.gm.player.equippedWeapon.name == GameObject.Find("Slot3Button").GetComponentInChildren<Text>().text)
        {
            Keyboard.Instance[Key.D3] = Corale.Colore.Core.Color.White;
            Keyboard.Instance[Key.Num3] = Corale.Colore.Core.Color.White;
        }
    }

    public static void UpdateWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            Keyboard.Instance[Key.D1] = Corale.Colore.Core.Color.White;
            Keyboard.Instance[Key.Num1] = Corale.Colore.Core.Color.White;
            Keyboard.Instance[Key.D2] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num2] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.D3] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num3] = Corale.Colore.Core.Color.Black;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            Keyboard.Instance[Key.D1] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num1] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.D2] = Corale.Colore.Core.Color.White;
            Keyboard.Instance[Key.Num2] = Corale.Colore.Core.Color.White;
            Keyboard.Instance[Key.D3] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num3] = Corale.Colore.Core.Color.Black;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            Keyboard.Instance[Key.D1] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num1] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.D2] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.Num2] = Corale.Colore.Core.Color.Black;
            Keyboard.Instance[Key.D3] = Corale.Colore.Core.Color.White;
            Keyboard.Instance[Key.Num3] = Corale.Colore.Core.Color.White;
        }
    }

    public static void InitializeHealthBar()
    {
        Keyboard.Instance[Key.F1] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F2] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F3] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F4] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F5] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F6] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F7] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F8] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F9] = Corale.Colore.Core.Color.Green;
        Keyboard.Instance[Key.F10] = Corale.Colore.Core.Color.Green;
    }

    public static void UpdateHealthBar(float percent)
    {
        //Debug.Log("Percent: " + percent);
        for (Key keyCode = Key.F1; keyCode <= Key.F10; keyCode++)
        {
            float calc = (keyCode.GetHashCode() - 2) * 0.1f;
            //Debug.Log("Initial: " + (keyCode.GetHashCode() - 281));
            //Debug.Log("Calc: " + calc);
            // 282 - 291
            if (calc > percent)
            {
                Keyboard.Instance[keyCode] = Corale.Colore.Core.Color.Red;
            }
        }
    }

    public static void LevelUp()
    {
        //Chroma.Instance.SetAll(Corale.Colore.Core.Color.HotPink);
        for (Key keyCode = Key.Macro2; keyCode <= Key.NumDecimal; keyCode++)
        {
            if (Key.IsDefined(typeof(Key), keyCode))
            {
                Debug.Log(keyCode);
                Keyboard.Instance[keyCode] = Corale.Colore.Core.Color.HotPink;
            }
        }
    }
}
