using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PayButton : MonoBehaviour
{
    public void MoveToPaymentScreen(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
