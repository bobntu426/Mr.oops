using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone_control : MonoBehaviour
{
    public static float speed=5; 
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
