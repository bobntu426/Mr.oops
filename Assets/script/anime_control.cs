using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime_control : MonoBehaviour
{
    public static anime_control anime;
    public float speed,magnification;
    public bool roll;
    public Animator a;
    private void Awake()
    {
        if (anime == null)
            anime = this;
        magnification = 1;
    }
    private void Update()
    {
        gameObject.GetComponent<Animator>().speed = magnification;
    }

}
