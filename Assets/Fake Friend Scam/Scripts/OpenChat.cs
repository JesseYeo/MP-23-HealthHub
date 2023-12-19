using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChat : MonoBehaviour
{
    public GameObject mainpage;
    public GameObject unknownchat;
 public void OpenUnknown()
    {
        mainpage.SetActive(false);
        unknownchat.SetActive(true);
    }
}
