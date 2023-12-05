using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1MenuBackButton : MonoBehaviour
{
    public void MoveToLevelMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
