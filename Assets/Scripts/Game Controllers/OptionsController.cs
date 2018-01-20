using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour {

    [SerializeField]
    private GameObject easySign, mediumSign, hardSign;

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


    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
