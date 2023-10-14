using System.Text.Json.Serialization;
[JsonDerivedType(typeof(ChecklistGoalDTO), typeDiscriminator: "ChecklistGoal")]
class ChecklistGoalDTO : GoalDTO {
    public int _target {get; set;}
    public int _bonus {get; set;}
    public int _amountCompleted {get; set;}
    public ChecklistGoalDTO(string shortName, string description, int points, int target, int bonus, int amountCompleted, string type) : base(shortName, description, points, type){
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
}