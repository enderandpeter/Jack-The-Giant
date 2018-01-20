using UnityEngine;

public static class GamePreferences {

    public static string EasyDifficulty = "EasyDifficulty";
    public static string MediumDifficulty = "MediumDifficulty";
    public static string HardDifficulty = "HardDifficulty";

    public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
    public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
    public static string HardDifficultyHighScore = "HardDifficultyHighScore";

    public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
    public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
    public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

    public static string IsMusicOn = "IsMusicOn";

    /*
     * 1 is on and 0 is off.
     */

    public static int GetMusicState()
    {
        return PlayerPrefs.GetInt(IsMusicOn);
    }

    public static void SetMusicState(int state)
    {
        PlayerPrefs.SetInt(IsMusicOn, state);
    }

    public static void SetEasyDifficultyState(int state)
    {
        PlayerPrefs.SetInt(EasyDifficulty, state);
    }

    public static int GetEasyDifficultyState()
    {
        return PlayerPrefs.GetInt(EasyDifficulty);
    }

    public static void SetMediumDifficultyState(int state)
    {
        PlayerPrefs.SetInt(MediumDifficulty, state);
    }

    public static int GetMediumDifficultyState()
    {
        return PlayerPrefs.GetInt(MediumDifficulty);
    }

    public static void SetHardDifficultyState(int state)
    {
        PlayerPrefs.SetInt(HardDifficulty, state);
    }

    public static int GetHardDifficultyState()
    {
        return PlayerPrefs.GetInt(HardDifficulty);
    }

    public static int GetEasyDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(EasyDifficultyHighScore);
    }

    public static void SetEasyDifficultyHighScore(int score)
    {
        PlayerPrefs.SetInt(EasyDifficultyHighScore, score);
    }

    public static int GetMediumDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(MediumDifficultyHighScore);
    }

    public static void SetMediumDifficultyHighScore(int score)
    {
        PlayerPrefs.SetInt(MediumDifficultyHighScore, score);
    }

    public static int GetHardDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(HardDifficultyHighScore);
    }

    public static void SetHardDifficultyHighScore(int score)
    {
        PlayerPrefs.SetInt(HardDifficultyHighScore, score);
    }

    public static int GetEasyDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(EasyDifficultyCoinScore);
    }

    public static void SetEasyDifficultyCoinScore(int score)
    {
        PlayerPrefs.SetInt(EasyDifficultyCoinScore, score);
    }

    public static int GetMediumDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(MediumDifficultyCoinScore);
    }

    public static void SetMediumDifficultyCoinScore(int score)
    {
        PlayerPrefs.SetInt(MediumDifficultyCoinScore, score);
    }

    public static int GetHardDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(HardDifficultyCoinScore);
    }

    public static void SetHardDifficultyCoinScore(int score)
    {
        PlayerPrefs.SetInt(HardDifficultyCoinScore, score);
    }
}
