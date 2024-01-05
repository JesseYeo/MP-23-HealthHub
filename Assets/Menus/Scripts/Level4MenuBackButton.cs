using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4MenuBackButton : MonoBehaviour
{
    public void MoveToLevelMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
