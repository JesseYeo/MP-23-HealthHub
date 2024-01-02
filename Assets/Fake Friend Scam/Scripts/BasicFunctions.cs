using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BasicFunctions : MonoBehaviour
{
    public GameObject settings;

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

    public void OpenPaymentPage()
    {
        SceneManager.LoadScene("AppPaymentMenu");
    }

    public void OpenSettings()
    {
        if (settings.activeSelf == true)
        {
            settings.SetActive(false);
        }
        else
        {
            settings.SetActive(true);
        }
    }
}
