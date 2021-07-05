using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class status : MonoBehaviour
{
    public GameObject star_num,crown_num;
    void Start()
    {
        star_num.GetComponent<Text>().text = ": "+playerprefs_info.player.star.ToString();
        crown_num.GetComponent<Text>().text = ": "+playerprefs_info.player.crown.ToString();
    }
}
