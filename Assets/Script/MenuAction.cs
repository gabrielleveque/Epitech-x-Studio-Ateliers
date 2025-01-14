using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAction : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Hub");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
