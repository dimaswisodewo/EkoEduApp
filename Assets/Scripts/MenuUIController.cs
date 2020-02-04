using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIController : MonoBehaviour
{
    public Text profileNameText;

    private void SetProfileNameText(string inputProfileName)
    {
        profileNameText.text = "Halo " + inputProfileName + "!";
    }

    private void Awake()
    {
        SetProfileNameText(LoginController.instance.GetStringPlayerPref("Profile"));
    }
}
