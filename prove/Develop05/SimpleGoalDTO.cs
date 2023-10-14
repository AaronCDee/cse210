using System.Text.Json.Serialization;
[JsonDerivedType(typeof(SimpleGoalDTO), typeDiscriminator: "SimpleGoal")]
class SimpleGoalDTO : GoalDTO {
    public bool _isComplete {get; set;}
    public SimpleGoalDTO(string shortName, string description, int points, bool isComplete, string type) : base(shortName, description, points, type){
        _isComplete = isComplete;
    }
}