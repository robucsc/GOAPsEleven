using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    
    public Dialogue dialogue;


    public void TriggerDialogue(){

        if (dialogue.isButton == false){
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
        else{
            FindObjectOfType<ButtonManager>().ShowOptions(dialogue);
        }
    }

}
