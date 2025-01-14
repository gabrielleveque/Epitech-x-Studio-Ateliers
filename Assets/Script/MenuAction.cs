using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAction : MonoBehaviour
{
    public GameObject prefab;

    public void Play()
    {
        SceneManager.LoadScene("Hub");
        Instantiate(prefab, new Vector2(0.0f, 0.0f), Quaternion.identity);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
    