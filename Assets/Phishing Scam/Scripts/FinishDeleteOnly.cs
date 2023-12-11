using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishDeleteOnly : MonoBehaviour
{
    public void MoveToWin2StarDeleteOnly(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
