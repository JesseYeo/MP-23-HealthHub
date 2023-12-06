using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3MenuStartButton : MonoBehaviour
{
    public void MoveToMalwareScamNotification(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
