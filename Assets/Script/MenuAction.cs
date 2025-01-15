using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAction : MonoBehaviour
{
    public GameObject player;
    public GameObject SpawnPoint;

    public void Play()
    {
        SceneManager.LoadScene("Hub");
        // player.transform.position = SpawnPoint.transform.position;
    }

    public void Quit()
    {
        Application.Quit();
    }

}
