using System;

public class RecordEvent{

    private static RecordEvent _eventsimple = new RecordEvent();
    private static ChecklistEvent _eventchecklist = new ChecklistEvent();
    private static NegativeEvent _eventnegative = new NegativeEvent();
    public static void RecordMenu(){
        ListGoals.List();
        var _loop = true;
        var count = 0;
        SaveLoad _run = new SaveLoad();
        var lines = _run.LoadFile("tempfile.csv");
        foreach(string line in lines){
            count += 1;
        }
        while(_loop){
            Console.Write("Which goal would you like to report?");
            Console.WriteLine($" Or enter {count} to return to the Main Menu:");
            var _choice = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(_choice) && int.Parse(_choice)-1 <= count && int.Parse(_choice) -1 >= 0){
                count = 0;
                foreach(string line in lines){
                    if(count == int.Parse(_choice)){
                        string[] parts = line.Split(",");
                        if(parts[0] == "simplegoal" || parts[0] == "eternalgoal"){
                            _eventsimple.RecordFunc(count, line);
                            _loop = false;
                        }else if(parts[0] == "checklistgoal"){
                            _eventchecklist.RecordFunc(count, line);
                            _loop = false;
                        }else if(parts[0] == "negativegoal"){
                            _eventnegative.RecordFunc(count, line);
                            _loop = false;
                        }
                    }
                    if(!string.IsNullOrWhiteSpace(line)){
                        count += 1;
                    }
                }
                _loop = false;
            }else if(!String.IsNullOrWhiteSpace(_choice) && int.Parse(_choice) == count){
                _loop = false;
            }else{
                Console.WriteLine("That wasn't a valid selection, please try again...");
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
    public virtual void RecordFunc(int _count, string _line){
        var repstring = "";
        var _addpoints = 0;
        string[] repline = File.ReadAllLines("tempfile.csv");
        string[] parts = _line.Split(",");
        if(string.IsNullOrWhiteSpace(parts[1])){
            parts[1] = "X";
            repstring = string.Join(",", parts);
            repline[_count] = repstring;

            string[] _currentpoints = repline[0].Split(",");
            _addpoints = int.Parse(parts[4]);
            var _newpoints = int.Parse(_currentpoints[1]) + _addpoints;
            repline[0] = $"Score,{_newpoints}";
            File.WriteAllLines("tempfile.csv", repline);
        }else{
            Console.WriteLine("You've already completed this goal.");
            System.Threading.Thread.Sleep(1500);
        }
    }
}
public class ChecklistEvent : RecordEvent{
    public override void RecordFunc(int _count, string _line){
        var repstring = "";
        var _addpoints = 0;
        string[] repline = File.ReadAllLines("tempfile.csv");
        string[] parts = _line.Split(",");
        if(string.IsNullOrWhiteSpace(parts[1])){
            parts[6] = (int.Parse(parts[6])+1).ToString();
            if(int.Parse(parts[6]) >= int.Parse(parts[5])){
                parts[1] = "X";
            }
            repstring = string.Join(",", parts);
            repline[_count] = repstring;

            string[] _currentpoints = repline[0].Split(",");
            _addpoints = int.Parse(parts[4]);
            var _newpoints = int.Parse(_currentpoints[1]) + _addpoints;
            repline[0] = $"Score,{_newpoints}";
            File.WriteAllLines("tempfile.csv", repline);
        }else{
            Console.WriteLine("You've already completed this goal.");
            System.Threading.Thread.Sleep(1500);
        }
    }

}
public class NegativeEvent : RecordEvent{
    public override void RecordFunc(int _count, string _line)
    {
        var _addpoints = 0;
        string[] repline = File.ReadAllLines("tempfile.csv");
        string[] parts = _line.Split(",");

        string[] _currentpoints = repline[0].Split(",");
        _addpoints = int.Parse(parts[4]);
        var _newpoints = int.Parse(_currentpoints[1]) - _addpoints;
        repline[0] = $"Score,{_newpoints}";
        File.WriteAllLines("tempfile.csv", repline);
    }
}
