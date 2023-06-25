using System;

public class Goals{

    private static Goals _goalsimple = new Goals();
    private static Eternal _goaleternal = new Eternal();
    private static Checklist _goalchecklist = new Checklist();
    private static Negative _goalnegative = new Negative();
    public static void GoalMenu(){
        var _loop = true;
        var _goal = "";
        while(_loop){
            Console.Clear();
            Console.WriteLine("Please select from the following:");
            Console.WriteLine("\nThe types of Goals are:\n 1. Simple\n 2. Eternal\n 3. Checklist\n 4. Negative\n 5. (Return to Main Menu)");
            var _choice = Console.ReadLine();
            if(_choice == "1"){
                _goal = _goalsimple.CreateGoal();
                _loop = false;
            }else if(_choice == "2"){
                _goal = _goaleternal.CreateGoal();
                _loop = false;
            }else if(_choice == "3"){
                _goal = _goalchecklist.CreateGoal();
                _loop = false;           
            }else if(_choice == "4"){
                _goal = _goalnegative.CreateGoal();
                _loop = false;                
            }else if(_choice == "5"){
                _loop = false;
            }else{
                    Console.WriteLine("That wasn't a valid selection, please try again...");
                    System.Threading.Thread.Sleep(1000);
            }
            Console.Clear();
        }
        SaveGoals.AppendtoTemp(_goal);
    }
    public virtual string CreateGoal(){
        var _goal = "";
        Console.Write("What is the name of your Simple Goal: ");
        var _goalname = Console.ReadLine();
        Console.Write("What is a short description of your Simple Goal: ");
        var _goaldesc = Console.ReadLine();
        Console.Write("How many points is your Simple Goal worth?: ");
        var _goalpoints = Console.ReadLine();
        _goal = $"simplegoal, ,{_goalname},{_goaldesc},{_goalpoints}";
        return _goal;
    }
}
public class Eternal : Goals{
    public override string CreateGoal()
    {
        var _goal = "";
        Console.Write("What is the name of your Eternal Goal: ");
        var _goalname = Console.ReadLine();
        Console.Write("What is a short description of your Eternal Goal: ");
        var _goaldesc = Console.ReadLine();
        Console.Write("How many points is your Eternal Goal worth?: ");
        var _goalpoints = Console.ReadLine();
        _goal = $"eternalgoal, ,{_goalname},{_goaldesc},{_goalpoints}";
        return _goal;
    }
}
public class Checklist : Goals{
    public override string CreateGoal()
    {
        var _goal = "";
        Console.Write("What is the name of your Checklist Goal: ");
        var _goalname = Console.ReadLine();
        Console.Write("What is a short description of your Checklist Goal: ");
        var _goaldesc = Console.ReadLine();
        Console.Write("How many points is your Checklist Goal worth?: ");
        var _goalpoints = Console.ReadLine();
        Console.Write("How many times do you need to do your Checklist Goal?: ");
        var _goalreq = Console.ReadLine();
        _goal = $"checklistgoal, ,{_goalname},{_goaldesc},{_goalpoints},{_goalreq}";
        return _goal;
    }

}
public class Negative : Goals{
    public override string CreateGoal()
    {
        var _goal = "";
        Console.Write("What is the name of your Demerit?: ");
        var _goalname = Console.ReadLine();
        Console.Write("What is a short description of your Demerit: ");
        var _goaldesc = Console.ReadLine();
        Console.Write("How many points is your Demerit worth?: ");
        var _goalpoints = Console.ReadLine();
        _goal = $"negativegoal, ,{_goalname},{_goaldesc},{_goalpoints}";
        return _goal;
    }

}