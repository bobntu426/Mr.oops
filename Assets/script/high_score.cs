using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class high_score : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Text>().text = "�p���Ҧ��̨ά����G" + playerprefs_info.player.high_score + "��";
    }

}
