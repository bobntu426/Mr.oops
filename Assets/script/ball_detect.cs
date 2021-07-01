using UnityEngine;

public class ball_detect : MonoBehaviour
{
    public int index1, index2;
    public static int a = 0, b = 0;
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
        print(a + "" + b);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        gamemanager.manager.has_ball[index1, index2] = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        gamemanager.manager.has_ball[index1, index2] = false;
    }
}
