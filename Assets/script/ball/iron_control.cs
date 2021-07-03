using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iron_control : MonoBehaviour
{
    public static float speed = 12;
    void OnBecameInvisible()
    {
        Destroy(gameObject);

    }
}
