using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish_scene : MonoBehaviour
{
    public GameObject scoreUI, highscore_UI;
    void Start()
    {
        scoreUI.GetComponent<Text>().text = "your score : " + gamemanager.manager.round;
        highscore_UI.GetComponent<Text>().text = "high score : " + playerprefs_info.player.high_score;
    }


}
