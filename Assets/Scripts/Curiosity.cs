public class FoundRevengeChance : GAction {
    public override bool PrePerform() {

        return true;
    }

    public override bool PostPerform() {

        //the agent found a chance for revenge
        beliefs.RemoveState("have_question");
        GWorld.Instance.GetWorld().ModifyState("revenge_chance", +1);
        //INSERT FUNCTION HERE THAT DISPLAYS RELATED TEXT
        
        return true;
    }
}