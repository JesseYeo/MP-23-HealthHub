using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReportCompleteToScamEmail : MonoBehaviour
{
    public void MoveToScamEmailafterreport(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
