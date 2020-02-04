using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUIController : MonoBehaviour
{
    public static HighScoreUIController instance;
    public List<Text> nameText = new List<Text>();
    public List<Text> scoreText = new List<Text>();
    public GameObject popUp;

    public void SetNameText(int idx, string inputString)
    {
        nameText[idx].text = inputString;
    }

    public void SetScoreText(int idx, int inputInt)
    {
        scoreText[idx].text = inputInt.ToString();
    }

    public void DeleteHighScore()
    {
        for (int i = 0; i < HighScoreController.instance.highScoreInt.Count; i++)
        {
            PlayerPrefs.DeleteKey("HighScoreName" + i);
            PlayerPrefs.DeleteKey("HighScoreInt" + i);
        }

        ResetHighScoreText();
        SetPopUp(false);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void SetPopUp(bool setActive)
    {
        popUp.SetActive(setActive);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    private void ResetHighScoreText()
    {
        int idx = 0;
        for (int i = HighScoreController.instance.highScoreInt.Count - 1; i >= 0; i--)
        {
            SetScoreText(idx, PlayerPrefs.GetInt("HighScoreInt" + i));
            SetNameText(idx, PlayerPrefs.GetString("HighScoreName" + i));
            idx++;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        ResetHighScoreText();
    }
}
