using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish_scene : MonoBehaviour
{
    public GameObject scoreUI;
    void Start()
    {
        
        Vector2 a = new Vector2(-65f, 75f);
        scoreUI.GetComponent<Text>().text = "your score : " + gamemanager.manager.round;
        Instantiate(scoreUI, a, Quaternion.identity);
    }


}
