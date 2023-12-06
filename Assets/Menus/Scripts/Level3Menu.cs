using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Menu : MonoBehaviour
{
    public void MoveToLevel3Menu(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
