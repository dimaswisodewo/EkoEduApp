using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginButtonController : MonoBehaviour
{
    public void OnLoginButtonClicked()
    {
        string profileName = LoginUIController.instance.GetInputFieldText();

        if (profileName != "")
        {
            LoginController.instance.SetStringPlayerPref("Profile", profileName);
            LoginUIController.instance.SetActivePopUp(true);
            LoginUIController.instance.SetPopUpText(LoginController.instance.GetStringPlayerPref("Profile"));
            Debug.Log(LoginController.instance.GetStringPlayerPref("Profile"));
        }
        else
        {
            Debug.Log("nama tidak valid");
        }

        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void OnNameIsRightButtonClicked()
    {
        SoundController.instance.PlaySound(SOUND.SELECT);
        SceneLoader.instance.LoadScene(SCENE.MENU);
    }

    public void OnNameIsWrongButtonClicked()
    {
        SoundController.instance.PlaySound(SOUND.SELECT);
        LoginUIController.instance.SetActivePopUp(false);
    }
}
