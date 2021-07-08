using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class choose_level_button : MonoBehaviour
{
    GameObject level_status;
    public void level1_button() 
    {
        level_manager.manager.choose_level = 1;
        level_manager.manager.check_pass((int)level_manager.manager.goal[0].x, (int)level_manager.manager.goal[0].y, (int)level_manager.manager.goal[0].z, (int)level_manager.manager.goal[0].w, "score1-1");
        level_manager.manager.challenge[0].SetActive(true);
        
    }
    public void level2_button()
    {
        level_manager.manager.choose_level = 2;
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
}
