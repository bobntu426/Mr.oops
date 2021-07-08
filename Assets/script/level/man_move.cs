using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class man_move : MonoBehaviour
{
    public static man_move man;
    Rigidbody2D R;
    private Vector2 start_pos = new Vector2();
    Vector2 nowFingerPos = new Vector2();
    public bool startPosFlag = true;
    public bool round_touch = false;
    float xMoveDistance, yMoveDistance;
    public bool a = true;
    public int temp = 0;
    public Vector2[,] position;
    public Vector2 man_pos;
    public bool lose;
    public GameObject sound;
    public int round;

    void Awake()
    {
        if (man == null)
        {
            man = this;
        }
    }
    void Start()
    {
        //���\�h�IĲ�I
        Input.multiTouchEnabled = true;
    }


    void Update()
    {
        R = gameObject.GetComponent<Rigidbody2D>();
        MobileInput();
        if (Input.touchCount > 0)
            print(Input.GetTouch(0).phase);
        if (lose == true)
            Invoke("to_finish", 2f);
        //�P�_���x
#if !UNITY_EDITOR && (UNITY_IOS || UNITY_ANDROID)

        MobileInput ();

#else

        DesktopInput();

#endif

    }
    void DesktopInput()
    {

        if (gameObject.GetComponent<Rigidbody2D>().velocity == new Vector2(0, 0))
        {
            
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                if (man_pos.y < 5&& ball_detect.has_ball[(int)man_pos.x, (int)man_pos.y + 1] == false)
                {
                        Instantiate(Resources.Load("prefab/character/man/move_sound"));
                        man_pos += new Vector2(0, 1f);
                        transform.position = position[(int)man_pos.x, (int)man_pos.y];
                    
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                gameObject.transform.rotation=Quaternion.Euler(0,0,180);
                if (ball_detect.has_ball[(int)man_pos.x, (int)man_pos.y - 1] == false && man_pos.y > 0)
                {
                    Instantiate(Resources.Load("prefab/character/man/move_sound"));
                    man_pos += new Vector2(0, -1f);
                    transform.position = position[(int)man_pos.x, (int)man_pos.y];

                }
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow) )
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                if (ball_detect.has_ball[(int)man_pos.x - 1, (int)man_pos.y] == false && man_pos.x > 0)
                {
                    Instantiate(Resources.Load("prefab/character/man/move_sound"));
                    man_pos += new Vector2(-1f, 0);
                    transform.position = position[(int)man_pos.x, (int)man_pos.y];

                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) )
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 270);
                if (ball_detect.has_ball[(int)man_pos.x + 1, (int)man_pos.y] == false && man_pos.x < 5)
                {
                    Instantiate(Resources.Load("prefab/character/man/move_sound"));
                    man_pos += new Vector2(1f, 0);
                    transform.position = position[(int)man_pos.x, (int)man_pos.y];

                }
            }
        }

    }
    void MobileInput()
    {
        if (Input.touchCount > 0)
        {
            if (gameObject.GetComponent<Rigidbody2D>().velocity == new Vector2(0, 0))
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began && startPosFlag == true)
                {
                    start_pos = Input.GetTouch(0).position;
                    startPosFlag = false;
                }
                if (Input.GetTouch(0).phase == TouchPhase.Moved && a == true)
                {
                    round_touch = true;
                    round_touch = true;
                    a = false;
                }
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    startPosFlag = true;
                    a = true;
                }
                nowFingerPos = Input.GetTouch(0).position;

                if (judgeFinger() == 1 )
                {
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    if (ball_detect.has_ball[(int)man_pos.x, (int)man_pos.y + 1] == false && man_pos.y < 5 && (round_touch == true || (temp - 2 > 0 && a == false)))
                    {
                        Instantiate(Resources.Load("prefab/character/man/move_sound"));
                        man_pos += new Vector2(0, 1f);
                        transform.position = position[(int)man_pos.x, (int)man_pos.y];
                        round_touch = false;
                        temp = 1;
                    }
                }
                else if (judgeFinger() == 2  )
                {
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
                    if (ball_detect.has_ball[(int)man_pos.x, (int)man_pos.y - 1] == false && man_pos.y > 0 && (round_touch == true || (temp - 2 > 0 && a == false)))
                    {
                        Instantiate(Resources.Load("prefab/character/man/move_sound"));
                        man_pos += new Vector2(0, -1f);
                        transform.position = position[(int)man_pos.x, (int)man_pos.y];
                        round_touch = false;
                        temp = 2;
                    }

                }
                else if (judgeFinger() == 4 )
                {
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                    if (ball_detect.has_ball[(int)man_pos.x - 1, (int)man_pos.y] == false && man_pos.x > 0 && (round_touch == true || (temp + 2 < 5 && a == false)))
                    {
                        Instantiate(Resources.Load("prefab/character/man/move_sound"));
                        man_pos += new Vector2(-1f, 0);
                        transform.position = position[(int)man_pos.x, (int)man_pos.y];
                        round_touch = false;
                        temp = 4;
                    }

                }
                else if (judgeFinger() == 3  )
                {
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 270);
                    if (ball_detect.has_ball[(int)man_pos.x + 1, (int)man_pos.y] == false && man_pos.x < 5 && (round_touch == true || (temp + 2 < 5 && a == false)))
                    {
                        Instantiate(Resources.Load("prefab/character/man/move_sound"));
                        man_pos += new Vector2(1f, 0);
                        transform.position = position[(int)man_pos.x, (int)man_pos.y];
                        round_touch = false;
                        temp = 3;
                    }
                }

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        print("a");
        lose = true;
    }
    /**

     * �P�_�O�_�����IĲ��

     **/

    public static bool singleTouch()
    {
        if (Input.touchCount == 1)
            return true;
        return false;
    }

    /**

     * �P�_���IĲ������U  �O�_������Ĳ��

     **/

    public static bool moveSingleTouch()

    {
        if (Input.GetTouch(0).phase == TouchPhase.Moved)
            return true;
        return false;
    }


    //�P�_�O�_���h�IĲ�� 

    public static bool multipointTouch()
    {
        if (Input.touchCount > 1)
            return true;
        return false;
    }

    //�P�_�Ⱖ����ܤ֦��@��������Ĳ��
    public static bool moveMultiTouch()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)
            return true;
        return false;
    }


    int judgeFinger()
    {
        int backValue;

        xMoveDistance = Mathf.Abs(nowFingerPos.x - start_pos.x);
        yMoveDistance = Mathf.Abs(nowFingerPos.y - start_pos.y);
        if (xMoveDistance > yMoveDistance)
        {
            if (nowFingerPos.x - start_pos.x > 0)
            {
                backValue = 3;         //�u��X�b�t��V����
            }
            else

            {
                backValue = 4;          //�u��X�b����V����
            }
        }
        else
        {
            if (nowFingerPos.y - start_pos.y > 0)
            {
                backValue = 1;         //�u��Y�b����V����
            }
            else
            {
                backValue = 2;         //�u��Y�b�t��V����
            }
        }
        return backValue;
    }
    void to_finish()
    {
        if (round > playerprefs_info.player.world1_score[0])
        {
            PlayerPrefs.SetInt("level-1" + level_manager.manager.choose_level + "_score", round);
            playerprefs_info.player.world1_score[0] = PlayerPrefs.GetInt("level" + level_manager.manager.choose_level + "_score");

        }
        level_finish.round = round;
        SceneManager.LoadScene("level_finish_scene");
    }
}
