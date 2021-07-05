using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone_control : MonoBehaviour
{
    public float speed=5;
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void Start()
    {
        if (transform.position.y == ground_control.ground.pointer_out_pos) { gameObject.GetComponent<Rigidbody2D>().velocity = -new Vector2(0, speed); }
        else if (transform.position.y == -ground_control.ground.pointer_out_pos) { gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed); }
        else if (transform.position.x == ground_control.ground.pointer_out_pos) { gameObject.GetComponent<Rigidbody2D>().velocity = -new Vector2(speed, 0); }
        else { GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0); }
    }
}
