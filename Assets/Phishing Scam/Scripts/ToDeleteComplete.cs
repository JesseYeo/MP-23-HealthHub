using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDeleteComplete : MonoBehaviour
{
    public void MoveToDeleteComplete(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
