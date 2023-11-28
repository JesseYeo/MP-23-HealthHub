using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScamNotification : MonoBehaviour
{
    public void MoveToScamEmail(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
