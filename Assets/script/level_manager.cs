using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_manager : MonoBehaviour
{
    public static level_manager manager;
    public GameObject[] level;
    public GameObject level_status;
    
    void Awake()
    {
        if (manager == null)
        {
            manager = this;
        }
    }
    private void Start()
    {
        for (int i = 0; i < playerprefs_info.player.high_level; i++)
        {
            level[i + 1].SetActive(true);
        }
    }
}
