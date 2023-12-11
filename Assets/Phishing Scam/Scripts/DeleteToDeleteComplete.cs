using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteToDeleteComplete : MonoBehaviour
{
    public void MoveToDeleteComplete(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
