using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlaceItems : MonoBehaviour
{
    public int NumberGearsPlaced;
    public int NumberImages;
    public GrabItems grabItems;
    public bool canPlace;
    public bool rotating;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotating = false;
        NumberImages = 0;
        canPlace = true;
    }

    void Update()
    {
        if (NumberGearsPlaced >= 3 && !rotating)
        {
            rotating = true;
            StartCoroutine(ShowImages());
        }
    }

    IEnumerator ShowImages()
    {
        yield return new WaitForSeconds(2);
        NumberImages++;
        yield return new WaitForSeconds(4);
        NumberGearsPlaced = 0;
        NumberImages++;
        rotating = false;
    }

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
