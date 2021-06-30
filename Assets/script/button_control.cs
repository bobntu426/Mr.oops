using UnityEngine;
using UnityEngine.SceneManagement;

public class button_control : MonoBehaviour
{

    public void start_button()
    {
        print("1");
        SceneManager.LoadScene(1);
    }
    public void setting_button() { SceneManager.LoadScene(2); }
    public void return_button() { SceneManager.LoadScene(0); }
    public void restart_button() { SceneManager.LoadScene(1); }

}
