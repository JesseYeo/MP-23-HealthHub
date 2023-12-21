using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playerchatbubble1;
    public GameObject playerchatbubble2;

    public GameObject unknownchatbubble1;
    public GameObject unknownchatbubble2;
    public GameObject unknownchatbubble3;

    public GameObject messagedisplay1;
    public GameObject messagedisplay2;
    //public GameObject messagedisplay3;

    public GameObject optionselect2;
    public GameObject optionselect3;

    public void onSendMessage()
    {
        if (messagedisplay1.activeSelf)
        {
            messagedisplay1.SetActive(false);
            playerchatbubble1.SetActive(true);
            unknownchatbubble1.SetActive(true);
            optionselect2.SetActive(true);
        }

        if (messagedisplay2.activeSelf)
        {
            messagedisplay2.SetActive(false);
            playerchatbubble2.SetActive(true);
            unknownchatbubble2.SetActive(true);
            optionselect3.SetActive(true);
        }

    }
}
