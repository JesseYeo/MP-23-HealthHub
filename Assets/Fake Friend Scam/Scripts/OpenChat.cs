using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenChat : MonoBehaviour
{

    public void OpenUnknownNoChat()
    {
        SceneManager.LoadScene("UnknownNoChat");
    }

    public void OpenStevenChat()
    {
        SceneManager.LoadScene("StevenChat");
    }

    public void BackToChats()
    {
        SceneManager.LoadScene("ChatsMenu");
    }
}
