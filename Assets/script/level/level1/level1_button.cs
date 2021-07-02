using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1_button : MonoBehaviour
{
    public GameObject pause_panel, man;
    public int level_index;
    
    public void setting_button() { SceneManager.LoadScene(2); }
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
        level1_manager.manager.man.GetComponent<level1_man>().enabled = false;
    }

    public void continue_button()
    {
        Time.timeScale = 1;
        pause_panel.SetActive(false);
        level1_manager.manager.man.GetComponent<level1_man>().enabled = true;
    }
    public void level_finish_restart_button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(level_index);

    }
}
