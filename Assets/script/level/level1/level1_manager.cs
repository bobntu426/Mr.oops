using UnityEngine;
public class level1_manager : MonoBehaviour
{
    public static level1_manager manager;
    public GameObject[] game_pointer;
    public GameObject ball, pointer, man, detect, sound;
    public int control, pointer_num, round, temp_round;
    public float[] road_postion;
    public float pointer_out_pos, ball_speed;
    public float ball_out_pos;
    public float spawn_ball_speed, round_preriod;
    public Vector2[,] position;
    public Vector2 man_pos;
    public bool lose;
    public bool[,] has_ball;
    void Awake()
    {
        if (manager == null)
        {
            manager = this;
        }
    }
    void Start()
    {
        man = Instantiate(playerprefs_info.player.character);
        man.AddComponent<level1_man>();
        position = new Vector2[6, 6];
        has_ball = new bool[6, 6];
        road_postion = new float[6];
        road_postion[0] = -2.92f;
        road_postion[1] = -1.77f;
        road_postion[2] = -0.59f;
        road_postion[3] = 0.59f;
        road_postion[4] = 1.77f;
        road_postion[5] = 2.92f;
        pointer_out_pos = 4.25f;
        ball_speed = 8;
        ball_out_pos = 3.72f;
        spawn_ball_speed = 2;
        round_preriod = 2.5f;
        game_pointer = new GameObject[24];
        for (int i = 0; i < 6; i++)
        {
            for (int k = 0; k < 6; k++)
            {
                position[i, k] = new Vector2(road_postion[i], road_postion[k]);
                Instantiate(detect, position[i, k], Quaternion.identity);
                has_ball[i, k] = false;
            }
        }
        man_pos = new Vector2(2f, 2f);
        man.transform.position = position[(int)man_pos.x, (int)man_pos.y];
        InvokeRepeating("a_round", 0.5f, round_preriod);
    }
    void Update()
    {

    }

    void a_round()
    {

        int[] temp1 = new int[10];
        int[] temp2 = new int[10];
        int random3 = Random.Range(1, 8);//´XÁû²y
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
                game_pointer[i] = Instantiate(pointer, new Vector2(road_postion[random2], pointer_out_pos), Quaternion.identity);
            }
            else if (random1 == 1)
            {
                game_pointer[i] = Instantiate(pointer, new Vector2(-pointer_out_pos, road_postion[random2]), Quaternion.Euler(0, 0, 90));
            }
            else if (random1 == 2)
            {
                game_pointer[i] = Instantiate(pointer, new Vector2(road_postion[random2], -pointer_out_pos), Quaternion.Euler(0, 0, 180));
            }
            else
            {
                game_pointer[i] = Instantiate(pointer, new Vector2(pointer_out_pos, road_postion[random2]), Quaternion.Euler(0, 0, 270));
            }
            temp1[i] = random1;
            temp2[i] = random2;
            pointer_num++;
        };
        Invoke("ball_roll", spawn_ball_speed);
    }
    void ball_roll()
    {
        if (lose == false)
            round++;
        if (round - temp_round == 20)
        {
            change_freq();
        }
        for (int i = 0; i < pointer_num; i++)
        {
            GameObject[] game_ball = new GameObject[24];
            game_ball[i] = Instantiate(ball, game_pointer[i].transform.position, Quaternion.identity);
            if (game_ball[i].transform.position.y == pointer_out_pos) { game_ball[i].GetComponent<Rigidbody2D>().velocity = new Vector2(0, -ball_speed); }
            else if (game_ball[i].transform.position.y == -pointer_out_pos) { game_ball[i].GetComponent<Rigidbody2D>().velocity = new Vector2(0, ball_speed); }
            else if (game_ball[i].transform.position.x == pointer_out_pos) { game_ball[i].GetComponent<Rigidbody2D>().velocity = new Vector2(-ball_speed, 0); }
            else { game_ball[i].GetComponent<Rigidbody2D>().velocity = new Vector2(ball_speed, 0); }
            DestroyImmediate(game_pointer[i]);
        }

    }
    public void change_freq()
    {
        temp_round = round;
        CancelInvoke("a_round");
        if (round_preriod > 0.6)
        {
            round_preriod -= 0.12f;
        }
        if (spawn_ball_speed > 0.2)
            spawn_ball_speed -= 0.1f;
        InvokeRepeating("a_round", 3f, round_preriod);
    }

}