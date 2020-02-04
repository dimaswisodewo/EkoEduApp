using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetaUIController : MonoBehaviour
{
    public static PetaUIController instance;
    public GameObject popUpPanel;
    public Text titleText;
    public Text contentText;
    public Image contentImage;
    [Header("Library Sprite Content")]
    public List<Sprite> librarySpriteContent = new List<Sprite>();

    public void OnCloseButtonClicked()
    {
        SetActivePopUp(false);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    public void SetActivePopUp(bool setActive)
    {
        popUpPanel.SetActive(setActive);
    }

    public void SetPopUpContent(PROVINSI enumProvinsi)
    {
        switch (enumProvinsi)
        {
            case PROVINSI.ACEH:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[0]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[0]);
                SetContentImage(librarySpriteContent[0]);
                break;

            case PROVINSI.SUMATERA_UTARA:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[1]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[1]);
                SetContentImage(librarySpriteContent[1]);
                break;

            case PROVINSI.SUMATERA_BARAT:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[2]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[2]);
                SetContentImage(librarySpriteContent[2]);
                break;

            case PROVINSI.RIAU:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[3]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[3]);
                SetContentImage(librarySpriteContent[3]);
                break;

            case PROVINSI.KEPULAUAN_RIAU:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[4]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[4]);
                SetContentImage(librarySpriteContent[4]);
                break;

            case PROVINSI.JAMBI:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[5]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[5]);
                SetContentImage(librarySpriteContent[5]);
                break;

            case PROVINSI.BENGKULU:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[6]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[6]);
                SetContentImage(librarySpriteContent[6]);
                break;

            case PROVINSI.SUMATERA_SELATAN:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[7]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[7]);
                SetContentImage(librarySpriteContent[7]);
                break;

            case PROVINSI.BANGKA_BELITUNG:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[8]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[8]);
                SetContentImage(librarySpriteContent[8]);
                break;

            case PROVINSI.LAMPUNG:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[9]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[9]);
                SetContentImage(librarySpriteContent[9]);
                break;

            case PROVINSI.BANTEN:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[10]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[10]);
                SetContentImage(librarySpriteContent[10]);
                break;

            case PROVINSI.JAWA_BARAT:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[11]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[11]);
                SetContentImage(librarySpriteContent[11]);
                break;

            case PROVINSI.JAKARTA:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[12]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[12]);
                SetContentImage(librarySpriteContent[12]);
                break;

            case PROVINSI.JAWA_TENGAH:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[13]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[13]);
                SetContentImage(librarySpriteContent[13]);
                break;

            case PROVINSI.YOGYAKARTA:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[14]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[14]);
                SetContentImage(librarySpriteContent[14]);
                break;

            case PROVINSI.JAWA_TIMUR:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[15]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[15]);
                SetContentImage(librarySpriteContent[15]);
                break;

            case PROVINSI.BALI:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[16]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[16]);
                SetContentImage(librarySpriteContent[16]);
                break;

            case PROVINSI.NTB:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[17]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[17]);
                SetContentImage(librarySpriteContent[17]);
                break;

            case PROVINSI.NTT:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[18]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[18]);
                SetContentImage(librarySpriteContent[18]);
                break;

            case PROVINSI.KALIMANTAN_UTARA:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[19]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[19]);
                SetContentImage(librarySpriteContent[19]);
                break;

            case PROVINSI.KALIMANTAN_BARAT:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[20]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[20]);
                SetContentImage(librarySpriteContent[20]);
                break;

            case PROVINSI.KALIMANTAN_TENGAH:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[21]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[21]);
                SetContentImage(librarySpriteContent[21]);
                break;

            case PROVINSI.KALIMANTAN_SELATAN:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[22]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[22]);
                SetContentImage(librarySpriteContent[22]);
                break;

            case PROVINSI.KALIMANTAN_TIMUR:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[23]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[23]);
                SetContentImage(librarySpriteContent[23]);
                break;

            case PROVINSI.GORONTALO:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[24]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[24]);
                SetContentImage(librarySpriteContent[24]);
                break;

            case PROVINSI.SULAWESI_UTARA:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[25]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[25]);
                SetContentImage(librarySpriteContent[25]);
                break;

            case PROVINSI.SULAWESI_BARAT:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[26]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[26]);
                SetContentImage(librarySpriteContent[26]);
                break;

            case PROVINSI.SULAWESI_TENGAH:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[27]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[27]);
                SetContentImage(librarySpriteContent[27]);
                break;

            case PROVINSI.SULAWESI_SELATAN:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[28]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[28]);
                SetContentImage(librarySpriteContent[28]);
                break;

            case PROVINSI.SULAWESI_TENGGARA:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[29]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[29]);
                SetContentImage(librarySpriteContent[29]);
                break;

            case PROVINSI.MALUKU_UTARA:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[30]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[30]);
                SetContentImage(librarySpriteContent[30]);
                break;

            case PROVINSI.MALUKU:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[31]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[31]);
                SetContentImage(librarySpriteContent[31]);
                break;

            case PROVINSI.PAPUA_BARAT:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[32]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[32]);
                SetContentImage(librarySpriteContent[32]);
                break;

            case PROVINSI.PAPUA:
                SetText(titleText, JSONData.instance.materiJsonData[0].TITLE[33]);
                SetContentText(JSONData.instance.materiJsonData[0].MATERI_TEXT[33]);
                SetContentImage(librarySpriteContent[33]);
                break;
        }
    }

    private void SetContentText(string inputString)
    {
        inputString = inputString.Replace("\\n", "\n");
        SetText(contentText, inputString);
    }

    private void SetContentImage(Sprite inputSprite)
    {
        contentImage.sprite = inputSprite;
    }

    private void SetText(Text inputText, string inputString)
    {
        inputText.text = inputString;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        SetActivePopUp(false);
    }
}
