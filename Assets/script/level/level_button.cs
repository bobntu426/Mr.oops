using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_button : MonoBehaviour
{
    public GameObject pause_panel, man;
    public int level_index;
    
    public void return_button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void pause_restart_button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void pause_button()
    {
        Time.timeScale = 0;
        pause_panel.SetActive(true);
        GameObject.Find(playerprefs_info.player.character_name+"(Clone)").GetComponent<MonoBehaviour>().enabled = false;
    }

    public void continue_button()
    {
        Time.timeScale = 1;
        pause_panel.SetActive(false);
        GameObject.Find(playerprefs_info.player.character_name+"(Clone)").GetComponent<MonoBehaviour>().enabled = true;
    }
    public void level_finish_restart_button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("level1-"+level_manager.manager.choose_level+"_scene");

    }
    public void return_choose_button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("choose_level");

    }
}
