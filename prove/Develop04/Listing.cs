using System;

public class Listing{    
    public string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private static string[] _L_prompt_list = {
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?", 
        "Who are people that you have helped this week?", 
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing(){}

    private List<string> _prompts = new List<string>(_L_prompt_list);
    public string FetchLPrompt(){
        var random = new RNG();
        int index = random.RNGGenerate(_prompts.Count);
        string _prompt = _prompts[index];
        return _prompt;
    }
}

public class ListingActivity : Listing{
    public void RunListing(){
        ListingAnimation _animation = new ListingAnimation();
        var _prompt = FetchLPrompt();
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long would you like to go? (In seconds)");
        var _time = int.Parse(Console.ReadLine());
        DateTime _start_time = DateTime.Now;
        DateTime _end_time = _start_time.AddSeconds(_time);
        Console.WriteLine(_prompt);
        DateTime _current_time = DateTime.Now;
        while(_current_time < _end_time){
            _animation.AnimateListing(8);
            Console.WriteLine("\nKeep listing! You can do it!\n");
            _animation.AnimateListing(8);
            _current_time = DateTime.Now;
        }
    }
}

public class ListingAnimation{
    public void AnimateListing(int _seconds){
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
            Console.Write("....");
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