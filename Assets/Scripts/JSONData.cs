using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONData : MonoBehaviour
{
    public static JSONData instance;
    public List<QuizJsonData> quizJsonData = new List<QuizJsonData>();
    public List<MateriJsonData> materiJsonData = new List<MateriJsonData>();
    private string[] tempArray; 

    public void AddQuizData(QuizJsonData _quizJsonData)
    {
        quizJsonData.Clear();
        quizJsonData.Add(_quizJsonData);
    }

    public void AddMateriData(MateriJsonData _materiJsonData)
    {
        materiJsonData.Clear();
        materiJsonData.Add(_materiJsonData);
    }

    public string GetQuestion(int index)
    {
        string outputData = quizJsonData[0].QUESTION[index];
        return outputData;
    }

    public string GetAnswer(int index)
    {
        string outputData = quizJsonData[0].ANSWER[index];
        return outputData;
    }

    public string[] GetChoice(int index)
    {
        switch (index)
        {
            case 0:
                tempArray = quizJsonData[0].CHOICE_1;
                break;

            case 1:
                tempArray = quizJsonData[0].CHOICE_2;
                break;

            case 2:
                tempArray = quizJsonData[0].CHOICE_3;
                break;

            case 3:
                tempArray = quizJsonData[0].CHOICE_4;
                break;

            case 4:
                tempArray = quizJsonData[0].CHOICE_5;
                break;

            case 5:
                tempArray = quizJsonData[0].CHOICE_6;
                break;

            case 6:
                tempArray = quizJsonData[0].CHOICE_7;
                break;

            case 7:
                tempArray = quizJsonData[0].CHOICE_8;
                break;

            case 8:
                tempArray = quizJsonData[0].CHOICE_9;
                break;

            case 9:
                tempArray = quizJsonData[0].CHOICE_10;
                break;

            case 10:
                tempArray = quizJsonData[0].CHOICE_11;
                break;

            case 11:
                tempArray = quizJsonData[0].CHOICE_12;
                break;

            case 12:
                tempArray = quizJsonData[0].CHOICE_13;
                break;

            case 13:
                tempArray = quizJsonData[0].CHOICE_14;
                break;

            case 14:
                tempArray = quizJsonData[0].CHOICE_15;
                break;

            case 15:
                tempArray = quizJsonData[0].CHOICE_16;
                break;

            case 16:
                tempArray = quizJsonData[0].CHOICE_17;
                break;

            case 17:
                tempArray = quizJsonData[0].CHOICE_18;
                break;

            case 18:
                tempArray = quizJsonData[0].CHOICE_19;
                break;

            case 19:
                tempArray = quizJsonData[0].CHOICE_20;
                break;
        }

        return tempArray;
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
