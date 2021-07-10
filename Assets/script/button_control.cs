using UnityEngine;
using UnityEngine.SceneManagement;

public class button_control : MonoBehaviour
{
    public GameObject pause_panel,man;
    public int level_index;
    public void Start()
    {
        //man=
    }
    public void infinit_mode_button()
    {
        SceneManager.LoadScene(1);
    }
    public void setting_button() { SceneManager.LoadScene("setting_scene"); }
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
    public void level_mode_button() 
    {
        SceneManager.LoadScene("big_level_scene");
    }

    public void pause_button() 
    {
        Time.timeScale = 0;
        pause_panel.SetActive(true);
        gamemanager.manager.man.GetComponent<man_control>().enabled = false;
    }

    public void continue_button() 
    {
        Time.timeScale = 1;
        pause_panel.SetActive(false);
        gamemanager.manager.man.GetComponent<man_control>().enabled =true;
    }

    public void infinit_finish_restart_button()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
    public void status_button()
    {
        SceneManager.LoadScene("status_scene");
    }
    public void collect_button()
    {
        SceneManager.LoadScene("character_scene");
    }
}
