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
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++){
            if (i + 1 > levelReached){
                levelButtons[i].interactable = false;
            }
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
