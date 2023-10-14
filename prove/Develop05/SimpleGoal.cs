using System.Text.Json;

class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points){
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete){
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if(!IsComplete()){
            _isComplete = true;
        }
    }

    public override SimpleGoalDTO GetDTO(){
        SimpleGoalDTO dto = new SimpleGoalDTO(_shortName, _description, _points, _isComplete, "SimpleGoal");
        return dto;
    }
}