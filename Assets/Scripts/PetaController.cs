using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetaController : MonoBehaviour
{
    public static PetaController instance;
    public List<GameObject> provinceLibrary = new List<GameObject>();

    public void DeactivateAllButton()
    {
        for (int i = 0; i < provinceLibrary.Count; i++)
        {
            provinceLibrary[i].SetActive(false);
        }

        Debug.Log("Deactivate all button");
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        DeactivateAllButton();
    }
}
