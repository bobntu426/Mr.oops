using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone_control : MonoBehaviour
{
    public float speed=5;
    public GameObject sound;
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void Start()
    {


        sound = Instantiate((GameObject)Resources.Load("prefab/attack_ball/stong_roll"));
        if (transform.position.y == ground_control.ground.pointer_out_pos[0]) 
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            gameObject.GetComponent<Rigidbody2D>().velocity = -new Vector2(0, speed); }
        else if (transform.position.y == ground_control.ground.pointer_out_pos[2])
        { gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (transform.position.x == ground_control.ground.pointer_out_pos[3])
        { gameObject.GetComponent<Rigidbody2D>().velocity = -new Vector2(speed, 0);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else
        { GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        Invoke("add_tag", 1f);
        
    }
    void add_tag()
    {
        gameObject.tag = ("rolled");
    }
    private void Update()
    {
        if (gameObject.tag == "rolled")
        {
            if (transform.position.y > ground_control.ground.pointer_out_pos[0] ||
                transform.position.y < ground_control.ground.pointer_out_pos[1] ||
                transform.position.x < ground_control.ground.pointer_out_pos[2] ||
                transform.position.x > ground_control.ground.pointer_out_pos[3])
            {
                sound.SetActive(false);
                gameObject.SetActive(false);

            }
        }
    }
}
