using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2MenuUpdated : MonoBehaviour
{
    public void MoveToLevel2ClearedMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
