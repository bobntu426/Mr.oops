using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choose_level_button : MonoBehaviour
{
    GameObject level_status;
    public void level1_button() { level_manager.manager.level_status.SetActive(true); }
    public void play_level1_button() { SceneManager.LoadScene("level1_scene"); }
    public void cancel_button() { level_manager.manager.level_status.SetActive(false); }
    public void return_button()
    {
        SceneManager.LoadScene(0);
    }
}
