using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerQuestState : MonoBehaviour
{
    public bool questAccepted;
    public bool questTextLaunched;
    public bool missingPictureFound;
    public bool secondQuestTextLaunched;
    public bool secondQuestDone;
    public bool secondQuestDoneAndDecline;
    private bool IsAcceptable;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        questAccepted = false;
        questTextLaunched = false;
        missingPictureFound = false;
        secondQuestTextLaunched = false;
        secondQuestDone = false;
        secondQuestDoneAndDecline = false;
        IsAcceptable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "Hub")
        {
            questTextLaunched = false;
            secondQuestTextLaunched = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && IsAcceptable && !questAccepted)
        {
            questTextLaunched = true;
        }
        
        if (Input.GetKeyDown(KeyCode.E) && IsAcceptable && missingPictureFound)
        {
            secondQuestTextLaunched = true;
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
