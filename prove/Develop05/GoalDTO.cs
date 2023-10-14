using System.Text.Json.Serialization;
[JsonDerivedType(typeof(GoalDTO), typeDiscriminator: "BaseGoal")]



class GoalDTO {
    public string ShortName {get; set;}
    public string Description {get; set;}
    public int Points {get; set;}
    public string Type {get; set;}

    public GoalDTO(string shortName, string description, int points, string type){
        ShortName = shortName;
        Description = description;
        Points = points;
        Type = type;
    }
}