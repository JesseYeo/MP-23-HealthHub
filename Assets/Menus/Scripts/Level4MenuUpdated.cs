using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4MenuUpdated : MonoBehaviour
{
    public void MoveToLevel4UpdatedMenu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
