using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Google : MonoBehaviour
{
    public void MoveToSingpostWebsite(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
