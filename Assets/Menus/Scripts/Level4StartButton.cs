using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4StartButton : MonoBehaviour
{
    public static bool level4 = false;
    
    
    public void MoveToLevel4Scenario()
    {
        level4 = true;
        SceneManager.LoadScene("ChatsMenu");
    }
}
