using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationBar : MonoBehaviour
{
    public void ToHome()
    {
        SceneManager.LoadScene("Level2Homepage");
    }

    public void ToTabs()
    {
        SceneManager.LoadScene("Level2Tabspage");
    }
}
