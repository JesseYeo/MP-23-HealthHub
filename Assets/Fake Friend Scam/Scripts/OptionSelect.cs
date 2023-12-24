using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionSelect : MonoBehaviour
{
    public GameObject chatoption1;
    public GameObject chatoption2;
    public GameObject chatoption3;
    public GameObject chatoption4;

    public GameObject messagedisplay1;
    public GameObject messagedisplay2; 
    public GameObject messagedisplay3;
    public GameObject messagedisplay4;

    public bool option1;
    public bool option2;
    public bool option3;
    public bool option4;

    private void Start()
    {
        option1 = false;
        option2 = false;
        option3 = false;
        option4 = false;
    }

    public void onSelectOption1()
    {
        option1 = true;
        chatoption1.SetActive(false);
        messagedisplay1.SetActive(true);
    }

    public void onSelectOption2()
    {
        option2 = true;
        chatoption2.SetActive(false);
        messagedisplay2.SetActive(true);
    }

    public void onSelectOption3()
    {
        option3 = true;
        chatoption3.SetActive(false);
        if (chatoption4.activeSelf)
        {
            chatoption4.SetActive(false);
        }
        messagedisplay3.SetActive(true);
    }

    public void onSelectOption4()
    {
        option4 = true;
        chatoption4.SetActive(false);
        if (chatoption3.activeSelf)
        {
            chatoption3.SetActive(false);
        }
        messagedisplay4.SetActive(true);
    }
}
