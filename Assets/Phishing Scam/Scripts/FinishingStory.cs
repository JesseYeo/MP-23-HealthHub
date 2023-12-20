using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishingStory : MonoBehaviour
{
    public void MoveToFinishingStory2(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
