using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_manager : MonoBehaviour
{
    public static level_manager manager;
    public GameObject[] level;
    public GameObject level_status;
    public GameObject black_star1, black_star2, black_star3, star1, star2, star3, black_crown, crown,level_text,pass_text,highscore_text;
    public int choose_level;

    void Awake()
    {
        if (manager == null)
        {
            manager = this;
        }
    }
    private void Start()
    {
        for (int i = 0; i < playerprefs_info.player.high_level; i++)
        {
            level[i + 1].SetActive(true);
        }
    }
    public void check_pass(int star1_score,int star2_score, int star3_score , int crown_score, string level_str)
    {
        
        if (PlayerPrefs.GetInt(level_str) == crown_score)
        {
            black_crown.SetActive(false);
            crown.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            black_star1.SetActive(false);
            black_star2.SetActive(false);
            black_star3.SetActive(false);
            choose_level = 1;
            level_text.GetComponent<Text>().text = "level" + choose_level;
            pass_text.GetComponent<Text>().text = "篈Ч硄闽";
            highscore_text.GetComponent<Text>().text = "程ㄎ眔だ" + PlayerPrefs.GetInt(level_str);
            level_status.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(level_str) >= star3_score)
        {
            black_crown.SetActive(true);
            crown.SetActive(false);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            black_star1.SetActive(false);
            black_star2.SetActive(false);
            black_star3.SetActive(false);
            choose_level = 1;
            level_text.GetComponent<Text>().text = "level" + choose_level;
            pass_text.GetComponent<Text>().text = "篈硄闽" ;
            highscore_text.GetComponent<Text>().text = "程ㄎ眔だ" + PlayerPrefs.GetInt(level_str);
            level_status.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(level_str) >= star2_score)
        {
            black_crown.SetActive(true);
            crown.SetActive(false);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
            black_star1.SetActive(false);
            black_star2.SetActive(false);
            black_star3.SetActive(true);
            choose_level = 1;
            level_text.GetComponent<Text>().text = "level" + choose_level;
            pass_text.GetComponent<Text>().text = "篈硄闽" ;
            highscore_text.GetComponent<Text>().text = "程ㄎ眔だ" + PlayerPrefs.GetInt(level_str);
            level_status.SetActive(true);
        }
        else if (PlayerPrefs.GetInt(level_str) >= star1_score)
        {
            black_crown.SetActive(true);
            crown.SetActive(false);
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
            black_star1.SetActive(false);
            black_star2.SetActive(true);
            black_star3.SetActive(true);

            choose_level = 1;
            level_text.GetComponent<Text>().text = "level" + choose_level;
            pass_text.GetComponent<Text>().text = "篈硄闽" ;
            highscore_text.GetComponent<Text>().text = "程ㄎ眔だ" + PlayerPrefs.GetInt(level_str);
            level_status.SetActive(true);
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

            choose_level = 1;
            level_text.GetComponent<Text>().text = "level" + choose_level;
            pass_text.GetComponent<Text>().text = "篈ゼ硄闽";
            highscore_text.GetComponent<Text>().text = "程ㄎ眔だ" + PlayerPrefs.GetInt(level_str);
            level_status.SetActive(true);
        }
    }
}
