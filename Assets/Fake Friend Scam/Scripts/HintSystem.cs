using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintSystem : MonoBehaviour
{
    public GameObject dbshint1;
    public GameObject dbshint2;
    public GameObject dbshint3;
    public GameObject dbshint4;

    public GameObject startingscreen;
    public GameObject loginscreen;
    public GameObject paymentscreen;
    public GameObject transferscreen;

    public bool dbshintopen;



    public GameObject unknownhint1;
    public GameObject unknownhint2;
    public GameObject unknownhint3;

    public GameObject unknowncheckpoint1;
    public GameObject unknowncheckpoint2;
    public GameObject unknowncheckpoint3;

    public bool unknownhintopen;



    public GameObject stevenhint1;
    public GameObject stevenhint2;

    public GameObject stevenmessagecheck;

    public bool stevenhintopen;

    public void DBSHints()
    {
        if (dbshintopen == true)
        {
            dbshintopen = false;
            dbshint1.SetActive(false);
            dbshint2.SetActive(false);
            dbshint3.SetActive(false);
            dbshint4.SetActive(false);
        }
        else if (startingscreen.activeSelf == true)
        {
            dbshint1.SetActive(true);
            dbshintopen = true;
        }
        else if (loginscreen.activeSelf == true)
        {
            dbshint2.SetActive(true);
            dbshintopen = true;
        }
        else if (paymentscreen.activeSelf == true)
        {
            dbshint3.SetActive(true);
            dbshintopen = true;
        }
        else if (transferscreen.activeSelf == true)
        {
            dbshint4.SetActive (true);
            dbshintopen = true;
        }
    }

    public void StevenHints()
    {
        if (stevenhintopen == true)
        {
            stevenhintopen = false;
            stevenhint1.SetActive(false);
            stevenhint2.SetActive(false);
        }
        else
        {
            if (stevenmessagecheck.activeSelf == true)
            {
                stevenhint2.SetActive(true);
                stevenhintopen = true;
            }
            else
            {
                stevenhint1.SetActive(true);
                stevenhintopen = true; ;
            }

        }
    }

    public void UnknownHints()
    {
        if (unknownhintopen == true)
        {
            unknownhintopen = false;
            unknownhint1.SetActive(false);
            unknownhint2.SetActive(false);
            unknownhint3.SetActive(false);
        }
        else
        {
            if (unknowncheckpoint1.activeSelf == true || unknowncheckpoint2.activeSelf == true)
            {
                unknownhint3.SetActive(true);
                unknownhintopen = true;
            }
            else if (unknowncheckpoint3.activeSelf == true)
            {
                unknownhint2.SetActive(true);
                unknownhintopen = true;
            }
            else
            {
                unknownhint1.SetActive(true);
                unknownhintopen = true;
            }
        }

    }
}
