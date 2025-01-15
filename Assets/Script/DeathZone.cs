using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathZone : MonoBehaviour
{
    public string Level;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player"){
            Destroy(collision);
            SceneManager.LoadScene(Level);
        }
    }
}
