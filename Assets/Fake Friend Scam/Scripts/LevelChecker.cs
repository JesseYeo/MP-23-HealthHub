using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChecker : MonoBehaviour
{
    public GameObject hintbutton;
    public GameObject level2title;
    public GameObject level4title;
    
    // Start is called before the first frame update
    void Start()
    {
        if (LevelStart.level4 == true)
        {
            level4title.SetActive(true);
            hintbutton.SetActive(false);
        }

        if (LevelStart.level2 == true)
        {
            level2title.SetActive(true);
            hintbutton.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelStart.level4 == true)
        {
            level4title.SetActive(true);
            hintbutton.SetActive(false);
        }

        if (LevelStart.level2 == true)
        {
            level2title.SetActive(true);
            hintbutton.SetActive(true);
        }
    }
}
