using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsFunctions : MonoBehaviour
{
    public GameObject settingsmenu;


    public void Resume()
    {
        settingsmenu.SetActive(false);
    }

    public void Restart()
    {
        if (LevelStart.level2 == true)
        {
            LevelStart.level2 = false;
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
            SceneManager.LoadScene("Level2Menu");
        }
        else if (LevelStart.level4 == true)
        {
            LevelStart.level4 = false;
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
            SceneManager.LoadScene("Level4Menu");
        }
    }

    public void MainMenu()
    {
        if (LevelStart.level2 == true)
        {
            LevelStart.level2 = false;
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
            SceneManager.LoadScene("LevelMenuLevel1Win");
        }
        else if (LevelStart.level4 == true)
        {
            LevelStart.level4 = false;
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
            SceneManager.LoadScene("LevelMenuLevel3Win");
        }
    }
}
