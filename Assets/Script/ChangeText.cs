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
            "Les tableaux de mon musée se sont envolés, et celui-ci se retrouve complètement vidé de son charme d'antan !",
            "Votre mission, si vous l'accepter, serait de chercher les roues de Mulhouse qui se sont égarées dans la ville.",
            "Cela permettra de réparer temporairement mon imprimante et de restaurer le musée.",
            "Une dernière chose avant que vous partiez... J'ai perdu une image très importante, qui faisait toute la réputation de mon musée.",
            "Sa valeur est inestimable... J'espère que vous pourrez également la retrouver et me la rapporter.",
            "Tout ce dont je me souviens est le bruit d'un sifflet de train...",
            "Bonne chance à vous !!"
        };

        if (Input.GetKeyDown(KeyCode.E) && textIndex < textValues.Length)
        {
            Debug.Log("here");
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
