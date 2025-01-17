using UnityEngine;

public class ShowNpc : MonoBehaviour
{
    public GameObject secretImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        secretImage.SetActive(false);
        SetImageVisibility(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlayerQuestState playerQuestState = myPlayer.GetComponent<PlayerQuestState>();

        if (playerQuestState.secondQuestDone)
        {
            secretImage.SetActive(true);
            SetImageVisibility(true);
        }
    }

    void SetImageVisibility(bool visibility)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);

            child.gameObject.SetActive(visibility);             
        }
    }
}
