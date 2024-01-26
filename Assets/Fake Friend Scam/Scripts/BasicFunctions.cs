using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BasicFunctions : MonoBehaviour
{
    public GameObject settings;
    public GameObject whatsappsettings;


    public void BackToChats()
    {
        SceneManager.LoadScene("ChatsMenu");
    }

    public void OpenPaymentPage()
    {
        SceneManager.LoadScene("AppPaymentMenu");
    }

    public void OpenWhatsappSettings()
    {
        if (whatsappsettings.activeSelf == true)
        {
            whatsappsettings.SetActive(false);
        }
        else
        {
            whatsappsettings.SetActive(true);
        }
    }

    public void StorytoLevelStart()
    {
        SceneManager.LoadScene("ChatsMenu");
    }
}
