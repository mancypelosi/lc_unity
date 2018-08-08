using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

// MainMenu scene, this code attached to MenuPanel
public class SettingsMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Set fullscreen to false
        Toggle fullscreenToggle = GameObject.Find("FullscreenToggle").GetComponent<Toggle>();
        fullscreenToggle.isOn = GameManager.gm.prefs.fullscreen;

        // Set sound
        Toggle soundToggle = GameObject.Find("SoundToggle").GetComponent<Toggle>();
        soundToggle.isOn = GameManager.gm.prefs.sfx;

        Toggle musicToggle = GameObject.Find("MusicToggle").GetComponent<Toggle>();
        musicToggle.isOn = GameManager.gm.prefs.music;
    }

    // Set sound to on or off
    public void SetSfx(bool sound)
    {
        GameManager.gm.prefs.sfx = sound;
        Debug.Log("Sound: " + sound);
        if (sound)
        {
            SoundManager.sm.sfxVolume = 0.2f;

        }
        else
        {
            SoundManager.sm.sfxVolume = 0f;
        }
    }

    // Set sound to on or off
    public void SetMusic(bool sound)
    {
        GameManager.gm.prefs.music = sound;
        Debug.Log("Sound: " + sound);
        if (sound)
        {
            SoundManager.sm.musicVolume = 0.1f;

        }
        else
        {
            SoundManager.sm.musicVolume = 0f;
        }
    }

    // Set the game to fullscreen (currently does not come out of fullscreen)
    public void SetFullscreen(bool fullscreen)
    {
        // Check to make no change if there is no change in bool
        if (Screen.fullScreen != fullscreen)
        {
            GameManager.gm.prefs.fullscreen = fullscreen;
            Debug.Log("Fullscreen: " + fullscreen);
            Screen.fullScreen = fullscreen;
            if (Screen.fullScreen)
            {
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
            }
            else
            {
                Screen.fullScreenMode = FullScreenMode.Windowed;
            }
        }
    }

}
