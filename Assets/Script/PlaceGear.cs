using UnityEngine;

public class PlaceGear : MonoBehaviour
{
    public bool rotate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotate = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);
        gameObject.transform.GetChild(4).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlaceItems placeItems = myPlayer.GetComponent<PlaceItems>();

        gameObject.transform.GetChild(0).gameObject.SetActive(placeItems.NumberGearsPlaced >= 1);
        gameObject.transform.GetChild(2).gameObject.SetActive(placeItems.NumberGearsPlaced >= 2);
        gameObject.transform.GetChild(4).gameObject.SetActive(placeItems.NumberGearsPlaced >= 3);
        rotate = placeItems.NumberGearsPlaced >= 3;
    }
}
