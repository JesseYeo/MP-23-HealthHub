using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaymentScreen : MonoBehaviour
{
    public void MoveToPaymentLoading(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
