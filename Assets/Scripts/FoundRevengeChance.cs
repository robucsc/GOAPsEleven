public class FoundRevengeChance : GAction {
    public override bool PrePerform() {
        target = GWorld.Instance.GetQueue("revenge_chance").RemoveResource();
        //The "chance for revenge" is listed as a resource for convenience
        if (target == null) {
            return false;
        }
        return true;
    }

    public override bool PostPerform() {

        //the agent found a chance for revenge
        beliefs.RemoveState("looking_for_revenge");
        GWorld.Instance.GetWorld().ModifyState("good_reason", +1);
        //INSERT FUNCTION HERE THAT DISPLAYS RELATED TEXT
        return true;
    }
}