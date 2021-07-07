using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_control : MonoBehaviour
{
    public Vector2[,] road_postion;
    public static ground_control ground;
    public float[] pointer_out_pos;
    public float[] x, y;
    // Start is called before the first frame update
    void Awake()
    {
        if (ground == null)
        {
            ground = this;
        }
        x = new float[6];
        y = new float[6];
        x[0] =-2.54f;
        x[1] =-1.53f;
        x[2] =-0.46f;
        x[3] =0.61f;
        x[4] =1.68f;
        x[5] =2.8f;
        y[0] =-2.66f;
        y[1] =-1.68f;
        y[2] =-0.6f;
        y[3] =0.46f;
        y[4] =1.54f;
        y[5] =2.55f;

        road_postion = new Vector2[6,6];
        pointer_out_pos = new float[4];
        pointer_out_pos[0] = 3.44f;
        pointer_out_pos[1] =-3.14f;
        pointer_out_pos[2] =-3.31f;
        pointer_out_pos[3] =3.54f;

        for (int i = 0; i < 6; i++)
        {
            for (int k = 0; k < 6; k++)
            {
                road_postion[i, k] = new Vector2(x[i], y[k]);
            }
        }
        road_postion[0, 0] = new Vector2(-2.5f, y[0]);
        road_postion[1, 0] = new Vector2(-1.48f, y[0]);
        road_postion[2, 0] = new Vector2(-0.38f, y[0]);
        road_postion[3, 0] = new Vector2(0.7f, y[0]);
        road_postion[4, 0] = new Vector2(1.8f, y[0]);
        road_postion[5, 0] = new Vector2(2.8f, y[0]);
        road_postion[0, 1] = new Vector2(-2.5f, y[1]);
        road_postion[0, 2] = new Vector2(-2.53f, y[2]);
        road_postion[0, 3] = new Vector2(-2.53f, y[3]);
        road_postion[3, 1] = new Vector2(0.72f, -1.63f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
