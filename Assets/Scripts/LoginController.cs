using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginController : MonoBehaviour
{
    public static LoginController instance;
    public string profileName;

    public void OnDeleteProfileButtonClicked()
    {
        DeleteKeyPlayerPref("Profile");
        Debug.Log(GetStringPlayerPref("Profile"));
    }

    public string GetStringPlayerPref(string key)
    {
        string value = PlayerPrefs.GetString(key);
        return value;
    }

    public void SetStringPlayerPref(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    public void DeleteKeyPlayerPref(string key)
    {
        bool isKeyAvailable = CheckKeyPlayerPref(key);

        if (isKeyAvailable == true)
        {
            PlayerPrefs.DeleteKey(key);
            Debug.Log("Key " + key + " Deleted");
        }
        else
        {
            Debug.Log("Key " + key + " Gak Ada");
        }
    }

    public bool CheckKeyPlayerPref(string key)
    {
        bool isKeyAvailable;

        if (PlayerPrefs.HasKey(key))
        {
            isKeyAvailable = true;
        }
        else
        {
            isKeyAvailable = false;
        }

        Debug.Log(isKeyAvailable);
        return isKeyAvailable;
    }

    private void Awake()
    {
        //DeleteKeyPlayerPref("Profile");
        //PlayerPrefs.DeleteAll();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            //DeleteKeyPlayerPref("Profile");
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}
