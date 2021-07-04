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
        level_manager.manager.check_pass((int)level_manager.manager.goal[0].x, (int)level_manager.manager.goal[0].y, (int)level_manager.manager.goal[0].z, (int)level_manager.manager.goal[0].w, "level1_score");
    }
    public void play_level1_button() { SceneManager.LoadScene("level1_scene"); }
    public void cancel_button() { level_manager.manager.level_status.SetActive(false); }
    public void return_button()
    {
        SceneManager.LoadScene(0);
    }
}
