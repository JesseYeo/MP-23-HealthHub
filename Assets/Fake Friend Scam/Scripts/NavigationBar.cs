using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationBar : MonoBehaviour
{
    public GameObject StartingScreen;
    public GameObject LoginScreen;
    public GameObject PaymentScreen;
    public GameObject TransferScreen;

    public void ToHome()
    {
        SceneManager.LoadScene("Level2Homepage");
    }

    public void ToBackPaymentMenu()
    {
        if (StartingScreen.activeSelf == true)
        {
            SceneManager.LoadScene("Level2Homepage");
        }
        else if (LoginScreen.activeSelf == true)
        {
            StartingScreen.SetActive(true);
            LoginScreen.SetActive(false);
        }
        else if (PaymentScreen.activeSelf == true)
        {
            StartingScreen.SetActive(true);
            PaymentScreen.SetActive(false);
        }
        else if (TransferScreen.activeSelf == true)
        {
            PaymentScreen.SetActive(true);
            TransferScreen.SetActive(false);
        }
    }

    public void ToBackChats()
    {
        SceneManager.LoadScene("ChatsMenu");
    }
}
