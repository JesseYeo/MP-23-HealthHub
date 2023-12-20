using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingStory : MonoBehaviour
{
    public void MoveToStartingStory2(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
