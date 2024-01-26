using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseSwitch : MonoBehaviour
{
    public void LevelWin()
    {
        if (LevelStart.level2 == true)
        {
            SceneManager.LoadScene("Level2WinScreen");
        }   
        else if (LevelStart.level4 == true)
        {
            SceneManager.LoadScene("D Lose Screen");
        }
    }

    public void LevelLose()
    {
        if (LevelStart.level2 == true)
        {
            SceneManager.LoadScene("Level2LoseScreen");
        }
        else if (LevelStart.level4 == true)
        {
            SceneManager.LoadScene("D Win Screen 1_3");
        }
    }


}
