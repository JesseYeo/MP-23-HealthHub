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

    public bool optionsopen;

    //general messages/replies
    public GameObject sG_msg_select_option1;

    //scenario A options
    public GameObject sA_msg_select_option1;

    //scenario B options
    public GameObject sB_msg_select_option1;


    //check what messages has been sent by player
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
        optionsopen = false;
        Invoke("UnknownReply1", 1);
    }
    
    public void SendMessage2()
    {
        messageoption2.SetActive(false);
        message2.SetActive(true);
        sent2 = true;
        optionsopen = false;
        Invoke("UnknownReply2", 1);
    }
    
    public void SendMessage3()
    {
        messageoption3.SetActive(false);
        messageoption4.SetActive(false);
        message3.SetActive(true);
        sent3 = true;
        optionsopen = false;
        Invoke("UnknownReply3", 1);
    }
    
    public void SendMessage4()
    {
        messageoption3.SetActive(false);
        messageoption4.SetActive(false);
        message4.SetActive(true);
        sent4 = true;
        optionsopen = false;
        Invoke("UnknownReply4", 1);
    }
    
    
    //methods used when invoking replies from unknown number
    public void UnknownReply1()
    {
        unknownreply1.SetActive(true);
    }

    public void UnknownReply2()
    {
        unknownreply2.SetActive(true);        
    }

    public void UnknownReply3()
    {
        unknownreply3.SetActive(true);
    }

    public void UnknownReply4()
    {
        unknownreply4.SetActive(true);
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
            unknownreply2.SetActive(true);
        }

        if (sent3 == true)
        {
            message3.SetActive(true);
            unknownreply3.SetActive(true);
        }

        if (sent4 == true)
        {
            message4.SetActive(true);
            unknownreply4.SetActive(true);
        }
    }

    public void OpenMessageOptions()
    {
        if (optionsopen == true)
        {
            optionsopen = false;
            messageoption1.SetActive(false);
            messageoption2.SetActive(false);
            messageoption3.SetActive(false);
            messageoption4.SetActive(false);
        }
        else
        {
            if (sent1 != true)
            {
                optionsopen = true;
                messageoption1.SetActive(true);
            }
            else if (sent2 != true)
            {
                optionsopen = true;
                messageoption2.SetActive(true);
            }
            else if (sent3 != true && sent4 != true)
            {
                optionsopen = true;
                messageoption3.SetActive(true);
                messageoption4.SetActive(true);
            }          
        }
    

    }
}
