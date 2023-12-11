using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishReportOnly : MonoBehaviour
{
    public void MoveToWin2StarReportOnly(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
