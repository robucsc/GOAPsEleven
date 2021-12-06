using UnityEngine;

public class Reuben : GAgent {

    new void Start() {

        // Call base Start method
        base.Start();
        // This subgoal runs once
        SubGoal s1 = new SubGoal("dont_join", 1, true);
        goals.Add(s1, 1);
        // This subgoal runs forever
        SubGoal s2 = new SubGoal("get_revenge", 1, false);
        goals.Add(s2, 2);

        Invoke("Unconvinced", Random.Range(0.0f, 1.0f));
        Invoke("DesireRevenge", Random.Range(0.0f, 1.0f));
        Invoke("Curiosity", Random.Range(0.0f, 1.0f));
    }


    void Unconvinced() {
        //agent thinks current topic is a bad idea
        beliefs.ModifyState("not_worth_it", 0);
        //Doesn't repeat    
    }
    
    void DesireRevenge() {
        //agent is passively waiting for a chance to get revenge
        beliefs.ModifyState("looking_for_revenge", 0);
        //Doesn't repeat 
    }

    void Curiosity() {
        //agent has question about current topic
        beliefs.ModifyState("have_question", 0);
        //Doesn't repeat    
    }

}