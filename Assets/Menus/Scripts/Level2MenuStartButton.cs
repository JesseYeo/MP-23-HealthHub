using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2MenuStartButton : MonoBehaviour
{
    public void MoveToFakeFriendScamNotification(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
