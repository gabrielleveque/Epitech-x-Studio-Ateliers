using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerQuestState : MonoBehaviour
{
    public bool questAccepted;
    public bool questTextLaunched;
    public bool missingPictureFound;
    private bool IsAcceptable;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        questAccepted = false;
        questTextLaunched = false;
        missingPictureFound = false;
        IsAcceptable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Hub")
        {
            questTextLaunched = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && IsAcceptable && !questAccepted)
        {
            questTextLaunched = true;
        }  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Old_man")
        {
            IsAcceptable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Old_man")
        {
            IsAcceptable = false;
        }
    }

}
