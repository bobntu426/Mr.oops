using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs_info : MonoBehaviour
{
    public static playerprefs_info player;
    
    //piayerprefs��key

    //�i��
    public int high_level;//�w�g�}�F�ĴX���F key:
    public int[] level_star = new int[20];//�U�����P�� key:level1_star, level2_star......
    public int[] level_score=new int[20];//�U�����̰����� key:level1_score, level2_score......
    public int high_score; //�p���Ҧ��̰�����
    public int star;//�`�@��o�X���P�P
    public int crown;//�`�@��o�X�Ӭӫa

    //��o���D�� ���G1 �L�G0
    public int mushroom;//
    public int ice;//
    public int sun;//
    public int dust;//
    public int virus;//

    //��o������ ���G1 �L�G0


    //�ثe��Ϊ�����
    public string character_name;
    Object character_pre;
    public GameObject character;

    //�ثe��Ϊ�����
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
