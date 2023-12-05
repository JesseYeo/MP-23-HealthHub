using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Menu : MonoBehaviour
{
    public void MoveToLevel1Menu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    //public GameObject gameObject;
    //bool active;

    //public void OpenAndClose()
    //{
    //    if (active==false)
    //    {
    //        gameObject.transform.gameObject.SetActive(true);
    //        active = true;
    //    }
    //    else
    //    {
    //        gameObject.transform.gameObject.SetActive(false);
    //        active = false;
    //    }
    //}
}
