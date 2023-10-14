using System.Text.Json;
class EternalGoal : Goal {

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points){

    }

    public override EternalGoalDTO GetDTO(){
        EternalGoalDTO dto = new EternalGoalDTO(_shortName, _description, _points, "EternalGoal");
        return dto;
    }
}