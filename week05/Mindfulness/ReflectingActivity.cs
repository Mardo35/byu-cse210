public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> 
    { 
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // 10 self-growth questions enhancement
    private List<string> _questions = new List<string> 
    { 
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "How has this experience shaped the person you are today?",
        "If you had the chance, would you do it again?"
    };

    public ReflectingActivity() : base("Reflecting Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.") {}

    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];

    public string GetRandomQuestion() => _questions[new Random().Next(_questions.Count)];

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");
        ShowCountDown(5);
    }

    public void DisplayQuestions()
    {
        // Fetches a random question from the encapsulated list
        Console.Write($"\n> {GetRandomQuestion()} ");
        ShowSpinner(10); // Pauses 
    }
}