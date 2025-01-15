using UnityEngine;
using TMPro;
using System;

public class ChangeText : MonoBehaviour
{   
    public TMP_Text text;
    public TMP_Text textContinue;
    private int textIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject myPlayer = GameObject.FindWithTag("Player");
        PlayerQuestState playerQuestState = myPlayer.GetComponent<PlayerQuestState>();
        String[] textValues = {
            "bonjour",
            "je",
            "suis",
            "moi"
        };

        if (Input.GetKeyDown(KeyCode.E) && textIndex < textValues.Length)
        {
            text.text = textValues[textIndex];
            textIndex++;
            if (textIndex >= textValues.Length)
            {
                textContinue.text = "Appuyer sur [E] pour fermer";
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) && textIndex >= textValues.Length)
        {
            playerQuestState.questAccepted = true;
        }
    }
}
