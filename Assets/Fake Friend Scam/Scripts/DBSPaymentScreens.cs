using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DBSPaymentScreens : MonoBehaviour
{
    public GameObject StartingScreen;
    public GameObject LoginScreen;
    public GameObject PaymentScreen;
    public GameObject TransferScreen;
    
    public void ForwardToLoginScreen()
    {
        StartingScreen.SetActive(false);
        LoginScreen.SetActive(true);
    }

    public void ForwardToPaymentScreen()
    {
        LoginScreen.SetActive(false);
        PaymentScreen.SetActive(true);
    }

    public void ForwardToTransferScreen()
    {
        PaymentScreen.SetActive(false);
        TransferScreen.SetActive(true);
    }

    public void ForwardToLoseScreen()
    {
        if (Level4StartButton.level4 == true)
        {
            SceneManager.LoadScene("D Lose Screen");
        }
        else
        {
            SceneManager.LoadScene("Level2LoseScreen");
        }    
    }

    public void BacktoStartingScreenFromLogin()
    {
        StartingScreen.SetActive(true);
        LoginScreen.SetActive(false) ;
    }

    public void BacktoStartingScreenFromPayment()
    {
        StartingScreen.SetActive(true);
        PaymentScreen.SetActive(false);
    }

    public void BacktoPaymentScreen()
    {
        PaymentScreen.SetActive(true);
        TransferScreen.SetActive(false);
    }
}

