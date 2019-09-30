using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public bool isFullScreen;
    public AudioMixer am;

    public void FullScreenToggle()
    {
        isFullScreen = !Screen.fullScreen;
        Screen.fullScreen = isFullScreen;
    }

    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }

    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
}
