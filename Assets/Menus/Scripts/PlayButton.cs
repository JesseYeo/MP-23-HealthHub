using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void MoveToLevelMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    //public void OpenLevelMenu()
    //{
    //    SceneManager.LoadScene("Level Menu");
    //}
}
