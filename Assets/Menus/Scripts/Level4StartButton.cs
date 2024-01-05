using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4StartButton : MonoBehaviour
{
    public void MoveToLevel4Scenario(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
