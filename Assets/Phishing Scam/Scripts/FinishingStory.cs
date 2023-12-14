using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishingStory : MonoBehaviour
{
    public void MoveToWin3Star(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
