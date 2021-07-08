using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_control : MonoBehaviour
{
    public Vector2[,] road_postion;
    public static ground_control ground;
    public float[] pointer_out_pos;
    public float[] x, y;
    public GameObject[] eye;
    public GameObject sound;
    // Start is called before the first frame update
    void Awake()
    {
        if (ground == null)
        {
            ground = this;
        }
        x = new float[6];
        y = new float[6];
        x[0] =-2.57f;
        x[1] =-1.55f;
        x[2] =-0.46f;
        x[3] =0.7f;
        x[4] =1.81f;
        x[5] =2.87f;
        y[0] =-2.8f;
        y[1] =-1.7f;
        y[2] =-0.57f;
        y[3] =0.48f;
        y[4] =1.61f;
        y[5] =2.7f;

        road_postion = new Vector2[6,6];
        pointer_out_pos = new float[4];
        pointer_out_pos[0] = 3.44f;
        pointer_out_pos[1] =-3.43f;
        pointer_out_pos[2] =-3.597f;
        pointer_out_pos[3] =3.64f;

        for (int i = 0; i < 6; i++)
        {
            for (int k = 0; k < 6; k++)
            {
                road_postion[i, k] = new Vector2(x[i], y[k]);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
