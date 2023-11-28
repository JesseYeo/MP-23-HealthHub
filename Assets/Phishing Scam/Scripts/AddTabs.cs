using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddTabs : MonoBehaviour
{
    public void MoveToGoogle(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
