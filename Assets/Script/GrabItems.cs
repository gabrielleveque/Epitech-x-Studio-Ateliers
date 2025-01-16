using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItems : MonoBehaviour
{
    public PlayerQuestState playerQuestState;
    public GameObject Roue_Mulhouse1, Roue_Mulhouse2, Roue_Mulhouse3;
    private bool IsPickeable;
    private bool IsMapPickeable;
    public int NumberGears;
    public GameObject Roue;

    private void Start()
    {
        IsPickeable = false;
        IsMapPickeable = false;
        NumberGears = 0;
        // Roue_Mulhouse1.gameObject.SetActive(false);
        // Roue_Mulhouse2.gameObject.SetActive(false);
        // Roue_Mulhouse3.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (IsPickeable && Input.GetKeyDown(KeyCode.E))
        {
            PickItem();
        }
        
        if (IsMapPickeable && Input.GetKeyDown(KeyCode.E))
        {
            PickSecretMap();
        }

        if (NumberGears > 3)
            NumberGears = 3;
        // if (NumberGears == 3)
        // {
        //     Roue_Mulhouse1.gameObject.SetActive(true);
        //     Roue_Mulhouse2.gameObject.SetActive(true);
        //     Roue_Mulhouse3.gameObject.SetActive(true);
        //     return;
        // }
        // if (NumberGears == 2)
        // {
        //     Roue_Mulhouse1.gameObject.SetActive(true);
        //     Roue_Mulhouse2.gameObject.SetActive(true);
        //     Roue_Mulhouse3.gameObject.SetActive(false);
        //     return;
        // }
        // if (NumberGears == 1)
        // {
        //     Roue_Mulhouse1.gameObject.SetActive(true);
        //     Roue_Mulhouse2.gameObject.SetActive(false);
        //     Roue_Mulhouse3.gameObject.SetActive(false);
        //     return;
        // }
        // if (NumberGears == 0)
        // {
        //     Roue_Mulhouse1.gameObject.SetActive(false);
        //     Roue_Mulhouse2.gameObject.SetActive(false);
        //     Roue_Mulhouse3.gameObject.SetActive(false);
        //     return;
        // }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Roue_Item")
        {
            IsPickeable = true;
            Roue = collision.gameObject;    
        }
        if (collision.tag == "Secret_pic")
        {
            IsMapPickeable = true;
            Roue = collision.gameObject;    
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Roue_Item")
        {
            IsPickeable = false;
            Roue = null;
        }
        if (collision.tag == "Secret_pic")
        {
            IsMapPickeable = false;
            Roue = null;    
        }
    }

    private void PickItem ()
    {
        Destroy(Roue);
        NumberGears += 1;
    }

    private void PickSecretMap ()
    {
        playerQuestState.missingPictureFound = true;
        Destroy(Roue);
    }
}