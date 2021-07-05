using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_control : MonoBehaviour
{
    public float[] road_postion;
    public static ground_control ground;
    public float pointer_out_pos;
    // Start is called before the first frame update
    void Awake()
    {
        if (ground == null)
        {
            ground = this;
        }
        pointer_out_pos = 4.25f;
        road_postion = new float[6];
        road_postion[0] = -2.92f;
        road_postion[1] = -1.77f;
        road_postion[2] = -0.59f;
        road_postion[3] = 0.59f;
        road_postion[4] = 1.77f;
        road_postion[5] = 2.92f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
