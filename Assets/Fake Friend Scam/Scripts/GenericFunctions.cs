using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GenericFunctions : MonoBehaviour
{
    public GameObject whatsappsettings;



    //opens the settings of the Whatsapp scene
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

    public void ToDBS()
    {
        SceneManager.LoadScene("AppPaymentMenu");
    }

    //go from the story to the starting screen of the level
    public void StorytoLevelStart()
    {
        SceneManager.LoadScene("ChatsMenu");
    }

    //resets the level for the player to be able to retry
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
            StevenSendMessage.sent1 = false ;
            StevenSendMessage.sent2 = false ;
            StevenSendMessage.sent3 = false ;
            StevenSendMessage.sent4 = false ;
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
            StevenSendMessage.sent1 = false;
            StevenSendMessage.sent2 = false;
            StevenSendMessage.sent3 = false;
            StevenSendMessage.sent4 = false;
            ChatsMenu.unread = true;
            SceneManager.LoadScene("ChatsMenu");
        }
    }

    public void Level2Retry()
    {
        if (LevelStart.level2 == false)
        {
            LevelStart.level2 = true;
            UnknownSendMessage.sent1 = false;
            UnknownSendMessage.sent2 = false;
            UnknownSendMessage.sent3 = false;
            UnknownSendMessage.sent4 = false;
            UnknownSendMessage.sent5 = false;
            UnknownSendMessage.sent6 = false;
            UnknownSendMessage.sent7 = false;
            UnknownSendMessage.sent8 = false;
            StevenSendMessage.sent1 = false;
            StevenSendMessage.sent2 = false;
            StevenSendMessage.sent3 = false;
            StevenSendMessage.sent4 = false;
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
            StevenSendMessage.sent1 = false;
            StevenSendMessage.sent2 = false;
            StevenSendMessage.sent3 = false;
            StevenSendMessage.sent4 = false;
            ChatsMenu.unread = true;
            SceneManager.LoadScene("ChatsMenu");
        }
    }

    //triggers upon winning the level
    public void LevelWin()
    {
        if (LevelStart.level2 == true)
        {
            SceneManager.LoadScene("Level2WinScreen");
        }
        else if (LevelStart.level4 == true)
        {
            SceneManager.LoadScene("D Win Screen 1_3");
        }
    }

    //triggers upon losing the level
    public void LevelLose()
    {
        if (LevelStart.level2 == true)
        {
            SceneManager.LoadScene("Level2LoseScreen");
        }
        else if (LevelStart.level4 == true)
        {
            SceneManager.LoadScene("D Lose Screen");
        }
    }


}
