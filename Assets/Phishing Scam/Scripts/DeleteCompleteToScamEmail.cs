using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteCompleteToScamEmail : MonoBehaviour
{
    public void MoveToDeleteCompletetoScamEmail(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
