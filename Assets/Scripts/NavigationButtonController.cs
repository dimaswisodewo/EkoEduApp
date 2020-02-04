using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationButtonController : MonoBehaviour
{
    public void OnBackToMenuButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MENU);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnBackToMateriButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnBackToPembangunanButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PEMBANGUNAN);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnBackToPertumbuhanButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PERTUMBUHAN);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }
}
