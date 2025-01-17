using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToHub : MonoBehaviour
{
    public GameObject SpawnPointLevelToHub;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            GrabItems grabItems = collision.gameObject.GetComponent<GrabItems>(); 

            if (grabItems.NumberGears != 3)
            {
                grabItems.NumberGears = 0;
            }
            SceneManager.LoadScene("Hub");
            collision.gameObject.transform.position = SpawnPointLevelToHub.transform.position;
        }
    }
}
