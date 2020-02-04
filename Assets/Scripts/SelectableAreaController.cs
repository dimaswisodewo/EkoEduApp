using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableAreaController : MonoBehaviour
{
    public string provinceName;
    public GameObject provinceObject;

    public void OnAreaClicked()
    {
        PetaController.instance.DeactivateAllButton();
        Debug.Log(provinceName + " Clicked!");
        ButtonSetActive(true);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void ButtonSetActive(bool setActive)
    {
        provinceObject.SetActive(setActive);
    }
}
