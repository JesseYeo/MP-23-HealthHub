using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Homepage : MonoBehaviour
{
    public void ToWhatsapp()
    {
        SceneManager.LoadScene("ChatsMenu");
    }

    public void ToDBS()
    {
        SceneManager.LoadScene("AppPaymentMenu");
    }

}
