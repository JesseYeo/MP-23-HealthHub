using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishDeleteandReport : MonoBehaviour
{
    public void MoveToWin3StarReportandDelete(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
