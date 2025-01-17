using UnityEngine;
using TMPro;

public class PlayerTuto : MonoBehaviour
{
    public TMP_Text text;
    private bool tutoCompleted = false;

    public bool Qkey = false;
    public bool Dkey = false;

    public bool Spacekey = false;
    
    public bool Ekey = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject tutoBlocker = GameObject.FindWithTag("tuto_blocker");

        CheckMovement();
        if (Qkey && Dkey)
        {
            text.text = "Appuyer sur <b>[Espace]</b> pour sauter";
            CheckJump();
        }
        if (Spacekey)
        {
            text.text = "Vous pouvez appuyer sur <b>[E]</b> pour intéragir";
            CheckInteraction();
        }
        if (Ekey)
        {
            text.text = "Vous êtes prêt !\nBonne chance !";
            if (!tutoCompleted)
            {
                tutoBlocker.SetActive(false);
                tutoCompleted = true;
            }
        }
    }

    void CheckMovement()
    {    
        if (Input.GetKeyDown(KeyCode.A))
        {
            Qkey = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Dkey = true;
        }
    }

    void CheckJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spacekey = true;
        }
    }

    void CheckInteraction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ekey = true;
        }
    }

}
