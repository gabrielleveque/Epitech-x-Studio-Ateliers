using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowImages : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(3).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlaceItems placeItems = myPlayer.GetComponent<PlaceItems>();

        if (SceneManager.GetActiveScene().name == "Hub")
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(placeItems.NumberImages == 1);
            gameObject.transform.GetChild(1).gameObject.SetActive(placeItems.NumberImages == 3);
            gameObject.transform.GetChild(2).gameObject.SetActive(placeItems.NumberImages == 5);
            gameObject.transform.GetChild(3).gameObject.SetActive(placeItems.NumberImages == 7);
        }
        else
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(placeItems.NumberImages >= 2);
            gameObject.transform.GetChild(1).gameObject.SetActive(placeItems.NumberImages >= 4);
            gameObject.transform.GetChild(2).gameObject.SetActive(placeItems.NumberImages >= 6); 
            gameObject.transform.GetChild(3).gameObject.SetActive(placeItems.NumberImages >= 8); 
        }
    }
}
