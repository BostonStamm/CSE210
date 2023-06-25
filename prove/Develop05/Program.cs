using System;

class Program
{
    static void Main(string[] args)
    {        
        LoadAppData _appdata = new LoadAppData();
        Console.Clear();
        _appdata.CheckForFile();

        var _loop = true;
        while(_loop){
            var _userscore = _appdata.GetLatestScore();
            Console.Clear();
            Console.WriteLine($"You have {_userscore} points.");
            Console.WriteLine("Menu Options: (If you want to make a new save file, select Save Goals.)");
            Console.WriteLine($"\n 1: Create a New Goal\n 2: List Goals\n 3: Save Goals\n 4: Load Goals\n 5: Record Event\n 6: Quit");
            var _choice = Console.ReadLine();
            if(_choice == "1"){
                Goals.GoalMenu();
            }else if(_choice == "2"){
                ListGoals.List();
                Console.ReadLine();
            }else if(_choice == "3"){
                SaveGoals.Save();
            }else if(_choice == "4"){
                LoadAppData.LoadtoTemp();
            }else if(_choice == "5"){
                RecordEvent.RecordMenu();
            }else if(_choice == "6"){
                _loop = false;
            }else{
                Console.WriteLine("That wasn't a valid selection, please try again...");
                System.Threading.Thread.Sleep(1000);
            }
            Console.Clear();
        }
    }
}