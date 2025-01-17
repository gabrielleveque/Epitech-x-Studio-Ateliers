using UnityEngine;

public class ShowMissingImage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlayerQuestState playerQuestState = myPlayer.GetComponent<PlayerQuestState>();
    
        gameObject.SetActive(!playerQuestState.missingPictureFound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
