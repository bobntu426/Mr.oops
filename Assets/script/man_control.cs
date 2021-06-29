using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man_control : MonoBehaviour
{

    Rigidbody2D R;
    void Start()
    {
        //允許多點觸碰
        Input.multiTouchEnabled = true;
        gameObject.GetComponent<Rigidbody2D>().angularVelocity = 1000;
    }


    void Update()
    {
        R = gameObject.GetComponent<Rigidbody2D>();
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
                gamemanager.manager.man_pos += new Vector2(0, 1f);
                transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && gamemanager.manager.man_pos.y > 0)
            {
                gamemanager.manager.man_pos += new Vector2(0, -1f);
                transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) && gamemanager.manager.man_pos.x > 0)
            {
                gamemanager.manager.man_pos += new Vector2(-1f, 0);
                transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) && gamemanager.manager.man_pos.x < 5)
            {
                gamemanager.manager.man_pos += new Vector2(1f, 0);
                transform.position = gamemanager.manager.position[(int)gamemanager.manager.man_pos.x, (int)gamemanager.manager.man_pos.y];
            }
        }

    }
    void MobileInput() {; }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //gameObject.SetActive(false);

    }
}
