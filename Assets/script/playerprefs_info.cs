using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs_info : MonoBehaviour
{
    public static playerprefs_info player;
    
    //piayerprefs的key

    //進度
    public int high_level;
    public int level1_score;
    public int level2_score;
    public int level3_score;
    public int level4_score;
    public int level5_score;
    public int level6_score;
    public int level7_score;
    public int level8_score;
    public int level9_score;
    public int level10_score;
    public int level11_score;
    public int level12_score;
    public int level13_score;
    public int level14_score;
    public int level15_score;
    public int level16_score;
    public int level17_score;
    public int level18_score;
    public int level19_score;
    public int level20_score;
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
        level1_score= PlayerPrefs.GetInt("level1_score"); 
        level2_score= PlayerPrefs.GetInt("level2_score"); 
        level3_score = PlayerPrefs.GetInt("level3_score"); 
        level4_score = PlayerPrefs.GetInt("level4_score"); 
        level5_score = PlayerPrefs.GetInt("level5_score"); 
        level6_score = PlayerPrefs.GetInt("level6_score"); 
        level7_score = PlayerPrefs.GetInt("level7_score"); 
        level8_score = PlayerPrefs.GetInt("level8_score"); 
        level9_score = PlayerPrefs.GetInt("level9_score"); 
        level10_score = PlayerPrefs.GetInt("level10_score");
        level11_score = PlayerPrefs.GetInt("level11_score");
        level12_score = PlayerPrefs.GetInt("level12_score");
        level13_score = PlayerPrefs.GetInt("level13_score");
        level14_score = PlayerPrefs.GetInt("level14_score");
        level15_score = PlayerPrefs.GetInt("level15_score");
        level16_score = PlayerPrefs.GetInt("level16_score");
        level17_score = PlayerPrefs.GetInt("level17_score");
        level18_score = PlayerPrefs.GetInt("level18_score");
        level19_score = PlayerPrefs.GetInt("level19_score");
        level20_score = PlayerPrefs.GetInt("level20_score");
        if (character_name == "")
        {
            character = (GameObject)Resources.Load("prefab/character/man");
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
