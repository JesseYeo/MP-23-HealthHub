using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Menu : MonoBehaviour
{
    public void MoveToLevel2Menu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
