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

    public GameObject unknownchatbubble1;
    public GameObject unknownchatbubble2;
    public GameObject unknownchatbubble3;


    public void onClickSendMessage()
    {
        if (playerchatbubble1.activeSelf == false && unknownchatbubble1.activeSelf == true)
        {
            playerchatbubble1.SetActive(true);
            unknownchatbubble2.SetActive(true);
        }
        
        if (playerchatbubble2.activeSelf == false && unknownchatbubble2.activeSelf == true)
        {
            playerchatbubble2.SetActive(true);
            unknownchatbubble3.SetActive(true);
        }
    }
}
