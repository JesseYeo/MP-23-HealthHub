using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2MenuBackButton : MonoBehaviour
{
    public void MoveToLevelMenuLevel1Win(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
