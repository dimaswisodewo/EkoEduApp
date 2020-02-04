using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;

    public IEnumerator LoadSceneCoroutine(SCENE inputScene)
    {
        yield return null;
        LoadScene(inputScene);
    }

    public void LoadScene(SCENE inputScene)
    {
        if (inputScene == SCENE.PETA)
        {
            ScreenOrientationController.instance.SetOrientation(ORIENTATION.LANDSCAPE);
        }
        else
        {
            ScreenOrientationController.instance.SetOrientation(ORIENTATION.PORTRAIT);
        }

        switch (inputScene)
        {
            case SCENE.PROFIL:
                SceneLoad(Config.sceneProfil);
                break;

            case SCENE.LOGIN:
                SceneLoad(Config.sceneLogin);
                break;

            case SCENE.MATERI:
                SceneLoad(Config.sceneMateri);
                break;

            case SCENE.CONTOH_SOAL:
                SceneLoad(Config.sceneContohSoal);
                break;

            case SCENE.KUIS:
                SceneLoad(Config.sceneKuis);
                break;

            case SCENE.PETA:
                SceneLoad(Config.scenePeta);
                break;

            case SCENE.DAFTAR_PUSTAKA:
                SceneLoad(Config.sceneDaftarPustaka);
                break;

            case SCENE.MENU:
                SceneLoad(Config.sceneMenu);
                break;

            case SCENE.MATERI_PERTUMBUHAN:
                SceneLoad(Config.scenePertumbuhan);
                break;

            case SCENE.MATERI_PEMBANGUNAN:
                SceneLoad(Config.scenePembangunan);
                break;

            case SCENE.MATERI_PEMBANGUNAN_1:
                SceneLoad(Config.scenePembangunan1);
                break;

            case SCENE.MATERI_PEMBANGUNAN_2:
                SceneLoad(Config.scenePembangunan2);
                break;

            case SCENE.MATERI_PEMBANGUNAN_3:
                SceneLoad(Config.scenePembangunan3);
                break;

            case SCENE.MATERI_PEMBANGUNAN_4:
                SceneLoad(Config.scenePembangunan4);
                break;

            case SCENE.MATERI_PERTUMBUHAN_1:
                SceneLoad(Config.scenePertumbuhan1);
                break;

            case SCENE.MATERI_PERTUMBUHAN_2:
                SceneLoad(Config.scenePertumbuhan2);
                break;

            case SCENE.SILABUS:
                SceneLoad(Config.sceneSilabusAplikasi);
                break;
        }
    }

    private void SceneLoad(string inputString)
    {
        SceneManager.LoadScene(inputString);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
