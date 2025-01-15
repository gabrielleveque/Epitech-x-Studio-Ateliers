using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToHub : MonoBehaviour
{
    public GameObject SpawnPointLevelToHub;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"){
            // Destroy(collision);
            SceneManager.LoadScene("Hub");
            collision.gameObject.transform.position = SpawnPointLevelToHub.transform.position;
        }
    }
}
