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

    public Dialogue(string firstName, string[] nextSentences, bool button, int[] nextScore)
    {
        name = firstName;
        sentences = nextSentences;
        isButton = button;
        score = nextScore;
    }

}

