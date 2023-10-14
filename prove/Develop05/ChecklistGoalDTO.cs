using System.Text.Json.Serialization;
[JsonDerivedType(typeof(ChecklistGoalDTO), typeDiscriminator: "ChecklistGoal")]
class ChecklistGoalDTO : GoalDTO {
    public int Target {get; set;}
    public int Bonus {get; set;}
    public int AmountCompleted {get; set;}
    public ChecklistGoalDTO(string shortName, string description, int points, int target, int bonus, int amountCompleted, string type) : base(shortName, description, points, type){
        Target = target;
        Bonus = bonus;
        AmountCompleted = amountCompleted;
    }
}