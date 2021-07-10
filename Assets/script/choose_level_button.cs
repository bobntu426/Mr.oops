using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class choose_level_button : MonoBehaviour
{
    public GameObject level_status, man, city, factory, boat,forest,ice;

    public void level1_button() 
    {
        big_level_manager.big.choose_level = 1;
        level_manager.manager.check_pass((int)level_manager.manager.goal[0].x, (int)level_manager.manager.goal[0].y, (int)level_manager.manager.goal[0].z, (int)level_manager.manager.goal[0].w, "score1-1");
        level_manager.manager.challenge[0].SetActive(true);
        
    }
    public void level2_button()
    {
        big_level_manager.big.choose_level = 2;
        level_manager.manager.check_pass((int)level_manager.manager.goal[1].x, (int)level_manager.manager.goal[1].y, (int)level_manager.manager.goal[1].z, (int)level_manager.manager.goal[1].w, "score1-2");
        level_manager.manager.challenge[1].SetActive(true);
    }
    public void play_level1_button()
    { 
        SceneManager.LoadScene("level1-1_scene");
    }
    public void play_level2_button() { SceneManager.LoadScene("level1-2_scene"); }
    public void cancel_button() { level_manager.manager.level_status.SetActive(false); }
    public void return_button()
    {
        SceneManager.LoadScene(0);
    }


    //選大關專用
    public void big_level1()
    {
        man.transform.localPosition = new Vector3(-2459,-284,-1);
        city.transform.GetChild(0).gameObject.SetActive(true);
        factory.transform.GetChild(0).gameObject.SetActive(false);
        boat.transform.GetChild(0).gameObject.SetActive(false);
        forest.transform.GetChild(0).gameObject.SetActive(false);
        forest.transform.GetChild(1).gameObject.SetActive(false);
        ice.transform.GetChild(0).gameObject.SetActive(false);
        city.GetComponent<Animator>().SetBool("city", true);

    }
    public void big_level2()
    {
        man.transform.localPosition = new Vector3(-2207, -246,-1);
        factory.transform.GetChild(0).gameObject.SetActive(true);
        city.transform.GetChild(0).gameObject.SetActive(false);
        boat.transform.GetChild(0).gameObject.SetActive(false);
        forest.transform.GetChild(0).gameObject.SetActive(false);
        forest.transform.GetChild(1).gameObject.SetActive(false);
        ice.transform.GetChild(0).gameObject.SetActive(false);
    }
    public void big_level3()
    {
        boat.transform.GetChild(0).gameObject.SetActive(true);
        city.transform.GetChild(0).gameObject.SetActive(false);
        factory.transform.GetChild(0).gameObject.SetActive(false);
        forest.transform.GetChild(0).gameObject.SetActive(false);
        forest.transform.GetChild(1).gameObject.SetActive(false);
        ice.transform.GetChild(0).gameObject.SetActive(false);
    }
    public void big_level45()
    {
        forest.transform.GetChild(0).gameObject.SetActive(true);
        if(playerprefs_info.player.big_high_level>=4)
            forest.transform.GetChild(1).gameObject.SetActive(true);
        city.transform.GetChild(0).gameObject.SetActive(false);
        factory.transform.GetChild(0).gameObject.SetActive(false);
        boat.transform.GetChild(0).gameObject.SetActive(false);
        ice.transform.GetChild(0).gameObject.SetActive(false);
    }

    public void big_level6()
    {
        ice.transform.GetChild(0).gameObject.SetActive(true);
        city.transform.GetChild(0).gameObject.SetActive(false);
        factory.transform.GetChild(0).gameObject.SetActive(false);
        boat.transform.GetChild(0).gameObject.SetActive(false);
        forest.transform.GetChild(0).gameObject.SetActive(false);
        forest.transform.GetChild(1).gameObject.SetActive(false);
    }



    public void big_level1_button()
    {
        big_level_manager.big.big_level = 1;

        SceneManager.LoadScene("big1_scene");
        
    }
    public void big_level2_button()
    {
        big_level_manager.big.big_level = 2;
        SceneManager.LoadScene("big2_scene");
    }
    public void big_level3_button()
    {
        big_level_manager.big.big_level = 3;
        SceneManager.LoadScene("big3_scene");
        
    }
    public void big_level4_button()
    {
        big_level_manager.big.big_level = 4;
        SceneManager.LoadScene("big4_scene");
        
    }
    public void big_level5_button()
    {
        big_level_manager.big.big_level = 5;
        
        SceneManager.LoadScene("big5_scene");
        
    }
    public void big_level6_button()
    {
        big_level_manager.big.big_level = 6;
        SceneManager.LoadScene("big6_scene");
        
    }


}
