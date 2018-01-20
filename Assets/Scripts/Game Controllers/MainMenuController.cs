﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {
    [SerializeField]
    private Button musicBtn;

    [SerializeField]
    private Sprite[] musicIcons;

    // Use this for initialization
    void Start()
    {
        CheckToPlayTheMusic();
    }

    void CheckToPlayTheMusic()
    {
        if (GamePreferences.GetMusicState() == 1) {
            MusicController.instance.PlayMusic(true);
            musicBtn.image.sprite = musicIcons[1];
        } else
        {
            MusicController.instance.PlayMusic(false);
            musicBtn.image.sprite = musicIcons[0];
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
        GameManager.instance.gameStartedFromMainMenu = true;
    }

    public void HighscoreMenu()
    {
        SceneManager.LoadScene("HighScore");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MusicButton()
    {
        if (GamePreferences.GetMusicState() == 0)
        {
            GamePreferences.SetMusicState(1);
            MusicController.instance.PlayMusic(true);
            musicBtn.image.sprite = musicIcons[1];
        } else if (GamePreferences.GetMusicState() == 1)
        {
            GamePreferences.SetMusicState(0);
            MusicController.instance.PlayMusic(false);
            musicBtn.image.sprite = musicIcons[0];
        }
    }
	
}
