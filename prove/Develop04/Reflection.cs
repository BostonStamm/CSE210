using System;

public class Reflection{    
    private static string[] _prompt_list = {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };
    private static string[] _reflect_list = {
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    public Reflection(){}

    private List<string> _prompts = new List<string>(_prompt_list);
    private List<string> _reflects = new List<string>(_reflect_list);
    public string FetchPrompt(){
        var random = new RNG();
        int index = random.RNGGenerate(_prompts.Count);
        string _prompt = _prompts[index]; 
        return _prompt;
    }
    public string FetchReflect(){
        var random = new RNG();
        int index = random.RNGGenerate(_reflects.Count);
        string reflect = _reflects[index];
        return reflect;
    }
}

public class ReflectionActivity : Reflection{
    public void RunReflection(){
        ReflectionAnimation _animation = new ReflectionAnimation();
        var _prompt = FetchPrompt();
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long would you like to go? (In seconds)");
        var _time = int.Parse(Console.ReadLine());
        DateTime _start_time = DateTime.Now;
        DateTime _end_time = _start_time.AddSeconds(_time);
        Console.WriteLine(_prompt);
        DateTime _current_time = DateTime.Now;
        while(_current_time < _end_time){
            _animation.AnimateReflection(9);
            var _reflect = FetchReflect();
            Console.WriteLine("\n", _reflect, "\n");
            _animation.AnimateReflection(12);
            _current_time = DateTime.Now;
        }
    }
}

public class ReflectionAnimation{
    public void AnimateReflection(int _seconds){
        while(_seconds > 0){
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            _seconds -= 1;
            ClearLine();
            Console.Write("..");
            System.Threading.Thread.Sleep(1000);
            _seconds -= 1;
            ClearLine();
            Console.Write("...");
            System.Threading.Thread.Sleep(1000);
            _seconds -= 1;
            ClearLine();
        }
    }
    private static void ClearLine(){
        int _current_line = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, _current_line);
    }
}

