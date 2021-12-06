public class ChangeOfHeart : GAction {
    public override bool PrePerform() {
        target = GWorld.Instance.GetQueue("good_reason").RemoveResource();
        //The "reason for joining" is listed as a resource for convenience
        if (target == null) {
            return false;
        }
        return true;
    }

    public override bool PostPerform() {

        //the agent found something of value worth overriding
        //their prior misgivings
        beliefs.RemoveState("not_worth_it");

        //INSERT FUNCTION HERE THAT DISPLAYS RELATED TEXT
        return true;
    }
}