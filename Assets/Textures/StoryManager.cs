using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{

    public int Persuasion;

    public int currentStoryQuestion;
    Dictionary<int, Dialogue> Storyline;

    // Start is called before the first frame update
    void Start()
    {
        Persuasion = 0;
        currentStoryQuestion = -1;

        Storyline = new Dictionary<int, Dialogue>();
        //Dialogue(string firstName, string[] incomingSentences, bool button, int[] scoreValue)
        string firstName = "Reuben";
        string[] incomingSentences = {"But what am I saying? You guys are pros, the best.",
        "I'm sure you can make it out of the casino. Of course, lest we forget, once you're out the front door",
        "you're still in the middle of the fucking desert!"};
        bool button = false;
        int[] scoreValue = {1, 2};
        Dialogue newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
        
        Storyline.Add(0, newDialogue);
        
        //Part 2
        firstName = "Danny";
        incomingSentences = new string[]{"Reuben, you're right. Our eyes are bigger than our stomachs.",
        "Thank you so much for setting us straight. Sorry we bothered you.",
        "I guess we won't be robbing The Bellagio, Mirage, or the M.G.M. Grand."};
        button = false;
        scoreValue = new int[]{1, 2};
        newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
        
        Storyline.Add(1, newDialogue);

        //Part 3
        firstName = "Reuben";
        incomingSentences = new string[]{"Those are Terry Benedict's casinos.",
        "You guys... Whadda you got against Terry Benedict?"};
        button = false;
        scoreValue = new int[]{1, 2};
        newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
        
        Storyline.Add(2, newDialogue);

        //Part 4
        firstName = "Reuben";
        incomingSentences = new string[]{"What do you have against him? That's the real question.",
        "Nothing. We just want to make a quick buck",
        "Everything, we hate his guts"};
        button = true;
        scoreValue = new int[]{1, -1, 1};
        newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
        
        Storyline.Add(3, newDialogue);
        
        //Part 5
        firstName = "Reuben";
        incomingSentences = new string[]{"He torpedoed my casino, muscled me out, now he's gonna blow it up next month to make way for another fuckin' eyesore.",
        "You gonna steal from Terry Benedict, you better goddamn know. This sorta thing used to be civilized.",
        "You'd hit a guy, he'd whack you. Done.",
        "But Benedict... At the end of this he better not know you're involved, not know your names, or think you're dead.",
        "Because he'll kill you, and then he'll go to work on you."};
        button = false;
        scoreValue = new int[]{1, 2};
        newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
        
        Storyline.Add(4, newDialogue);

        //Part 6
        firstName = "Danny";
        incomingSentences = new string[]{"That's why we've got to be very careful. We have to be precise. We have to be well-funded.",
        "We're the best team, you've never seen a team better than us",
        "We're gonna be careful. We know what we're going into and we'll be prepared"};
        button = true;
        scoreValue = new int[]{1, -1, 1};
        newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
        
        Storyline.Add(5, newDialogue);

        //Part 7
        firstName = "Reuben";
        incomingSentences = new string[]{"Yeah, you gotta be nuts, too. And you're gonna need a crew as nuts as you are.",
        "(pregnant silence)",
        "Who do you have in mind?"};
        button = false;
        scoreValue = new int[]{1, -1, 1};
        newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
        
        Storyline.Add(6, newDialogue);

        //Part 8
        firstName = "Rusty";
        incomingSentences = new string[]{"Danny and Rusty both smile, they've hooked their fish.",
        "Alright. Who's in?"};
        button = false;
        scoreValue = new int[]{1, -1, 1};
        newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
        
        Storyline.Add(7, newDialogue);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProgressStory(){
        currentStoryQuestion++;
        if(currentStoryQuestion == 8){
            if(Persuasion > 0){
                string firstName = "Reuben";
                string[] incomingSentences = {"You've convinced me. I'm in.",};
                bool button = false;
                int[] scoreValue = {1, 2};
                Dialogue newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
                Storyline.Add(8, newDialogue);
            }
            else{
                string firstName = "Reuben";
                string[] incomingSentences = {"Get out of my backyard right now before I kill you myself.",};
                bool button = false;
                int[] scoreValue = {1, 2};
                Dialogue newDialogue = new Dialogue(firstName, incomingSentences, button, scoreValue);
                Storyline.Add(8, newDialogue);
            }
        }
        Debug.Log(Storyline[currentStoryQuestion].name);
        var nextStoryState = Storyline[currentStoryQuestion];
        FindObjectOfType<DialogueTrigger>().InsertDialogue(nextStoryState);

    }

    public void Persuade(int change){
        Persuasion += change;  
    }

}
