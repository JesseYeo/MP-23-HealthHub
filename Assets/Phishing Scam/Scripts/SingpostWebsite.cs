using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingpostWebsite : MonoBehaviour
{
    public void MoveToTrack(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
