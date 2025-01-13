using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrab : MonoBehaviour
{
    private bool IsPickeable;

    private void Start()
    {
        IsPickeable = false;
    }

    private void Update()
    {
        if (IsPickeable && Input.GetKeyDown(KeyCode.E))
        {
            PickItem();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            IsPickeable = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            IsPickeable = false;
    }

    private void PickItem ()
    {
        Destroy(gameObject);
    }
}