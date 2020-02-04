using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitPanelController : MonoBehaviour
{
    public GameObject quitCanvas;

    public void OnYaButtonClicked()
    {
        SoundController.instance.PlaySound(SOUND.SELECT);
        Application.Quit();
    }

    public void OnTidakButtonClicked()
    {
        quitCanvas.SetActive(false);
        SoundController.instance.PlaySound(SOUND.SELECT);
    }

    private void Awake()
    {
        quitCanvas.SetActive(false);
        //DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SoundController.instance.PlaySound(SOUND.SELECT);
            quitCanvas.SetActive(true);
        }
    }
}
