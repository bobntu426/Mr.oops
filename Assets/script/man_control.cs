using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class man_control : MonoBehaviour
{

    Rigidbody2D R;
    private Vector2 start_pos = new Vector2();
    Vector2 nowFingerPos = new Vector2();
    public bool startPosFlag = true;
    public bool round_touch = false;
    float xMoveDistance, yMoveDistance;
    public bool a = true;
    public int temp = 0;
    void Start()
    {
        //允許多點觸碰
        Input.multiTouchEnabled = true;
    }


    void Update()
    {
        R = gameObject.GetComponent<Rigidbody2D>();
        MobileInput();
        if (Input.touchCount > 0)
            print(Input.GetTouch(0).phase);
        if (gamemanager.manager.lose == true)
            Invoke("to_finish", 2f);
        //判斷平台
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
            if (Input.GetKeyDown(KeyCode.UpArrow) && gamemanager.manager.man_pos.y < 5)
            {
                if (gamemanager.manager.has_ball[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y + 1] == false)
                {
                    Instantiate(gamemanager.manager.sound);
                    gamemanager.manager.man_pos += new Vector2(0, 1f);
                    transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
                    
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && gamemanager.manager.man_pos.y > 0)
            {
                if (gamemanager.manager.has_ball[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y - 1] == false)
                {
                    Instantiate(gamemanager.manager.sound);
                    gamemanager.manager.man_pos += new Vector2(0, -1f);
                    transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
                    
                }
            }
            
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && gamemanager.manager.man_pos.x > 0 )
            {
                if (gamemanager.manager.has_ball[(int)gamemanager.manager.man_pos.x-1, (int)gamemanager.manager.man_pos.y] == false)
                {
                    Instantiate(gamemanager.manager.sound);
                    gamemanager.manager.man_pos += new Vector2(-1f, 0);
                    transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
                    
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && gamemanager.manager.man_pos.x < 5)
            {
                if (gamemanager.manager.has_ball[(int)gamemanager.manager.man_pos.x+1, (int)gamemanager.manager.man_pos.y] == false)
                {
                    Instantiate(gamemanager.manager.sound);
                    gamemanager.manager.man_pos += new Vector2(1f, 0);
                    transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
                    
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

                if (judgeFinger() == 1 && gamemanager.manager.man_pos.y < 5 && (round_touch == true||( temp -2>0&&a==false)))
                {
                    if (gamemanager.manager.has_ball[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y + 1] == false)
                    {
                        Instantiate(gamemanager.manager.sound);
                        gamemanager.manager.man_pos += new Vector2(0, 1f);
                        transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
                        round_touch = false;
                        temp = 1;
                    }
                }
                else if (judgeFinger() == 2 && gamemanager.manager.man_pos.y > 0 && (round_touch == true || (temp - 2 > 0 && a == false)))
                {
                    if (gamemanager.manager.has_ball[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y - 1] == false)
                    {
                        Instantiate(gamemanager.manager.sound);
                        gamemanager.manager.man_pos += new Vector2(0, -1f);
                        transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
                        round_touch = false;
                        temp = 2;
                    }

                }
                else if (judgeFinger() == 4 && gamemanager.manager.man_pos.x > 0 && (round_touch == true || (temp + 2 < 5 && a == false)))
                {
                    if (gamemanager.manager.has_ball[(int)gamemanager.manager.man_pos.x - 1, (int)gamemanager.manager.man_pos.y] == false)
                    {
                        Instantiate(gamemanager.manager.sound);
                        gamemanager.manager.man_pos += new Vector2(-1f, 0);
                        transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
                        round_touch = false;
                        temp = 4;
                    }

                }
                else if (judgeFinger() == 3 && gamemanager.manager.man_pos.x < 5 && (round_touch == true || (temp + 2 < 5 && a == false)))
                {
                    if (gamemanager.manager.has_ball[(int)gamemanager.manager.man_pos.x + 1, (int)gamemanager.manager.man_pos.y] == false)
                    {
                        Instantiate(gamemanager.manager.sound);
                        gamemanager.manager.man_pos += new Vector2(1f, 0);
                        transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
                        round_touch = false;
                        temp = 3;
                    }
                }

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        gamemanager.manager.lose = true;
    }
    /**

     * 判斷是否為單點觸控

     **/

    public static bool singleTouch()
    {
        if (Input.touchCount == 1)
            return true;
        return false;
    }

    /**

     * 判斷單點觸控條件下  是否為移動觸控

     **/

    public static bool moveSingleTouch()

    {
        if (Input.GetTouch(0).phase == TouchPhase.Moved)
            return true;
        return false;
    }


    //判斷是否為多點觸控 

    public static bool multipointTouch()
    {
        if (Input.touchCount > 1)
            return true;
        return false;
    }

    //判斷兩隻手指至少有一隻為移動觸控
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
                backValue = 3;         //沿著X軸負方向移動
            }
            else

            {
                backValue = 4;          //沿著X軸正方向移動
            }
        }
        else
        {
            if (nowFingerPos.y - start_pos.y > 0)
            {
                backValue = 1;         //沿著Y軸正方向移動
            }
            else
            {
                backValue = 2;         //沿著Y軸負方向移動
            }
        }
        return backValue;
    }
    void to_finish()
    {
        SceneManager.LoadScene(2);
    }
}
