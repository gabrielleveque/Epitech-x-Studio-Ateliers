using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons;

    public GameObject SpawPointLevel01;
    public GameObject SpawPointLevel02;
    public GameObject SpawPointLevel03;
    public GameObject SpawPointLevel04;
    public GameObject SpawPointHub;

    private void Start()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlaceItems placeItems = myPlayer.GetComponent<PlaceItems>();
        PlayerQuestState playerQuestState = myPlayer.GetComponent<PlayerQuestState>();
        int j = 0;

        for (int i = 0; i < 8; i += 2) {
            Debug.Log(j);
            if (i > placeItems.NumberImages || !playerQuestState.questAccepted) {
                levelButtons[j].interactable = false;
            }
            j++;
        }
    }

    public void LoadLevelPassed(string levelName)
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (levelName == "Level01")
        {
            player.transform.position = SpawPointLevel01.transform.position;
        }
        if (levelName == "Level02")
        {
            player.transform.position = SpawPointLevel02.transform.position;
        }
        if (levelName == "Level03")
        {
            player.transform.position = SpawPointLevel03.transform.position;
        }
        if (levelName == "Level04")
        {
            player.transform.position = SpawPointLevel04.transform.position;
        }
        if (levelName == "Hub")
        {
            player.transform.position = SpawPointHub.transform.position;
        }
        SceneManager.LoadScene(levelName);
    }
}
