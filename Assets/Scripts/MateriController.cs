using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateriController : MonoBehaviour
{
    public void GetTitle(PROVINSI inputProvinsi)
    {
        string outputString = "kosong";

        switch (inputProvinsi)
        {
            case PROVINSI.ACEH:
                outputString = JSONData.instance.materiJsonData[0].TITLE[1];
                break;
        }
    }
}
