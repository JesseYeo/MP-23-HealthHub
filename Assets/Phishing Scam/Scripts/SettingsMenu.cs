using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject gameObject;  //panel
    bool active;

    public void OpenAndClose()     //open and close settings menu, press the settings button to opent the settings menu
    {
        if (active == false)
        {
            gameObject.transform.gameObject.SetActive(true);
            active = true;
        }
        else                       //press the settings button to close the settings button
        {
            gameObject.transform.gameObject.SetActive(false);
            active = false;
        }
    }
}
