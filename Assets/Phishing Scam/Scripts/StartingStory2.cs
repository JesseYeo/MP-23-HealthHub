using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingStory2 : MonoBehaviour
{
    public void MoveToScamNotification(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
