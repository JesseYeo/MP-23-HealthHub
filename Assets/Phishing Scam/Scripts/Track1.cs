using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Track1 : MonoBehaviour
{
    public void MoveToTrack2(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
