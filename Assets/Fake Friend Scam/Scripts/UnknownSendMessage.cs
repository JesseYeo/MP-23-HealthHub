using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnknownSendMessage : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject messageoption1;
    public GameObject messageoption2;
    public GameObject messageoption3;
    public GameObject messageoption4;

    public GameObject message1;
    public GameObject message2;
    public GameObject message3;
    public GameObject message4;

    public GameObject unknownreply1;
    public GameObject unknownreply2;
    public GameObject unknownreply3;
    public GameObject unknownreply4;

    public static bool sent1 = false;
    public static bool sent2 = false;
    public static bool sent3 = false;
    public static bool sent4 = false;

    //check what messages has been ent by player
    public void Start()
    {
        CheckforSent();
    }

    //on click methods for sending player messages
    public void SendMessage1()
    {
        messageoption1.SetActive(false);
        message1.SetActive(true);
        sent1 = true;
        Invoke("UnknownReply1", 1);
    }
    
    public void SendMessage2()
    {
        messageoption2.SetActive(false);
        message2.SetActive(true);
        sent2 = true;
    }
    
    public void SendMessage3()
    {
        messageoption3.SetActive(false);
        message3.SetActive(true);
        sent3 = true;
    }
    
    public void SendMessage4()
    {
        messageoption4.SetActive(false);
        message4.SetActive(true);
        sent4 = true;
    }
    
    
    //methods used when invoking replies from unknown number
    public void UnknownReply1()
    {
        unknownreply1.SetActive(true);
        messageoption2.SetActive(false);
    }

    public void UnknownReply2()
    {

    }

    public void UnknownReply3()
    {

    }


    //method for checking which messages player has previously sent
    public void CheckforSent()
    {
        if (sent1 == true)
        {
            message1.SetActive(true);
            unknownreply1.SetActive(true);
        }

        if (sent2 == true)
        {
            message2.SetActive(true);

        }

        if (sent3 == true)
        {
            message3.SetActive(true);
        }

        if (sent4 == true)
        {
            message4.SetActive(true);
        }
    }    
}
