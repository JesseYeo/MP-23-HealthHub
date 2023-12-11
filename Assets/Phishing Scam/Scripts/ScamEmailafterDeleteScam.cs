using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScamEmailafterDeleteScam : MonoBehaviour
{
    public void MoveToScamEmailafterDeleteScam(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
