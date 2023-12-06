using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScamEmail : MonoBehaviour
{
    public void MoveToScamWebsite(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public GameObject gameObject;
    bool active;

    public void OpenAndClose()
    {
        if (active == false)
        {
            gameObject.transform.gameObject.SetActive(true);
            active = true;
        }
        else
        {
            gameObject.transform.gameObject.SetActive(false);
            active = false;
        }
    }
}
