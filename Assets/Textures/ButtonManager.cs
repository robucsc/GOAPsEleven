using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    public GameObject[] buttons;
    public Text[] buttonText;
    public int[] score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ShowOptions(Dialogue dialogue)
    {
        score = dialogue.score;
        int x = 0;
        foreach(string sentence in dialogue.sentences){
            buttons[x].SetActive(true);
            buttonText[x].text = sentence;
            x++;
        }  
    }

    void setInactive (){
        //Disable the buttons
        foreach(GameObject button in buttons){
            button.SetActive(false);
        }  
    }

    public void choiceMade(){
        setInactive();
        //Put in code to judge choice/choose next prompt here!!

        
    }
}
