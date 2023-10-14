using System.Text.Json.Serialization;
[JsonDerivedType(typeof(GoalDTO), typeDiscriminator: "BaseGoal")]



class GoalDTO {
    public string _shortName {get; set;}
    public string _description {get; set;}
    public int _points {get; set;}
    public string _type {get; set;}

    public GoalDTO(string shortName, string description, int points, string type){
        _shortName = shortName;
        _description = description;
        _points = points;
        _type = type;
    }
}