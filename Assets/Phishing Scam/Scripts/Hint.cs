using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObjectHighlight;
    bool active;

    public void OpenAndClose()
    {
        if (active == false)
        {
            gameObject.transform.gameObject.SetActive(true);
            gameObjectHighlight.transform.gameObject.SetActive(true);
            active = true;
        }
        else
        {
            gameObject.transform.gameObject.SetActive(false);
            gameObjectHighlight.transform.gameObject.SetActive(true);
            active = false;
        }
    }

}
