using UnityEngine;

public class ChangeSecretQuestText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlayerQuestState playerQuestState = myPlayer.GetComponent<PlayerQuestState>();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerQuestState.secondQuestDone = true;
            playerQuestState.secondQuestTextLaunched = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerQuestState.secondQuestDoneAndDecline = true;
            playerQuestState.secondQuestTextLaunched = false;
        }
    }
}
