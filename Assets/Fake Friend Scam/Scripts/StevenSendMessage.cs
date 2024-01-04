using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playerchatbubble1;
    public GameObject playerchatbubble2;
    public GameObject playerchatbubble3;
    public GameObject playerchatbubble4;

    public GameObject stevenchatbubble1;
    public GameObject stevenchatbubble2;
    public GameObject stevenchatbubble3;
    public GameObject stevenchatbubble4;

    public GameObject messagedisplay1;
    public GameObject messagedisplay2;
    public GameObject messagedisplay3;
    public GameObject messagedisplay4;

    public GameObject optionselect2;
    public GameObject optionselect3;
    public GameObject optionselect4;

    public void onSendMessage()
    {
        if (messagedisplay1.activeSelf)
        {
            messagedisplay1.SetActive(false);
            playerchatbubble1.SetActive(true);
            Invoke("StevenReply1", 1);
        }

        if (messagedisplay2.activeSelf)
        {
            messagedisplay2.SetActive(false);
            playerchatbubble2.SetActive(true);
            Invoke("UnknownReply2", 1);
        }

        if (messagedisplay3.activeSelf)
        {
            messagedisplay3.SetActive(false);
            playerchatbubble3.SetActive(true);
            Invoke("UnknownReply3", 1);
        }

        if (messagedisplay4.activeSelf)
        {
            messagedisplay4.SetActive(false);
            playerchatbubble4.SetActive(true);
        }

    }

    public void StevenReply1()
    {
        stevenchatbubble1.SetActive(true);
        optionselect2.SetActive(true);
    }

    public void UnknownReply2()
    {
        stevenchatbubble2.SetActive(true);
        optionselect3.SetActive(true);
        optionselect4.SetActive(true);
    }

    public void UnknownReply3()
    {
        stevenchatbubble3.SetActive(true);

    }
}
