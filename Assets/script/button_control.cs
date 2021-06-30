using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button_control : MonoBehaviour
{

    public void start_button()
    {
        print("1");
        SceneManager.LoadScene(1);
    }
    public void setting_button() { SceneManager.LoadScene(2); }
    public void return_button() { SceneManager.LoadScene(0); }
   
}
