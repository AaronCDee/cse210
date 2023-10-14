using System.Text.Json;
class ChecklistGoal : Goal {
    private int _target {get; set;}
    private int _bonus {get; set;}
    private int _amountCompleted {get; set;}
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if(_amountCompleted < _target){
            _amountCompleted += 1;
        }
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? 'X' : ' ')}] {_shortName} ({_description}) -- Completed ({_amountCompleted}/{_target})";
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override int GetPoints()
    {
        return IsComplete() ? _points + _bonus : _points;
    }

    public override ChecklistGoalDTO GetDTO(){
        ChecklistGoalDTO dto = new ChecklistGoalDTO(_shortName, _description, _points, _target, _bonus, _amountCompleted, "ChecklistGoal");
        return dto;
    }
}