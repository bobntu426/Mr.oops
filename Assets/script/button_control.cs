using UnityEngine;
using UnityEngine.SceneManagement;

public class button_control : MonoBehaviour
{
    public GameObject pause_panel,man;
    public int level_index;
    public void infinit_mode_button()
    {
        SceneManager.LoadScene(1);
    }
    public void setting_button() { SceneManager.LoadScene(2); }
    public void return_button() 
    {
        Time.timeScale = 1;
        man.GetComponent<man_control>().enabled = true;
        SceneManager.LoadScene(0); 
    }
    public void pause_restart_button() 
    {
        man.GetComponent<man_control>().enabled = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void level_mode_button() { SceneManager.LoadScene("choose_level"); }
    public void level1_button() { SceneManager.LoadScene("level1_scene"); }
    public void pause_button() 
    {
        Time.timeScale = 0;
        pause_panel.SetActive(true);
        man.GetComponent<man_control>().enabled = false;
    }

    public void continue_button() 
    {
        Time.timeScale = 1;
        pause_panel.SetActive(false);
        man.GetComponent<man_control>().enabled =true;
    }
    public void level_finish_restart_button()
    {
        man.GetComponent<man_control>().enabled = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(level_index);

    }
    public void infinit_finish_restart_button()
    {
        man.GetComponent<man_control>().enabled = true;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
}
