using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2_info : MonoBehaviour
{
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("score1-2") == (int)level_manager.manager.goal[1].w)
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(false);
            gameObject.transform.GetChild(7).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
            gameObject.transform.GetChild(5).gameObject.SetActive(false);
            gameObject.transform.GetChild(6).gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("score1-2") >= (int)level_manager.manager.goal[1].z)
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(true);
            gameObject.transform.GetChild(7).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(3).gameObject.SetActive(true);
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
            gameObject.transform.GetChild(5).gameObject.SetActive(false);
            gameObject.transform.GetChild(6).gameObject.SetActive(false);

        }
        else if (PlayerPrefs.GetInt("score1-2") >= (int)level_manager.manager.goal[1].y)
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(true);
            gameObject.transform.GetChild(7).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameObject.transform.GetChild(3).gameObject.SetActive(false);
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
            gameObject.transform.GetChild(5).gameObject.SetActive(false);
            gameObject.transform.GetChild(6).gameObject.SetActive(true);

        }
        else if (PlayerPrefs.GetInt("score1-2") >= (int)level_manager.manager.goal[1].x)
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(true);
            gameObject.transform.GetChild(7).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            gameObject.transform.GetChild(2).gameObject.SetActive(false);
            gameObject.transform.GetChild(3).gameObject.SetActive(false);
            gameObject.transform.GetChild(4).gameObject.SetActive(false);
            gameObject.transform.GetChild(5).gameObject.SetActive(true);
            gameObject.transform.GetChild(6).gameObject.SetActive(true);


        }
        else
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(true);
            gameObject.transform.GetChild(7).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
            gameObject.transform.GetChild(2).gameObject.SetActive(false);
            gameObject.transform.GetChild(3).gameObject.SetActive(false);
            gameObject.transform.GetChild(4).gameObject.SetActive(true);
            gameObject.transform.GetChild(5).gameObject.SetActive(true);
            gameObject.transform.GetChild(6).gameObject.SetActive(true);

        }

    }
}
