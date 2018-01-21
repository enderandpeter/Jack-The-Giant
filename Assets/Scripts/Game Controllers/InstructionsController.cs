using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class InstructionsController : MonoBehaviour {

    //public Dictionary<string, Image> instructionDictionary;

    [SerializeField]
    string[] instructions;

    [SerializeField]
    Sprite[] instructionImages;

    [SerializeField]
    Text instructionText;

    [SerializeField]
    Image instructionImage;

    [SerializeField]
    GameObject leftButton;

    [SerializeField]
    GameObject rightButton;

    [SerializeField]
    int currentIndex;

    void Start()
    {
        currentIndex = 0;
        LoadData();
    }

    public void NavLeft()
    {
        currentIndex--;
        LoadData();
    }

    public void NavRight()
    {
        currentIndex++;
        LoadData();
    }

    private void LoadData()
    {
        leftButton.SetActive(true);
        rightButton.SetActive(true);

        if (currentIndex <= instructions.GetUpperBound(0) && currentIndex >= instructions.GetLowerBound(0))
        {
            instructionText.text = instructions[currentIndex];
        }

        if (currentIndex <= instructionImages.GetUpperBound(0) && currentIndex >= instructionImages.GetLowerBound(0))
        {
            instructionImage.sprite = instructionImages[currentIndex];
        }

        if (currentIndex == instructions.GetLowerBound(0))
        {
            leftButton.SetActive(false);
        }

        if (currentIndex == instructions.GetUpperBound(0))
        {
            rightButton.SetActive(false);
        }
    }

    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
