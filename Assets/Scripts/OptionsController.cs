using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private float defaultVolume = 0.8f;
    
    [SerializeField] private Slider difficultySlider;
    [SerializeField] private float defaultDifficulty;

    private void Start()
    {
        volumeSlider.value = PlayerPrefController.GetMasterVolume();
        difficultySlider.value = PlayerPrefController.GetDifficulty();
    }

    private void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefController.SetMasterVolume(volumeSlider.value);
        PlayerPrefController.SetDifficluty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }
}
