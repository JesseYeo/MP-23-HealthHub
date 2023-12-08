using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReportButton : MonoBehaviour
{
    //public void MoveToReportScreen(int sceneID)
    //{
    //    SceneManager.LoadScene(sceneID);
    //}

    public GameObject gameObject;  //panel
    bool active;

    public void OpenAndClose()     //open and close report screen, press report button to activiate report screen
    {
        if (active == false)
        {
            gameObject.transform.gameObject.SetActive(true);
            active = true;
        }
        //else
        //{
        //    gameObject.transform.gameObject.SetActive(false);
        //    active = false;
        //}
    }
}
