using System;

public class Breathing{   
    public string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public Breathing(){}
}

public class BreathingActivity : Breathing{
    public void RunBreathing(){
        BreathingAnimation _animation = new BreathingAnimation();
        Console.WriteLine(_description);
        Console.WriteLine("\nHow long would you like to go? (In seconds)");
        var _time = int.Parse(Console.ReadLine());
        DateTime _start_time = DateTime.Now;
        DateTime _end_time = _start_time.AddSeconds(_time);
        DateTime _current_time = DateTime.Now;
        while(_current_time < _end_time){
            Console.WriteLine("Breathe in...\n");
            _animation.AnimateBreathing(5);
            Console.WriteLine("Breathe out...\n");
            _animation.AnimateBreathing(5);
            _current_time = DateTime.Now;
        }
    }
}

public class BreathingAnimation{
    public void AnimateBreathing(int _seconds){
        while(_seconds > 0){
            Console.Write(_seconds);
            System.Threading.Thread.Sleep(1000);
            ClearLine();
            _seconds -= 1;
        }
    }
    private static void ClearLine(){
        int _current_line = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, _current_line);
    }
}

