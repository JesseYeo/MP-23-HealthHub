using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2WinScreen : MonoBehaviour
{
    public void MoveToLevelMenuLevel2Win(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
