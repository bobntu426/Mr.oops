using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs_info : MonoBehaviour
{
    public static playerprefs_info player;
    
    //piayerprefs��key

    //�i��
    public int high_level;//�w�g�}�F�ĴX���F key:
    public int[] world1_star = new int[10];
    public int[] world2_star = new int[10];
    public int[] world3_star = new int[10];
    public int[] world4_star = new int[10];
    public int[] world5_star = new int[10];
    public int[] world6_star = new int[10];//�U�����P�� key:star1-1, star2-2......

    public int[] world1_score=new int[10];
    public int[] world2_score = new int[10];
    public int[] world3_score = new int[10];
    public int[] world4_score = new int[10];
    public int[] world5_score = new int[10];
    public int[] world6_score = new int[10];//�U�����̰����� key:score1-1, score2-2......
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

        world1_star = new int[10];
        world1_score = new int[10];
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
        character = (GameObject)Resources.Load("prefab/character/" + character_name+"_in_game");
        scene = (GameObject)Resources.Load("prefab/character/" + scene_name);
        
        for(int i=0;i<10;i++)
            world1_score[i]= PlayerPrefs.GetInt("score1"+"-"+(i+1));
        for (int i = 0; i < 10; i++)
            world2_score[i] = PlayerPrefs.GetInt("score2" + "-" + (i + 1));
        for (int i = 0; i < 10; i++)
            world3_score[i] = PlayerPrefs.GetInt("score3" + "-" + (i + 1));
        for (int i = 0; i < 10; i++)
            world4_score[i] = PlayerPrefs.GetInt("score4" + "-" + (i + 1));
        for (int i = 0; i < 10; i++)
            world5_score[i] = PlayerPrefs.GetInt("score5" + "-" + (i + 1));
        for (int i = 0; i < 10; i++)
            world6_score[i] = PlayerPrefs.GetInt("score6" + "-" + (i + 1));


        for (int i = 0; i < 10; i++)
            world1_star[i] = PlayerPrefs.GetInt("star1" +"-"+ (i + 1));
        for (int i = 0; i < 10; i++)
            world2_star[i] = PlayerPrefs.GetInt("star2" + "-" + (i + 1));
        for (int i = 0; i < 10; i++)
            world3_star[i] = PlayerPrefs.GetInt("star3" + "-" + (i + 1));
        for (int i = 0; i < 10; i++)
            world4_star[i] = PlayerPrefs.GetInt("star4" + "-" + (i + 1));
        for (int i = 0; i < 10; i++)
            world5_star[i] = PlayerPrefs.GetInt("star5" + "-" + (i + 1));
        for (int i = 0; i < 10; i++)
            world6_star[i] = PlayerPrefs.GetInt("star6" + "-" + (i + 1));
        if (character_name == "")
        {
            character = (GameObject)Resources.Load("prefab/character/man/man_in_game");
            character_name = "man_in_game";
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
