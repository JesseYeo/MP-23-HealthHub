using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScamEmail : MonoBehaviour
{
    public void MoveToScamWebsite(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
