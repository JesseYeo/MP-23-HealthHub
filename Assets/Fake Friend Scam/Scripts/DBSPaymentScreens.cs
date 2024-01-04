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
    
    public void ToLoginScreen()
    {
        StartingScreen.SetActive(false);
        LoginScreen.SetActive(true);
    }

    public void ToPaymentScreen()
    {
        LoginScreen.SetActive(false);
        PaymentScreen.SetActive(true);
    }

    public void ToTransferScreen()
    {
        PaymentScreen.SetActive(false);
        TransferScreen.SetActive(true);
    }
}
