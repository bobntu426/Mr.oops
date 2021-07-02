using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs_info : MonoBehaviour
{
    public static playerprefs_info player;
    
    //piayerprefs的key

    //進度
    public int high_level;
    public int high_score;

    //獲得的主角 有：1 無：0
    public int mushroom;
    public int ice;
    public int sun;
    public int dust;
    public int virus;

    //獲得的場景 有：1 無：0


    //目前選用的角色
    public string character_name;
    Object character_pre;
    public GameObject character;

    //目前選用的場景
    public string scene_name;
    Object scene_pre;
    public GameObject scene;
    void Awake()
    {
        if (player == null)
        {
            player = this;
        }

        
        high_score = PlayerPrefs.GetInt("high_score");
        high_level = PlayerPrefs.GetInt("high_level");
        mushroom = PlayerPrefs.GetInt("mushroom");
        ice = PlayerPrefs.GetInt("ice");
        sun = PlayerPrefs.GetInt("sun");
        dust = PlayerPrefs.GetInt("dust");
        virus = PlayerPrefs.GetInt("virus");
        character_name = PlayerPrefs.GetString("character_name");
        scene_name = PlayerPrefs.GetString("scene_name");
        character = (GameObject)Resources.Load("prefab/character/" + character_name);
        scene = (GameObject)Resources.Load("prefab/character/" + scene_name);
        if (character_name == "")
        {
            character = (GameObject)Resources.Load("prefab/character/ice");
        }
    }

    private void Start()
    {


    }
    public void deletebutton()
    {
        PlayerPrefs.DeleteAll();
    }
    private void Update()
    {
        

    }
}
