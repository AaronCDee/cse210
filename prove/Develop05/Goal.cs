using System.Text.Json;
class Goal {
    protected string _shortName {get; set;}
    protected string _description {get; set;}
    protected int _points {get; set;}
    protected JsonSerializerOptions _jsonOptions = new JsonSerializerOptions { };

    public Goal(string shortName, string description, int points){
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent(){}

    public virtual bool IsComplete(){
        return false; // eternal goal uses this implementation
    }

    public virtual string GetDetailsString(){
        return $"[{(IsComplete() ? 'X' : ' ')}] {_shortName} ({_description})";
    }

    public virtual GoalDTO GetDTO(){
        GoalDTO dto = new GoalDTO(_shortName, _description, _points, "Goal");
        return dto;
    }

    public virtual int GetPoints(){
        return _points;
    }

    public virtual string GetShortName(){
        return _shortName;
    }
}