using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDelete : MonoBehaviour
{
    public void MoveToDeleteScam(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
