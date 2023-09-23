using System.CodeDom.Compiler;

public class PromptGenerator
{

    public List<string> _prompts = new List<string>()
    {
        "Describe a moment when you felt truly happy.",
        "Write about a person who has had a significant impact on your life.",
        "What are your top 5 short-term goals?",
        "Describe a place you've always wanted to visit and why.",
        "Write about a time when you overcame a challenge.",
        "What is your favorite childhood memory?",
        "List 10 things you're grateful for today.",
        "If you could travel back in time, where and when would you go?",
        "Write a letter to your future self.",
        "Describe your ideal day from start to finish.",
        "What is your favorite book and why?",
        "What are your strengths and weaknesses?",
        "Write about a hobby or skill you'd like to learn in the future.",
        "What is the most important lesson you've learned in life so far?",
        "Describe a person you admire and why.",
        "Write about a time you felt proud of yourself.",
        "If you could have any superpower, what would it be and why?",
        "What is your favorite quote and what does it mean to you?",
        "Describe a memorable dream you've had.",
        "Write about a time you had to make a difficult decision.",
        "List 5 things that make you smile.",
        "What does happiness mean to you?",
        "Describe your ideal job or career.",
        "Write about a time when you faced a fear.",
        "What are your favorite ways to relax and unwind?",
        "If you could meet any historical figure, who would it be and why?",
        "What are your long-term goals and aspirations?",
        "Write about a time you felt inspired by someone or something.",
        "What would you do if you had a day with no obligations?",
        "Describe a place in nature that you find calming and beautiful.",
        "Write about a time you experienced a major change in your life.",
        "What is your favorite season and why?",
        "What do you value most in your friendships?",
        "List 3 things you'd like to accomplish in the next year.",
        "Write about a time when you helped someone in need.",
        "What is your favorite way to express yourself creatively?",
        "Describe a favorite childhood game or activity.",
        "Write about a time when you felt inspired by nature.",
        "If you could live in any time period, when would it be and why?",
        "What are your favorite ways to practice self-care?",
        "List 5 things that make you feel at peace.",
        "What is your favorite childhood book or movie?",
        "Write about a time you had to apologize or make amends.",
        "What are your favorite qualities in a friend?",
        "If you could visit any country in the world, where would you go?",
        "Describe a time when you had to overcome self-doubt.",
        "What are your favorite foods and why?",
        "Write about a time when you learned something new.",
        "What does success mean to you?",
        "List 3 things you love about yourself."
    };

    public PromptGenerator()
    {
        
    }

    public string GeneratePrompt()
    {
        Random randomGenerator = new Random();
        int randomStart = 0;
        int randomEnd = _prompts.Count - 1;
        int index = randomGenerator.Next(randomStart, randomEnd);
        return _prompts[index];
    }
}