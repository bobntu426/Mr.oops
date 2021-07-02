using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class high_score : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Text>().text = "計分模式最佳紀錄：" + playerprefs_info.player.high_score + "關";
    }

}
