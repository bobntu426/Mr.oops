using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level1_finish : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject black_star1, black_star2, black_star3, star1, star2, star3, black_crown, crown,pass,score,high_score;
    void Start()
    {
        if (PlayerPrefs.GetInt("level1_score") == 20)
        {
            black_crown.SetActive(false);
            crown.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            black_star1.SetActive(false);
            black_star2.SetActive(false);
            black_star3.SetActive(false);
            if (playerprefs_info.player.high_level == 0)
                PlayerPrefs.SetInt("high_level", 1);
        }
        else if (PlayerPrefs.GetInt("level1_score")>= 15)
        {
            black_crown.SetActive(true);
            crown.SetActive(false);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            black_star1.SetActive(false);
            black_star2.SetActive(false);
            black_star3.SetActive(false);
            if (playerprefs_info.player.high_level == 0)
                PlayerPrefs.SetInt("high_level", 1);
        }
        else if (PlayerPrefs.GetInt("level1_score") >= 10)
        {
            black_crown.SetActive(true);
            crown.SetActive(false);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
            black_star1.SetActive(false);
            black_star2.SetActive(false);
            black_star3.SetActive(true);
            if (playerprefs_info.player.high_level == 0)
                PlayerPrefs.SetInt("high_level", 1);
        }
        else if (PlayerPrefs.GetInt("level1_score") >= 5)
        {
            black_crown.SetActive(true);
            crown.SetActive(false);
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
            black_star1.SetActive(false);
            black_star2.SetActive(true);
            black_star3.SetActive(true);
            if(playerprefs_info.player.high_level==0)
                PlayerPrefs.SetInt("high_level", 1);
        }
        else
        {
            black_crown.SetActive(true);
            crown.SetActive(false);
            star1.SetActive(false);
            star2.SetActive(false);
            star3.SetActive(false);
            black_star1.SetActive(true);
            black_star2.SetActive(true);
            black_star3.SetActive(true);
            pass.GetComponent<Text>().text = "level1 未通關";
        }
        high_score.GetComponent<Text>().text = "最高得分："+playerprefs_info.player.level1_score;
        score.GetComponent<Text>().text = "本次得分：" + level1_manager.manager.round;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
