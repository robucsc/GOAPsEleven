using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    //Note: There should only be 3 characters
    public string name;
    public string[] sentences;
    public bool isButton;
    public int[] score;

    //no values passed in
    public Dialogue(){
        name = "";
        isButton = false;
    }
    //Pass in values
    public Dialogue(string firstName, string[] incomingSentences, bool button, int[] scoreValue){
        name = firstName;
        sentences = incomingSentences;
        isButton = button;
        score = scoreValue;
    }

}

