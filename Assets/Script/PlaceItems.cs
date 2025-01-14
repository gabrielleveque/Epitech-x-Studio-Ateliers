using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaceItems : MonoBehaviour
{
    public int NumberGearsPlaced;
    public GrabItems grabItems;
    public bool canPlace;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canPlace = true;
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (SceneManager.GetActiveScene().name == "Hub" &&
    //         Input.GetKeyDown(KeyCode.E) && grabItems.NumberGears >= 1)
    //     {
    //         grabItems.NumberGears--;
    //         NumberGearsPlaced++;
    //     }
    // }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GearFrameInside" && canPlace == true && grabItems.NumberGears >= 1)
        {
            canPlace = false;
            grabItems.NumberGears--;
            NumberGearsPlaced++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "GearFrameInside")
        {
            canPlace = true;
        }
    }

}
