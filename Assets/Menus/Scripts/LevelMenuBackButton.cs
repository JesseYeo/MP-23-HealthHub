using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenuBackButton : MonoBehaviour
{
    public void MoveToMainMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
