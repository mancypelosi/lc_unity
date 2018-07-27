using UnityEngine;

public class SoundManager : MonoBehaviour {

    // Public properties
    public static SoundManager sm;
    public AudioSource fxSource;
    public AudioSource musicSource;
    public float sfxVolume = 0.2f;
    public float musicVolume = 0.1f;

	// Use this for initialization
	void Start () {
		
	}

    // While SoundManager is running don't destroy static ref
    void Awake()
    {
        if (sm == null)
        {
            DontDestroyOnLoad(gameObject);
            sm = this;
        }
        else if (sm != this)
        {
            Destroy(gameObject);
        }

    }

    // Play sound effect once
    public void PlaySoundFX(AudioClip clip)
    {
        //Debug.Log("Sfx Volume: " + sfxVolume);
        float pitch = 1;
        fxSource.pitch = pitch;
        fxSource.volume = sfxVolume;
        fxSource.clip = clip;
        fxSource.Play();
    }

    // Play sound effect for attacks with pitch adjustments
    public void PlaySoundFX(AudioClip clip, bool weak, bool resist, bool crit)
    {
        //Debug.Log("Pitch: " + fxSource.pitch);
        // Set pitch based on type of attack
        float pitch = 1;
        if (crit)
            pitch = 2.0f;
        else if (weak)
            pitch = 1.25f;
        else if (resist)
            pitch = 0.75f;
        // Adjust pitch and volume
        fxSource.pitch = pitch;
        fxSource.volume = sfxVolume;
        fxSource.clip = clip;
        fxSource.Play();
    }

    // Play looping music
    public void PlayMusic(AudioClip clip)
    {
        //Debug.Log("Music Volume: " + musicVolume);
        musicSource.volume = musicVolume;
        musicSource.clip = clip;
        musicSource.Play();
    }

    // Stop music
    public void StopMusic()
    {
        musicSource.Stop();
    }
}
