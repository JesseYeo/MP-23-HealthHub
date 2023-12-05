using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScamIdentifiedScreen : MonoBehaviour
{
    public void MoveToWinScreen(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
