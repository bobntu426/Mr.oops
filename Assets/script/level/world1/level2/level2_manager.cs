using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2_manager : MonoBehaviour
{
    public static level2_manager manager1_2;
    public GameObject[] game_pointer;
    public GameObject ball, pointer, man, detect, sound, roll_sound,equipment;
    public int control, pointer_num, temp_round, random3;
    public float ball_speed;
    public float spawn_ball_speed, round_preriod;
    public Vector2[,] position;


    void Awake()
    {
        if (manager1_2 == null)
        {
            manager1_2 = this;
        }
    }
    void Start()
    {
        Instantiate(man);
        ball_detect.start = false;
        equipment =playerprefs_info.player.character;
        ball_detect.has_ball = new bool[6, 6];
        man_control.man.lose = false;
        man_control.man.round = 0;
        man_control.man.mode = "level";
        sound.GetComponent<AudioSource>().loop = true;
        Instantiate(sound);
        ball_speed = 6;
        spawn_ball_speed = 1.5f;
        round_preriod = 2;
        game_pointer = new GameObject[24];
        position = new Vector2[6, 6];
        man_control.man.position = new Vector2[6, 6];
        for (int i = 0; i < 6; i++)
        {
            for (int k = 0; k < 6; k++)
            {
                GameObject temp_detect;
                position[i, k] = ground_control.ground.road_postion[i, k];
                man_control.man.position[i, k] = ground_control.ground.road_postion[i, k];
                temp_detect = Instantiate(detect, position[i, k], Quaternion.identity);
                temp_detect.transform.localScale = detect.transform.localScale * 0.878f;
                ball_detect.has_ball[i, k] = false;

            }
        }
        man_control.man.man_pos = new Vector2(2f, 2f);
        man.transform.position = position[(int)man_control.man.man_pos.x, (int)man_control.man.man_pos.y];
        InvokeRepeating("a_round", 0.5f, round_preriod);
    }
    void Update()
    {

    }

    void a_round()
    {

        ball_detect.start = true;
        int[] temp1 = new int[10];
        int[] temp2 = new int[10];
        random3 = Random.Range(1, 9);//´XÁû²y
        if (man_control.man.round == 0)
            random3 = 1;
        if (man_control.man.round == 1 && pointer_num == 2)
            random3 = 2;
        bool check = true;
        pointer_num = 0;
        for (int i = 0; i < random3; i++)
        {

            int random1 = Random.Range(0, 4);
            int random2 = Random.Range(0, 6);

            for (int k = 0; k < i; k++)
            {
                if (((temp1[k] == random1) || (temp1[k] - random1 == 2) || (temp1[k] - random1 == -2)) && temp2[k] == random2)
                {
                    check = false;
                    break;
                }
            }
            if (check == false)
            {
                check = true;
                i--;
                continue;
            }


            else if (random1 == 0)
            {
                game_pointer[i] = Instantiate(pointer, new Vector2(ground_control.ground.x[random2], ground_control.ground.pointer_out_pos[0]), Quaternion.identity);
            }
            else if (random1 == 1)
            {
                game_pointer[i] = Instantiate(pointer, new Vector2(ground_control.ground.pointer_out_pos[1], ground_control.ground.y[random2]), Quaternion.Euler(0, 0, 90));
            }
            else if (random1 == 2)
            {
                game_pointer[i] = Instantiate(pointer, new Vector2(ground_control.ground.x[random2], ground_control.ground.pointer_out_pos[2]), Quaternion.Euler(0, 0, 180));
            }
            else
            {
                game_pointer[i] = Instantiate(pointer, new Vector2(ground_control.ground.pointer_out_pos[3], ground_control.ground.y[random2]), Quaternion.Euler(0, 0, 270));
            }

            //Instantiate(ground_control.ground.sound);
            game_pointer[i].AddComponent<anime_control>();
            temp1[i] = random1;
            temp2[i] = random2;
            pointer_num++;


        };
        Invoke("ball_roll", spawn_ball_speed);
        Invoke("set_roll", spawn_ball_speed - (0.37f / anime_control.anime.magnification));
        for (int k = 0; k < 4; k++)
            ground_control.ground.eye[k].SetActive(true);


    }
    void ball_roll()
    {

        if (man_control.man.lose == false)
            man_control.man.round++;
        if (man_control.man.round == level_manager.manager.goal[1].w)
        {
            man_control.man.round--;
            CancelInvoke("a_round");
            Invoke("pass", 3f);
        }

        if (man_control.man.round - temp_round == 20)
        {
            change_freq();
        }
        for (int i = 0; i < pointer_num; i++)
        {
            GameObject[] game_ball = new GameObject[24];
            game_ball[i] = Instantiate(ball, game_pointer[i].transform.position, Quaternion.identity);
            DestroyImmediate(game_pointer[i]);
        }
        for (int k = 0; k < 4; k++)
            ground_control.ground.eye[k].SetActive(false);
        roll_sound = Instantiate((GameObject)Resources.Load("prefab/attack_ball/stong_roll"));



    }
    public void change_freq()
    {
        temp_round = man_control.man.round;
        CancelInvoke("a_round");

        round_preriod = round_preriod * (1 / 1.2f);
        spawn_ball_speed = spawn_ball_speed * (1 / 1.2f);
        anime_control.anime.magnification *= 1.2f;
        InvokeRepeating("a_round", 3f, round_preriod);
    }
    void pass()
    {
        man_control.man.round++;
        if (man_control.man.round > playerprefs_info.player.world1_score[1])
        {
            PlayerPrefs.SetInt("score1-2", man_control.man.round);
            playerprefs_info.player.world1_score[1] = PlayerPrefs.GetInt("score1-2");
        }
        level_finish.round = man_control.man.round;
        SceneManager.LoadScene("level_finish_scene");
    }
    void set_roll()
    {
        for (int i = 0; i < random3; i++)
        {
            game_pointer[i].GetComponent<Animator>().SetBool("roll", true);

        }

    }

}
