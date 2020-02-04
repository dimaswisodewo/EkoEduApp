using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUIController : MonoBehaviour
{
    public static QuizUIController instance;
    [Header("Text")]
    public Text questionText;
    public Text titleText;
    public Text timertext;
    public Text buttonText;
    public Text popUpText;
    public Text scoreText;
    //public List<Text> choiceText;
    [Header("Canvas Group")]
    public CanvasGroup choiceGroup;
    //[Header("Image")]
    [HideInInspector] public Image selectedButtonImage;
    [Header("Library Choice")]
    public List<Text> libraryChoiceText = new List<Text>();
    public List<Image> libraryChoiceButton = new List<Image>();
    [Header("Game Object")]
    public GameObject popUpPanel;

    public void SetQuestionText(string inputString)
    {
        SetText(questionText, inputString);
    }

    public void SetChoiceText(int index, string inputString)
    {
        SetText(libraryChoiceText[index], inputString);
    }

    public void SetTimerText(string inputString)
    {
        SetText(timertext, inputString);
    }

    public void SetTitleText(string inputString)
    {
        SetText(titleText, inputString);
    }

    public void SetSubmitText(string inputString)
    {
        SetText(buttonText, inputString);
    }

    public void SetScoreText(string inputString)
    {
        SetText(scoreText, inputString);
    }

    public void SetText(Text inputText, string inputString)
    {
        inputString = inputString.Replace("\\n", "\n");
        inputText.text = inputString;
    }

    public void SetChoiceButtonInterractable(bool setActive)
    {
        choiceGroup.interactable = setActive;
    }

    public void SetPopUpPanelActive(bool setActive)
    {
        if (setActive == true)
        {
            SetText(popUpText, "Berhasil Menyelesaikan Kuis\ndengan Skor " + QuizController.instance.score +
                "\nMenjawab " + QuizController.instance.numOfCorrectAnswer +  " Benar dari  20 Pertanyaan");
        }

        popUpPanel.SetActive(setActive);
    }

    public void ResetAllButtonColor()
    {
        for (int i = 0; i < libraryChoiceButton.Count; i++)
        {
            SetImageColor(libraryChoiceButton[i], BUTTON_COLOR.WHITE);
        }

        selectedButtonImage = null;
    }

    public void SetSelectedButtonColor(BUTTON_COLOR inputColor)
    {
        if (selectedButtonImage != null)
        {
            SetImageColor(selectedButtonImage, inputColor);
        }
    }

    private void SetImageColor(Image inputImage, BUTTON_COLOR buttonColor)
    {
        switch (buttonColor)
        {
            case BUTTON_COLOR.GREEN:
                inputImage.color = new Color32(155, 197, 61, 255);
                break;

            case BUTTON_COLOR.RED:
                inputImage.color = new Color32(244, 91, 105, 255);
                break;

            case BUTTON_COLOR.YELLOW:
                inputImage.color = new Color32(246, 205, 97, 255);
                break;

            case BUTTON_COLOR.WHITE:
                inputImage.color = Color.white;
                break;
        }
    }

    //private string ManageText(string InText)
    //{
    //    int CIndex = InText.IndexOf("\\n"); // Gets the Index of yur "\n" Char
    //    InText = InText.Remove(CIndex, 2); // Removes "\n from original String"
    //    InText = InText.Insert(CIndex, "\n"); // Adds the actual New Line symbol
    //    return InText;
    //}

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        SetPopUpPanelActive(false);
    }
}
