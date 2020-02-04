using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetaButtonController : MonoBehaviour
{
    public PROVINSI enumProvinsi;

    public void OnAreaButtonClicked()
    {
        PetaUIController.instance.SetActivePopUp(true);
        PetaUIController.instance.SetPopUpContent(enumProvinsi);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }
}
