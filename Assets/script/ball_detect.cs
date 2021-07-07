using UnityEngine;

public class ball_detect : MonoBehaviour
{
    public int index1, index2;
    public static int a = 0, b = 0;
    public static bool[,] has_ball;
    public static bool start=false;
    private void Start()
    {
        index1 = b;
        index2 = a;
        a++;
        if (a == 6)
        {
            a = 0;
            b++;
        }
        if (b == 6)
        {
            a = 0;
            b = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(start)
            has_ball[index1, index2] = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        has_ball[index1, index2] = false;
    }
}
