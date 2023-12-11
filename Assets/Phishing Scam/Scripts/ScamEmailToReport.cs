using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScamEmailToReport : MonoBehaviour
{
    public void MoveToReportScreen(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
