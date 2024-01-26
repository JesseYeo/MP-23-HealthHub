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

    public void Level4Retry()
    {
        if (LevelStart.level4 == false)
        {
            LevelStart.level4 = true;
            UnknownSendMessage.sent1 = false;
            UnknownSendMessage.sent2 = false;
            UnknownSendMessage.sent3 = false;
            UnknownSendMessage.sent4 = false;
            UnknownSendMessage.sent5 = false;
            UnknownSendMessage.sent6 = false;
            UnknownSendMessage.sent7 = false;
            UnknownSendMessage.sent8 = false;
            ChatsMenu.unread = true;
            SceneManager.LoadScene("ChatsMenu");
            
        }
        else
        {
            UnknownSendMessage.sent1 = false;
            UnknownSendMessage.sent2 = false;
            UnknownSendMessage.sent3 = false;
            UnknownSendMessage.sent4 = false;
            UnknownSendMessage.sent5 = false;
            UnknownSendMessage.sent6 = false;
            UnknownSendMessage.sent7 = false;
            UnknownSendMessage.sent8 = false;
            ChatsMenu.unread = true;
            SceneManager.LoadScene("ChatsMenu");
        }
    }
}
