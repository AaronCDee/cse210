using System.IO.Enumeration;
using System.Linq.Expressions;
using System.Text.Json;
class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){
        _score = 0;
    }

    public void Start(){
        string input = "";
        while(input != "6"){
            DisplayPlayerInfo();
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                break;
                case "2":
                    ListGoalDetails();
                break;
                case "3":
                    Console.Write("Please specify the file name to save to (must end in .txt): ");
                    string saveFilePath = Console.ReadLine();
                    SaveGoals(saveFilePath);
                break;
                case "4":
                    Console.Write("Please specify the file name to load from (must end in .txt): ");
                    string loadFilePath = Console.ReadLine();
                    LoadGoals(loadFilePath);
                break;
                case "5":
                    RecordEvent();
                break;
                case "6":
                    Console.WriteLine("Thanks for playing");
                break;
                default:
                    Console.WriteLine("Selection not supported, please select a valid option");
                    break;
            }
        }
        
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.\r\n");
        Console.WriteLine("Menu Options");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
    }

    public void ListGoalNames(){
        if(!_goals.Any()){
            Console.WriteLine("You don't have any goals");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 1; i <= _goals.Count; i++)
        {
            Goal goal = _goals[i-1];
            Console.WriteLine($"{i}. {goal.GetShortName()}");  
        }
        Console.WriteLine();  
    }

    public void ListGoalDetails(){
        if(!_goals.Any()){
            Console.WriteLine("You don't have any goals");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 1; i <= _goals.Count; i++)
        {
            Goal goal = _goals[i-1];
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");  
        }
        Console.WriteLine();  
    }

    public void CreateGoal(){
        List<string> validInputs = new List<string>(){
            "1",
            "2",
            "3",
            "4"
        };

        bool createGoalInputValid = false;
        string createGoalInput = "";
        while(!createGoalInputValid){
            Console.WriteLine("Please select a goal you would like to create:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Cancel");
            createGoalInput = Console.ReadLine().Trim();
            createGoalInputValid = validInputs.Contains(createGoalInput);
            if(!createGoalInputValid){
                Console.WriteLine("Invalid Input");
            }
        }


        switch (createGoalInput)
        {
            case "1":
            {
                Console.Write("What is the name of your simple goal? ");
                string shortName = Console.ReadLine().Trim();
                Console.Write("What is the description your simple goal? ");
                string description = Console.ReadLine().Trim();
                Console.Write("How many points for achieving this simple goal? ");
                int points = 0;
                bool isNumeric = false;
                while(!isNumeric){
                    isNumeric = int.TryParse(Console.ReadLine().Trim(), out points);
                    if(!isNumeric){
                        Console.WriteLine("Please enter a valid integer");
                    }
                }

                SimpleGoal sg = new SimpleGoal(shortName, description, points);
                AddGoal(sg);
            }
            break;
            case "2":
            {
                Console.Write("What is the name of your eternal goal? ");
                string shortName = Console.ReadLine().Trim();
                Console.Write("What is the description your eternal goal? ");
                string description = Console.ReadLine().Trim();
                Console.Write("How many points for achieving this eternal goal? ");
                int points = 0;
                bool isNumeric = false;
                while(!isNumeric){
                    isNumeric = int.TryParse(Console.ReadLine().Trim(), out points);
                    if(!isNumeric){
                        Console.WriteLine("Please enter a valid integer");
                    }
                }

                EternalGoal eg = new EternalGoal(shortName, description, points);
                AddGoal(eg);
            }
            break;
            case "3":
            {
                Console.Write("What is the name of your checklist goal? ");
                string shortName = Console.ReadLine().Trim();
                Console.Write("What is the description your checklist goal? ");
                string description = Console.ReadLine().Trim();
                Console.Write("How many points for achieving this checklist goal? ");
                int points = 0;
                bool isNumeric = false;
                while(!isNumeric){
                    isNumeric = int.TryParse(Console.ReadLine().Trim(), out points);
                    if(!isNumeric){
                        Console.WriteLine("Please enter a valid integer");
                    }
                }
                
                Console.Write("What is the target number of times you want to complete this goal? ");
                int target = 0;
                isNumeric = false;
                while(!isNumeric){
                    isNumeric = int.TryParse(Console.ReadLine().Trim(), out target);
                    if(!isNumeric){
                        Console.WriteLine("Please enter a valid integer");
                    }
                }

                Console.Write("How many bonus points for reaching your target? ");
                int bonus = 0;
                isNumeric = false;
                while(!isNumeric){
                    isNumeric = int.TryParse(Console.ReadLine().Trim(), out bonus);
                    if(!isNumeric){
                        Console.WriteLine("Please enter a valid integer");
                    }
                }

                ChecklistGoal cg = new ChecklistGoal(shortName, description, points, target, bonus);
                AddGoal(cg);
            }
            break;
            default:
            break;
        }
        
    }


    public void RecordEvent(){
        ListGoalNames();
        
        bool goalExists = false;
        int goalIndex = -1;
        while(!goalExists){
            Console.Write("Which goal did you accomplish? ");
            string goalIndexStr = Console.ReadLine().Trim();
            goalIndex = int.Parse(goalIndexStr) - 1;
            goalExists = _goals.ElementAt(goalIndex) != null && goalIndex >= 0;
            if(!goalExists){
                Console.WriteLine("That goal doesn't exist...");
            }
        }

        Goal selectedGoal = _goals[goalIndex];
        if(!selectedGoal.IsComplete()){
            selectedGoal.RecordEvent();
            int pointsToAdd = selectedGoal.GetPoints();
            _score += pointsToAdd;
            Console.WriteLine($"Congratulations, you earned {pointsToAdd} points!");
            
        } else {
            Console.WriteLine("That goal is already complete");
        }
        Console.WriteLine();
    }

    public void SaveGoals(string filePath = "playerInfo.txt"){
        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            GoalManagerDTO dto = new GoalManagerDTO(_score);
            string jsonString = JsonSerializer.Serialize(dto);
            writer.WriteLine(jsonString);
            foreach (Goal goal in _goals)
            {   
                if(goal is SimpleGoal simpleGoal){
                    SimpleGoalDTO simpDto = simpleGoal.GetDTO();
                    string simpDtoJsonStr = JsonSerializer.Serialize(simpDto);
                    writer.WriteLine(simpDtoJsonStr);
                }

                if(goal is EternalGoal eternalGoal){
                    EternalGoalDTO eternDto = eternalGoal.GetDTO();
                    string eternDtoJsonStr = JsonSerializer.Serialize(eternDto);
                    writer.WriteLine(eternDtoJsonStr);
                }

                if(goal is ChecklistGoal checkGoal){
                    ChecklistGoalDTO checkDto = checkGoal.GetDTO();
                    string checkDtoJsonStr = JsonSerializer.Serialize(checkDto);
                    writer.WriteLine(checkDtoJsonStr);
                }
            }
        }

    }

    public void LoadGoals(string filePath = "./playerInfo.txt"){
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isFirstLine = true; 
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    if (isFirstLine)
                    {
                        
                        isFirstLine = false; 
                        GoalManagerDTO gmDTO = JsonSerializer.Deserialize<GoalManagerDTO>(line);
                        _score = gmDTO.Score;
                    }
    
                    object deserializedObject = JsonSerializer.Deserialize<object>(line);

                    if (deserializedObject is JsonElement jsonElement)
                    {
                        if (jsonElement.TryGetProperty("$type", out var typeProperty))
                        {
                            string typeDiscriminator = typeProperty.GetString();

                            switch (typeDiscriminator)
                            {
                                case "SimpleGoal":
                                {
                                    SimpleGoalDTO simpleGoal = JsonSerializer.Deserialize<SimpleGoalDTO>(line);
                                    SimpleGoal g = new SimpleGoal(simpleGoal._shortName, simpleGoal._description, simpleGoal._points);
                                    g.SetIsComplete(simpleGoal._isComplete);
                                    AddGoal(g);
                                    break;
                                }
                                case "EternalGoal":
                                {
                                    EternalGoalDTO eternalGoal = JsonSerializer.Deserialize<EternalGoalDTO>(line);
                                    EternalGoal g = new EternalGoal(eternalGoal._shortName, eternalGoal._description, eternalGoal._points);
                                    AddGoal(g);
                                    break;
                                }
                                case "ChecklistGoal":
                                {
                                    ChecklistGoalDTO checklistGoal = JsonSerializer.Deserialize<ChecklistGoalDTO>(line);
                                    ChecklistGoal g = new ChecklistGoal(checklistGoal._shortName, checklistGoal._description, checklistGoal._points, checklistGoal._target, checklistGoal._bonus);
                                    AddGoal(g);
                                    break;
                                }
                                    

                                

                                default:
                                    // Handle unknown types or errors
                                    break;
                            }
                        }
                    }
                    
                }
            }
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }

    public void AddGoal(Goal goal){
        _goals.Add(goal);
    }
}