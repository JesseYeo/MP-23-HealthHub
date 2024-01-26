using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChatsMenu : MonoBehaviour
{
    public static bool unread = true;
    public GameObject unreadicon;
    
    public void Start()
    {
        if (unread == true)
        {
            unreadicon.SetActive(true);
        }
        else
        {
            unreadicon.SetActive(false);
        }
    }

    public void OpenUnknownNoChat()
    {
        unread = false;
        SceneManager.LoadScene("UnknownNoChat");
    }

    public void OpenStevenChat()
    {
        SceneManager.LoadScene("StevenChat");
    }
}
