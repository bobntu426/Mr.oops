using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scroll_control : MonoBehaviour
{
   
    public GameObject UI;
    public GameObject man;

    public void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            UI.GetComponent<ScrollRect>().horizontalNormalizedPosition = UI.GetComponent<ScrollRect>().horizontalNormalizedPosition + 0.01f;
            man.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            man.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            UI.GetComponent<ScrollRect>().horizontalNormalizedPosition = UI.GetComponent<ScrollRect>().horizontalNormalizedPosition - 0.01f;
        }
    }
}
