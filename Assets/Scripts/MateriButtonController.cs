using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateriButtonController : MonoBehaviour
{
    public void OnButtonPertumbuhanClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PERTUMBUHAN);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonPembangunanClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PEMBANGUNAN);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonPembangunan1Clicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PEMBANGUNAN_1);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonPembangunan2Clicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PEMBANGUNAN_2);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonPembangunan3Clicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PEMBANGUNAN_3);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonPembangunan4Clicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PEMBANGUNAN_4);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonPertumbuhan1Clicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PERTUMBUHAN_1);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonPertumbuhan2Clicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI_PERTUMBUHAN_2);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }
}
