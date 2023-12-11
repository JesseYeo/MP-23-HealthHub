using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishDoNothing : MonoBehaviour
{
    public void MoveToWin1StarDoNothing(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
