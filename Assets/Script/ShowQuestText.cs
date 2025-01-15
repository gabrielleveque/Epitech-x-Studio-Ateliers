using UnityEngine;

public class ShowQuestText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlayerQuestState playerQuestState = myPlayer.GetComponent<PlayerQuestState>();
    
        gameObject.transform.GetChild(0).gameObject.SetActive(playerQuestState.questTextLaunched && !playerQuestState.questAccepted);
        gameObject.transform.GetChild(1).gameObject.SetActive(playerQuestState.questTextLaunched && !playerQuestState.questAccepted);
    }
}
