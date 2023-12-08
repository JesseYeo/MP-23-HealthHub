using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingpostToScamEmail : MonoBehaviour
{
    public void MoveToScamEmail(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
