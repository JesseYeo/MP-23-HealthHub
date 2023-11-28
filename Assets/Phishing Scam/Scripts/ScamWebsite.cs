using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScamWebsite : MonoBehaviour
{
    public void MoveToAddTabs(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
