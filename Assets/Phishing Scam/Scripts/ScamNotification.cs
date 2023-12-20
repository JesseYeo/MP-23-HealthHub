using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScamNotification : MonoBehaviour
{
    [SerializeField]

    float time;

    [SerializeField]

    public LeanTweenType type;

    void Start()
    {
        LeanTween.moveLocal(gameObject,new Vector3(0, 109f, 0f),.1f).setDelay(0f).setEase(LeanTweenType.easeInOutCirc); 
    }

     void Update()
    {
        
    }
    public void MoveToScamEmail(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
