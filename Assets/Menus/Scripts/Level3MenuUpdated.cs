using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3MenuUpdated : MonoBehaviour
{
    public void MoveToLevel3ClearedMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
