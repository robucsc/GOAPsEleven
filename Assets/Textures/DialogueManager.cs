using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public GameObject[] characters;
    public Text nameText;
    public Text dialogueText;
    public GameObject textBox;

    public float textSpeed = 0.03f;
    
    void Start()
    {
        sentences = new Queue<string>();
        setInactive();
    }

    //This is where you start the chain of dialogue
    public void StartDialogue (Dialogue dialogue){
        textBox.SetActive(true);
        Debug.Log("Starting Dialogue...");

        //Set the image to the character
        CharacterSelect(dialogue);
        
        //Clear previous sentences
        sentences.Clear();

        //Enqueue all of the dialogue into the array sentences
        foreach( string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence (){
        //If there's no more sentences, end conversation
        if (sentences.Count == 0){
            EndDialogue();
            return;
        }
        //Dequeue the next part of the dialogue
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence){
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void EndDialogue(){
        setInactive();
        textBox.SetActive(false);
        Debug.Log("End Sentences...");
    }

    void CharacterSelect(Dialogue dialogue){
        if(dialogue.name == "Reuben"){
            characters[0].SetActive(true);
        }
        else if(dialogue.name == "Danny"){
            characters[1].SetActive(true);
        }
        else{
            characters[2].SetActive(true);
        }
        //Set the name to the name variable in dialogue
        nameText.text = dialogue.name;
    }

    void setInactive (){
        //Disable the image for each character
        foreach(GameObject character in characters){
            character.SetActive(false);
        }  
    }
}
