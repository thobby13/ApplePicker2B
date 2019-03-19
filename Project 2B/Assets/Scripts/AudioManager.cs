using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Comment added to test merging branches

public class AudioManager : MonoBehaviour
{
    public Slider Music;
    public Slider Sounds;

    public AudioSource BG_Music;
    public AudioSource PopEffect;
    public AudioSource CrushEffect;
    public bool paused = false;
    public bool pausing = false;

    public void MuteBGMusic()
    {
        paused = !paused;
        if (paused)
        {
            BG_Music.volume = 0;
            Music.value = 0;
            PlayerPrefs.SetString("Muted", "Yes");
        }
        else
        {
            BG_Music.volume = PlayerPrefs.GetFloat("Music Volume");
            Music.value = PlayerPrefs.GetFloat("Music Volume");
            PlayerPrefs.SetString("Muted", "No");
        }
    }

    public void MuteSounds()
    {
        pausing = !pausing;
        if (pausing)
        {
            PopEffect.volume = 0;
            CrushEffect.volume = 0;
            Sounds.value = 0;
            PlayerPrefs.SetString("Muting", "Yes");
        }
        else
        {
            PopEffect.volume = PlayerPrefs.GetFloat("SFX Volume");
            CrushEffect.volume = PlayerPrefs.GetFloat("SFX Volume");
            Sounds.value = PlayerPrefs.GetFloat("SFX Volume");
            PlayerPrefs.SetString("Muting", "No");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("Muted") == "Yes")
        {
            BG_Music.volume = 0f;
            Music.value = 0f;
        }
        else
        {
            BG_Music.volume = PlayerPrefs.GetFloat("Music Volume");
            Music.value = PlayerPrefs.GetFloat("Music Volume");
        }

        if (PlayerPrefs.GetString("Muting") == "Yes")
        {
            PopEffect.volume = 0f;
            CrushEffect.volume = 0f;
            Sounds.value = 0f;
        }
        else
        {
            PopEffect.volume = PlayerPrefs.GetFloat("SFX Volume");
            Sounds.value = PlayerPrefs.GetFloat("SFX Volume");
            CrushEffect.volume = PlayerPrefs.GetFloat("SFX Volume");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
