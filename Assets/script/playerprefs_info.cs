using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs_info : MonoBehaviour
{
    public static playerprefs_info player;
    
    //piayerprefs��key

    //�i��
    public int high_level;
    public int high_score;

    //��o���D�� ���G1 �L�G0
    public int mushroom;
    public int ice;
    public int sun;
    public int dust;
    public int virus;

    //��o������ ���G1 �L�G0


    //�ثe��Ϊ�����
    public string character_name;
    Object character_pre;
    public GameObject character;

    //�ثe��Ϊ�����
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
