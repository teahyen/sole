using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public AudioSource Issaudio;

    private float backVol = 1f;
    private void Start()
    {
        backVol = PlayerPrefs.GetFloat("backvol", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        SoundSlider();
    }
    public void SoundSlider()
    {
        PlayerPrefs.SetFloat("backvol", backVol);
        this.Issaudio.loop = false;
        DontDestroyOnLoad(gameObject);
    }
}
