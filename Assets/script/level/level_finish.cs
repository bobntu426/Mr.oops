using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_finish : MonoBehaviour
{
    public GameObject black_star1, black_star2, black_star3, star1, star2, star3, black_crown, crown,pass,score,high_score,return_button,restart,choose;
    public static int round;
    public GameObject button_mananger;

    private void Awake()
    {
        button_mananger=GameObject.Find("level_button");
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("score1-"+big_level_manager.big.choose_level) == (int)level_manager.manager.goal[big_level_manager.big.choose_level-1].w)
        {
            PlayerPrefs.SetInt("star1-"+big_level_manager.big.choose_level, 4);
            
            if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 0)
            {
                bright_star1();
                bright_star2();
                bright_star3();
                bright_crown();
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 1)
            {
                disable_button();
                bright_star1();
                bright_star2();
                bright_star3();
                Invoke("bright_crown", 0.5f);
                Invoke("enable_button", 0.7f);
                PlayerPrefs.SetInt("crown", playerprefs_info.player.crown + 1);
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 2)
            {
                disable_button();
                bright_star1();
                bright_star2();
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 1);
                PlayerPrefs.SetInt("crown", playerprefs_info.player.crown + 1);
                Invoke("bright_star3", 0.5f);
                Invoke("bright_crown", 1f);
                Invoke("enable_button",1.2f);
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 3)
            {
                disable_button();
                bright_star1();
                Invoke("bright_star2", 0.5f);
                Invoke("bright_star3", 1f);
                Invoke("bright_crown", 1.5f);
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 2);
                PlayerPrefs.SetInt("crown", playerprefs_info.player.crown + 1);
                Invoke("enable_button", 1.7f);
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 4)
            {
                disable_button();
                Invoke("bright_star1", 0.5f);
                Invoke("bright_star2", 1f);
                Invoke("bright_star3", 1.5f);
                Invoke("bright_crown", 2f);
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 3);
                PlayerPrefs.SetInt("crown", playerprefs_info.player.crown + 1);
                Invoke("enable_button", 2.2f);

            }
            if (playerprefs_info.player.high_level[big_level_manager.big.big_level] == big_level_manager.big.choose_level - 1)
                PlayerPrefs.SetInt("high_level"+ big_level_manager.big.big_level, big_level_manager.big.choose_level);
        }
        else if (PlayerPrefs.GetInt("score1-"+big_level_manager.big.choose_level) >= (int)level_manager.manager.goal[big_level_manager.big.choose_level - 1].z)
        {
            PlayerPrefs.SetInt("star1-"+big_level_manager.big.choose_level, 3);
            if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 0)
            {
                bright_star1();
                bright_star2();
                bright_star3();
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 1)
            {
                disable_button();
                bright_star1();
                bright_star2();
                Invoke("bright_star3", 0.5f);
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 1);
                Invoke("enable_button", 0.7f);
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 2)
            {
                disable_button();
                bright_star1();
                Invoke("bright_star2", 0.5f);
                Invoke("bright_star3", 1f);
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 2);
                Invoke("enable_button", 1.2f);
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 3)
            {
                disable_button();
                Invoke("bright_star1", 0.5f);
                Invoke("bright_star2", 1f);
                Invoke("bright_star3", 1.5f);
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 3);
                Invoke("enable_button", 1.7f);
            }
            if (playerprefs_info.player.high_level[big_level_manager.big.big_level] == big_level_manager.big.choose_level-1)
                PlayerPrefs.SetInt("high_level"+ big_level_manager.big.big_level, big_level_manager.big.choose_level);
        }
        else if (PlayerPrefs.GetInt("score1-"+big_level_manager.big.choose_level) >= (int)level_manager.manager.goal[big_level_manager.big.choose_level - 1].y)
        {
            PlayerPrefs.SetInt("star1-"+big_level_manager.big.choose_level, 2);

            if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 0)
            {
                bright_star1();
                bright_star2();
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 1)
            {
                disable_button();
                bright_star1();
                Invoke("bright_star2", 0.5f);
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 1);
                Invoke("enable_button", 0.7f);
            }
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 2)
            {
                disable_button();
                Invoke("bright_star1", 0.5f);
                Invoke("bright_star2", 1f);
                Invoke("enable_button", 1.2f);
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 2);
            }
            if (playerprefs_info.player.high_level[big_level_manager.big.big_level] == big_level_manager.big.choose_level-1)
                PlayerPrefs.SetInt("high_level"+ big_level_manager.big.big_level, big_level_manager.big.choose_level);
        }
        else if (PlayerPrefs.GetInt("score1-"+big_level_manager.big.choose_level) >= (int)level_manager.manager.goal[big_level_manager.big.choose_level - 1].x)
        {
            PlayerPrefs.SetInt("star1-"+big_level_manager.big.choose_level, 1);
            
            if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 0)
                bright_star1();
            else if (PlayerPrefs.GetInt("star1-"+big_level_manager.big.choose_level) - playerprefs_info.player.world1_star[big_level_manager.big.choose_level - 1] == 1)
            {
                disable_button();
                Invoke("bright_star1", 0.5f);
                PlayerPrefs.SetInt("star", playerprefs_info.player.star + 1);
                Invoke("enable_button", 0.7f);
            }
            if (playerprefs_info.player.high_level[big_level_manager.big.big_level ]== big_level_manager.big.choose_level-1)
                PlayerPrefs.SetInt("high_level"+ big_level_manager.big.big_level, big_level_manager.big.choose_level);
        }
        else
        {
            pass.GetComponent<Text>().text = "level"+big_level_manager.big.choose_level+" 未通關";
        }
        high_score.GetComponent<Text>().text = "最高得分："+PlayerPrefs.GetInt("score1-"+big_level_manager.big.choose_level);
        score.GetComponent<Text>().text = "本次得分：" + round;
    }

    // Update is called once per frame
    void bright_crown()
    {
        black_crown.SetActive(false);
        crown.SetActive(true);
    }
    void bright_star3() {
        star3.SetActive(true);
        black_star3.SetActive(false);
    }
    void bright_star2() 
    {
        star2.SetActive(true);
        black_star2.SetActive(false);
    }
    void bright_star1() 
    {
        star1.SetActive(true);
        black_star1.SetActive(false);
    }
    void enable_button()
    {
        restart.GetComponent<Button>().enabled = true;
        return_button.GetComponent<Button>().enabled = true;
        choose.GetComponent<Button>().enabled = true;
    }
    void disable_button()
    {
        restart.GetComponent<Button>().enabled = false;
        return_button.GetComponent<Button>().enabled = false;
        choose.GetComponent<Button>().enabled = false;
    }
}
