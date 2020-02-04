using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOrientationController : MonoBehaviour
{
    public static ScreenOrientationController instance;
    private bool isLandscape;

    public void SetOrientation(ORIENTATION orientation)
    {
        switch (orientation)
        {
            case ORIENTATION.LANDSCAPE:
                if (isLandscape == false)
                {
                    Screen.orientation = ScreenOrientation.LandscapeLeft;
                    Debug.Log("set to landscape");
                    isLandscape = true;
                }
                break;

            case ORIENTATION.PORTRAIT:
                if (isLandscape == true)
                {
                    Screen.orientation = ScreenOrientation.Portrait;
                    Debug.Log("set to portrait");
                    isLandscape = false;
                }
                break;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
