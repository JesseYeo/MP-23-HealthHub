using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReportToReportComplete : MonoBehaviour
{
    public void MoveToReportComplete(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
