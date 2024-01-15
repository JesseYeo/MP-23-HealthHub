using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRandomiser : MonoBehaviour
{

    public int[] scenes;
    
    

    // Start is called before the first frame update
    void Start()
    {


        //int rand = Random.Range(0,scenes.Length);

        //SceneManager.LoadScene(scenes[rand]);

        //int[] current = scenes;

        SceneManager.LoadScene(60);

    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
