using System.Text.Json.Serialization;
[JsonDerivedType(typeof(GoalManagerDTO), typeDiscriminator: "GoalManager")]
class GoalManagerDTO {
    public int Score {get; set;}

    public GoalManagerDTO(int score){
        Score = score;
    }
}