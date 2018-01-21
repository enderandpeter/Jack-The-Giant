using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class OptionsController : MonoBehaviour
{

    [SerializeField]
    private GameObject easySign, mediumSign, hardSign;

    private static Dictionary<string, int[]> screenSizes = new Dictionary<string, int[]>(){
        {"big", new int[] {512, 1024}},
        {"medium", new int[] {320, 640}},
        {"small", new int[] {256, 512}}
    };

	// Use this for initialization
	void Start () {
        SetTheDifficulty();
    }

    void SetInitialDifficulty(string difficulty)
    {
        easySign.SetActive(false);
        mediumSign.SetActive(false);
        hardSign.SetActive(false);

        switch (difficulty)
        {
            case "easy":
                easySign.SetActive(true);
                break;

            case "medium":
                mediumSign.SetActive(true);
                break;

            case "hard":
                hardSign.SetActive(true);
                break;
        }
    }

    void SetTheDifficulty()
    {
        if (GamePreferences.GetEasyDifficultyState() == 1)
        {
            SetInitialDifficulty("easy");
        }

        if (GamePreferences.GetMediumDifficultyState() == 1)
        {
            SetInitialDifficulty("medium");
        }

        if (GamePreferences.GetHardDifficultyState() == 1)
        {
            SetInitialDifficulty("hard");
        }
    }

    public void EasyDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(1);
        GamePreferences.SetMediumDifficultyState(0);
        GamePreferences.SetHardDifficultyState(0);

        easySign.SetActive(true);
        mediumSign.SetActive(false);
        hardSign.SetActive(false);
    }

    public void MediumDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(0);
        GamePreferences.SetMediumDifficultyState(1);
        GamePreferences.SetHardDifficultyState(0);

        easySign.SetActive(false);
        mediumSign.SetActive(true);
        hardSign.SetActive(false);
    }

    public void HardDifficulty()
    {
        GamePreferences.SetEasyDifficultyState(0);
        GamePreferences.SetMediumDifficultyState(0);
        GamePreferences.SetHardDifficultyState(1);

        easySign.SetActive(false);
        mediumSign.SetActive(false);
        hardSign.SetActive(true);
    }

    public void SetSmallScreenResolution(){
        SetScreenResolution("small");
    }

    public void SetMediumScreenResolution()
    {
        SetScreenResolution("medium");
    }

    public void SetBigScreenResolution()
    {
        SetScreenResolution("big");
    }

    public static void SetScreenResolution(string size){
        try
        {
            Screen.SetResolution(screenSizes[size][0], screenSizes[size][1], false);
            GamePreferences.SetScreenResolution(size);
        }
        catch (KeyNotFoundException e){
            
        }

    }


    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
