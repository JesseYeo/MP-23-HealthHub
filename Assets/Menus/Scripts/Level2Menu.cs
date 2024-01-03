using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Menu : MonoBehaviour
{
    public void MoveToLevel2(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
