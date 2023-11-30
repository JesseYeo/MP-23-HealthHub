using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaymentComplete : MonoBehaviour
{
    public void MoveToScammedScreen(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
