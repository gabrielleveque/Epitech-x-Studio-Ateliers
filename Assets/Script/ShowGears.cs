using UnityEngine;

public class ShowGears : MonoBehaviour
{
    public int displayCondition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlaceItems placeItems = myPlayer.GetComponent<PlaceItems>();
        
        bool isActive = placeItems.NumberImages < displayCondition;

        gameObject.transform.GetChild(0).gameObject.SetActive(isActive);
        gameObject.transform.GetChild(1).gameObject.SetActive(isActive);
        gameObject.transform.GetChild(2).gameObject.SetActive(isActive);
    }
}
