using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public void OnButtonMateriClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MATERI);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonProfileClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.PROFIL);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonContohSoalClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.CONTOH_SOAL);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonPetaClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.PETA);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonKuisClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.KUIS);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnButtonDaftarPustakaClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.DAFTAR_PUSTAKA);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnChangeProfileButtonClicked()
    {
        LoginController.instance.DeleteKeyPlayerPref("Profile");
        SoundController.instance.PlaySound(SOUND.SELECT);
        SceneLoader.instance.LoadScene(SCENE.LOGIN);
    }

    public void OnButtonSilabusClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.SILABUS);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }
}
