using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    public static bool level4 = false;

    public static bool level2 = false;
    
    public void MoveToLevel2Scenario()
    {
        if (level4 == true)
        {
            level4 = false;
        }
        
        level2 = true;
        SceneManager.LoadScene("FF Scam Story");
    }

    public void MoveToLevel4Scenario()
    {
        if (level2 == true)
        {
            level2 = false;
        }

        level4 = true;
        SceneManager.LoadScene("ChatsMenu");
    }
}
