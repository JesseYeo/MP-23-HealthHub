using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRandomiser : MonoBehaviour
{
    string[] scams = new string[3] { "Phishing Scam", "Fake Friend Scam", "Malware Scam" };
    int random = Random.Range(0, 3);
    //Application.LoadLevel(scams[random]);

     //string[] zones = new string[3] { "zoneA", "zoneB", "zoneC" };
    //int random = Random.Range(0, 3);
    //Application.LoadLevel(zones[random]);
}
