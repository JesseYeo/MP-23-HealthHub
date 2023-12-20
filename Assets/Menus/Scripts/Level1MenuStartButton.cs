using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1MenuStartButton : MonoBehaviour
{
    public void MoveToStartingStory(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
