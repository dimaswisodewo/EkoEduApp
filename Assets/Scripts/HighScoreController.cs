using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreController : MonoBehaviour
{
    public static HighScoreController instance;
    public List<string> highScoreName = new List<string>();
    public List<int> highScoreInt = new List<int>();
    public int validScore = -1;
    
    public void SetHighScore(int score = -1)
    {
        // get highscore from playerprefs
        if (score == -1)
        {
            string name = "kosong";
            int skor = -1;
            for (int i = 0; i < 8; i++)
            {
                name = PlayerPrefs.GetString("HighScoreName" + i);
                skor = PlayerPrefs.GetInt("HighScoreInt" + i);
                highScoreName.Add(name);
                highScoreInt.Add(skor);
                Debug.Log(i + skor);
            }
        }
        // set highscore
        else
        {
            if (score > highScoreInt[0])
            {
                highScoreInt[0] = score;
                highScoreName[0] = PlayerPrefs.GetString("Profile");
            }
        }

        // sort highscore
        for (int i = (highScoreInt.Count - 1); i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (highScoreInt[j - 1] > highScoreInt[j])
                {
                    int temp = highScoreInt[j - 1];
                    highScoreInt[j - 1] = highScoreInt[j];
                    highScoreInt[j] = temp;

                    string nameTemp = highScoreName[j - 1];
                    highScoreName[j - 1] = highScoreName[j];
                    highScoreName[j] = nameTemp;
                }
            }
        }

        // set highscore playeprefs
        for (int i = 0; i < highScoreInt.Count; i++)
        {
            PlayerPrefs.SetString("HighScoreName" + i, highScoreName[i]);
            PlayerPrefs.SetInt("HighScoreInt" + i, highScoreInt[i]);
            Debug.Log("Set HighScore PlayerPrefs");
        }
    }

    public void DeleteHighScore()
    {
        for (int i = 0; i < highScoreInt.Count; i++)
        {
            PlayerPrefs.DeleteKey("HighScoreName" + i);
            PlayerPrefs.DeleteKey("HighScoreInt" + i);
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        //DeleteHighScore();
        PlayerPrefs.DeleteKey("ValidScore");
        SetHighScore();
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        int currentScore = PlayerPrefs.GetInt("ValidScore");

        if (validScore != currentScore)
        {
            SetHighScore(currentScore);
            Debug.Log("Set HighScore : "+PlayerPrefs.GetString("Profile"));
        }

        validScore = currentScore;
    }

}
