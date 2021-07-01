using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_control : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
