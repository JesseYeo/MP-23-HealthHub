using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Track2 : MonoBehaviour
{
    public void MoveToWin(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
