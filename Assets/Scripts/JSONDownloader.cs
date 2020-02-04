using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class JSONDownloader : MonoBehaviour
{
    public JSONData quizJsonData;
    public JSONData materiJsonData;
    private string quizDataFileName = "QuizEkoEduApp";
    private string materiDataFileName = "MateriEkoEduApp";

    public IEnumerator LoadJsonData(string _fileName, JsonType jsonType)
    {
        string path = Application.streamingAssetsPath;
        string fullPath = PathCorrection(path, _fileName);
        Debug.Log("FullPath: " + fullPath);

        UnityWebRequest request = UnityWebRequest.Get(fullPath);

        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError)
        {
            Debug.Log("Request Error!");
            yield break;
        }

        string downloadedText = request.downloadHandler.text;
        Debug.Log(downloadedText);

        if (jsonType == JsonType.QUIZ_DATA)
        {
            QuizJsonData quizJsonData = TryParseQuizJSONData(downloadedText);
            this.quizJsonData.AddQuizData(quizJsonData);
        }
        else if (jsonType == JsonType.MATERI_DATA)
        {
            MateriJsonData materiJsonData = TryParseMateriJSONData(downloadedText);
            this.materiJsonData.AddMateriData(materiJsonData);
        }

    }

    private string PathCorrection(string _fullPath, string _fileName)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _fullPath = System.IO.Path.Combine(_fullPath, _fileName + ".json");
            Debug.Log("Run in Android");
        }
        else
        {
            Debug.Log("Run in Editor");
            _fullPath = System.IO.Path.Combine("file:///" + _fullPath, _fileName + ".json");
        }

        return _fullPath;
    }

    private QuizJsonData TryParseQuizJSONData(string downloadedText)
    {
        QuizJsonData data = JsonUtility.FromJson<QuizJsonData>(downloadedText);
        return data;
    }

    private MateriJsonData TryParseMateriJSONData(string downloadedText)
    {
        MateriJsonData data = JsonUtility.FromJson<MateriJsonData>(downloadedText);
        return data;
    }

    private IEnumerator LoadDataAtStart()
    {
        yield return StartCoroutine(LoadJsonData(quizDataFileName, JsonType.QUIZ_DATA));
        yield return StartCoroutine(LoadJsonData(materiDataFileName, JsonType.MATERI_DATA));
    }

    private IEnumerator ProfileValidation()
    {
        if (LoginController.instance.CheckKeyPlayerPref("Profile") == true)
        {
            yield return StartCoroutine(SceneLoader.instance.LoadSceneCoroutine(SCENE.MENU));
        }
        else
        {
            yield return StartCoroutine(SceneLoader.instance.LoadSceneCoroutine(SCENE.LOGIN));
        }
    }

    private IEnumerator Loader()
    {
        yield return StartCoroutine(LoadDataAtStart());
        yield return StartCoroutine(ProfileValidation());
    }

    private void Start()
    {
        StartCoroutine(Loader());
    }
}

[System.Serializable]
public class QuizJsonData
{
    public string[] QUESTION;
    public string[] ANSWER;
    public string[] EXPLANATION;
    public string[] CHOICE_1;
    public string[] CHOICE_2;
    public string[] CHOICE_3;
    public string[] CHOICE_4;
    public string[] CHOICE_5;
    public string[] CHOICE_6;
    public string[] CHOICE_7;
    public string[] CHOICE_8;
    public string[] CHOICE_9;
    public string[] CHOICE_10;
    public string[] CHOICE_11;
    public string[] CHOICE_12;
    public string[] CHOICE_13;
    public string[] CHOICE_14;
    public string[] CHOICE_15;
    public string[] CHOICE_16;
    public string[] CHOICE_17;
    public string[] CHOICE_18;
    public string[] CHOICE_19;
    public string[] CHOICE_20;
}

[System.Serializable]
public class MateriJsonData
{
    public string[] TITLE;
    public string[] MATERI_TEXT;
    public string[] MATERI_GAMBAR;
}

public enum JsonType
{
    QUIZ_DATA,
    MATERI_DATA
}