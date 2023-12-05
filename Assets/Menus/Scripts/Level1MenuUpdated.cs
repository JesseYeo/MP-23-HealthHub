using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1MenuUpdated : MonoBehaviour
{
    public void MoveToLevel1ClearedMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
