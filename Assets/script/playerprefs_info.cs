using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs_info : MonoBehaviour
{
    public static playerprefs_info player;
    
    //piayerprefs的key

    //進度
    public int high_level;//已經破了第幾關了 key:
    public int[] level_star = new int[20];//各關的星數 key:level1_star, level2_star......
    public int[] level_score=new int[20];//各關的最高紀錄 key:level1_score, level2_score......
    public int high_score; //計分模式最高紀錄
    public int star;//總共獲得幾顆星星
    public int crown;//總共獲得幾個皇冠

    //獲得的主角 有：1 無：0
    public int mushroom;//
    public int ice;//
    public int sun;//
    public int dust;//
    public int virus;//

    //獲得的場景 有：1 無：0


    //目前選用的角色
    public string character_name;
    Object character_pre;
    public GameObject character;

    //目前選用的場景
    public string scene_name;
    public GameObject scene;
    void Awake()
    {
        if (player == null)
        {
            player = this;
        }

        level_star = new int[20];
        level_score = new int[20];
        high_score = PlayerPrefs.GetInt("high_score");
        high_level = PlayerPrefs.GetInt("high_level");
        mushroom = PlayerPrefs.GetInt("mushroom");
        ice = PlayerPrefs.GetInt("ice");
        sun = PlayerPrefs.GetInt("sun");
        dust = PlayerPrefs.GetInt("dust");
        virus = PlayerPrefs.GetInt("virus");
        star = PlayerPrefs.GetInt("star");
        crown = PlayerPrefs.GetInt("crown");
        character_name = PlayerPrefs.GetString("character_name");
        scene_name = PlayerPrefs.GetString("scene_name");
        character = (GameObject)Resources.Load("prefab/character/" + character_name);
        scene = (GameObject)Resources.Load("prefab/character/" + scene_name);
        
        for(int i=0;i<20;i++)
            level_score[i]= PlayerPrefs.GetInt("level"+(i+1)+"_score");
        for (int i = 0; i < 20; i++)
            level_star[i] = PlayerPrefs.GetInt("level" +(i+1)+ "_star");
        if (character_name == "")
        {
            character = (GameObject)Resources.Load("prefab/character/man");
            character_name = "man";
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
