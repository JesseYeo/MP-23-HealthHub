using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScammedScreen : MonoBehaviour
{
    public void MoveToLoseScreen(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
