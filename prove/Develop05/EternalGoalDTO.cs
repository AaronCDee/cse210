using System.Text.Json.Serialization;
[JsonDerivedType(typeof(EternalGoalDTO), typeDiscriminator: "EternalGoal")]
class EternalGoalDTO : GoalDTO {
    public EternalGoalDTO(string shortName, string description, int points, string type) : base(shortName, description, points, type){

    }
}