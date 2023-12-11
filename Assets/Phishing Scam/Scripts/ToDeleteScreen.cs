using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToDeleteScreen : MonoBehaviour
{
    public void MoveToDeleteScreen(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
