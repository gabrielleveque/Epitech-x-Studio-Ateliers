using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathZone : MonoBehaviour
{
    public string Level;
    public GameObject levelSpawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            if (levelSpawnPoint)
            {
                collision.gameObject.transform.position = levelSpawnPoint.transform.position;
            }
            SceneManager.LoadScene(Level);
        }
    }
}
