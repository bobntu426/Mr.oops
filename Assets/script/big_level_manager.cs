using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class big_level_manager : MonoBehaviour
{
    public static big_level_manager big;
    public int big_level, choose_level;
    public GameObject[] level,button;
    private void Awake()
    {
        if (big == null)
            big = this;
    }
    public void Start()
    {
        for (int i = 0; i < playerprefs_info.player.big_high_level; i++)
        {
            level[i].SetActive(false);
            button[i].SetActive(true);
        }

    }
}
