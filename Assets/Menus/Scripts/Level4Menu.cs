using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Menu : MonoBehaviour
{
    public void MoveToLevel4Menu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
