using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToReport : MonoBehaviour
{
    public void MoveToReport(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
