class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string>(){
            "Reflect on a recent accomplishment. What did you learn from it?",
            "Think about a challenging situation you've faced recently. How did you handle it?",
            "Consider someone who has had a positive impact on your life. What do you appreciate about them?",
            "Reflect on a mistake you've made. What lessons did you gain from it?",
            "What are three things that you're grateful for in your life right now?",
            "Take a moment to consider your long-term goals. What steps can you take to work toward them?",
            "Reflect on a time when you felt truly happy and content. What were you doing?",
            "What are your core values, and how do they guide your decisions?",
            "Think about a situation where you felt challenged or outside your comfort zone. What did you learn about yourself?",
            "Consider your daily routines. Are there any habits you'd like to change or improve?",
            "Reflect on a relationship in your life. How can you strengthen or nurture it?",
            "Imagine your ideal day from start to finish. What activities and experiences would it include?",
            "What are your biggest strengths, and how can you leverage them in your personal or professional life?",
            "Reflect on a book, article, or TED talk that has had a profound impact on you. What insights did you gain?",
            "Think about a challenge you're currently facing. What strategies can you use to overcome it?",
            "Consider a time when you helped someone or made a positive difference. How did it make you feel?",
            "Reflect on your current priorities. Are there any adjustments you'd like to make?",
            "What brings you a sense of inner peace and calm? How can you incorporate more of it into your life?",
            "Reflect on your proudest moments in life. What values and principles do they reflect?",
            "Imagine yourself in 10 years. What do you hope to have accomplished or experienced by then?"
        };
    private List<string> _questions = new List<string>(){
            "How does this reflection make you feel?",
            "Can you elaborate on your thought process during this reflection?",
            "Are there any insights or realizations that stand out to you?",
            "How might this reflection impact your future decisions?",
            "What connections or patterns do you see between this reflection and your life?",
            "How can you apply the lessons from this reflection in your daily life?",
            "Are there any changes or adjustments you'd like to make as a result of this reflection?",
            "How has this reflection influenced your perspective or understanding?",
            "Can you identify any strengths or areas of growth from this reflection?",
            "In what ways can this reflection contribute to your personal development?",
            "What questions or uncertainties does this reflection raise for you?",
            "How can you share or discuss this reflection with others?",
            "Have you considered seeking additional information or resources related to this reflection?",
            "What role does gratitude play in your reflection?",
            "Can you set specific goals based on the insights gained from this reflection?",
            "How might this reflection align with your values and beliefs?",
            "What steps can you take to bring about positive change from this reflection?",
            "How can you use this reflection as a source of motivation or inspiration?",
            "Are there any unexpected or surprising aspects of this reflection?",
            "How can you integrate the wisdom from this reflection into your life moving forward?"
        };
    public ReflectingActivity(string name = "Reflecting", string description = "This activity will help you reflect on times in your life when you have shown strenth and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(name, description){
        
    }
    public void Run(){
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        int thinkTime = 10;
        int runTime = _duration;
        while(runTime > 0){
            DisplayQuestion();
            ShowSpinner(thinkTime, true);
            Console.WriteLine();
            runTime -= thinkTime;
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public string GetRandomPrompt(){
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count())];
    }
    public string GetRandomQuestion(){
        Random rand = new Random();
        return _questions[rand.Next(0, _questions.Count())];
    }
    public void DisplayPrompt(){
        Console.WriteLine("Consider the following prompt\r\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\r\n");
    }
    public void DisplayQuestion(){
        Console.Write($"> {GetRandomQuestion()}");
    }
}