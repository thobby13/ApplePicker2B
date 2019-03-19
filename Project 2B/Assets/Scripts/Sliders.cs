using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour
{
    public Slider Music;
    public Slider Sounds;

    public AudioSource BGMusic;
    public AudioSource PopEffect;
    public AudioSource CrushEffect;

    private float defaultmusic = 0.5f;
    private float defaultsounds = 0.5f;

    public void MusicValues()
    {
        BGMusic.volume = Music.value;
        if (Music.value != 0)
            PlayerPrefs.SetFloat("Music Volume", Music.value);
    }

    public void EffectsValues()
    {
        PopEffect.volume = Sounds.value;
        CrushEffect.volume = Sounds.value;
        if (Sounds.value != 0)
        {
            PlayerPrefs.SetFloat("SFX Volume", CrushEffect.volume);
            PlayerPrefs.SetFloat("SFX Volume", PopEffect.volume);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Music Volume"))
        {
            BGMusic.volume = defaultmusic;
        }

        if (!PlayerPrefs.HasKey("SFX Volume"))
        {
            PopEffect.volume = defaultsounds;
            CrushEffect.volume = defaultsounds;
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
