using UnityEngine;
using TMPro;

public class ShowQuestText : MonoBehaviour
{
    public GameObject firstChoice;
    public GameObject secondChoice;
    public TMP_Text text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlayerQuestState playerQuestState = myPlayer.GetComponent<PlayerQuestState>();
    
        gameObject.transform.GetChild(0).gameObject.SetActive(
            playerQuestState.questTextLaunched && !playerQuestState.questAccepted ||
            playerQuestState.secondQuestTextLaunched && (!playerQuestState.secondQuestDone && !playerQuestState.secondQuestDoneAndDecline)
        );
        if (playerQuestState.secondQuestTextLaunched && text)
        {
            text.text = "Avez-vous retrouver mon image ?\n\nLui rendre l'image\nLa garder pour la revendre";
        }
        if (gameObject.tag == "quest_text_container")
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(
                playerQuestState.questTextLaunched && !playerQuestState.questAccepted ||
                playerQuestState.secondQuestTextLaunched && (!playerQuestState.secondQuestDone && !playerQuestState.secondQuestDoneAndDecline)
            );
        }
        else
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(playerQuestState.questTextLaunched && !playerQuestState.questAccepted);  
        }
        ChangeSecretQuestVisibilty(playerQuestState.secondQuestTextLaunched);
    }

    void ChangeSecretQuestVisibilty(bool isVisible)
    {
        if (firstChoice && secondChoice) 
        {
            firstChoice.SetActive(isVisible);
            secondChoice.SetActive(isVisible);
        }  
    }
}
