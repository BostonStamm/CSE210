using System;
public class SaveLoad{
    public static string _temp = "tempfile.csv";
    public static string _appdata = "AppData.txt";
    public static string[] GetDirectory(){
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
        return files;
    }
    public string[] LoadFile(string file){
        string[] lines = System.IO.File.ReadAllLines(file);
        return lines;
    }
    public static (List<string>,int) LoadSaves(){
        var files = GetDirectory();
        var count = 1;
        List<string> _saves = new List<string>();
        foreach(string file in files){
            string[] parts = file.Split(".");
            if(parts[1] == "goals"){
                Console.WriteLine($" {count}: {Path.GetFileName(parts[0])}");
                count += 1;
                _saves.Add(Path.GetFileName(file));
            }
        }
        return (_saves,count);
    }
    public static void SaveNewFile(){
        Console.WriteLine("Please enter a name for your new save: ");
        var _choice = Console.ReadLine();
        var _overwrite = System.IO.File.ReadAllLines(_temp);
        System.IO.File.WriteAllLines($"{_choice}.goals.csv", _overwrite);
        SaveAppData.Save($"{_choice}.goals.csv");
    }
}

public class SaveAppData : SaveLoad{
    public static void Save(string userfile){
        string[] repline = File.ReadAllLines(_appdata);
        repline[0] = $"previous_file,{userfile}";
        File.WriteAllLines(_appdata, repline);
    }
}

public class LoadAppData : SaveLoad{

    public string CheckForFile(){
        var _loop = true;
        var latestfile = "";
        while(_loop){
            var lines = LoadFile(_appdata);
            foreach(string line in lines){ 
                string[] parts = line.Split(",");
                if(parts[0] == "previous_file"){
                    latestfile = parts[1];
                }
            }
            Console.WriteLine(latestfile);
            if(String.IsNullOrWhiteSpace(latestfile)){
                Console.WriteLine("You don't have an active save, please create one.");
                SaveNewFile();
            }else{
            _loop = false;
            }
        }
        return latestfile;
    }
    public string GetLatestScore(){
        var _score = "";
        var lines = LoadFile(_temp);
        foreach(string line in lines){
            string[] parts = line.Split(",");

            if(parts[0] == "Score"){
                _score = parts[1];
            }
        }
        if(string.IsNullOrWhiteSpace(_score)){
            _score = "0";
        }
        return _score;
    }
    public static void LoadtoTemp(){
        var _loop = true;
        var _filename = "";
        while(_loop){
            (List<string> _saves, var count) = LoadSaves();
            Console.WriteLine("Please select a file to load: ");
            var _choice = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(_choice) && int.Parse(_choice) <= _saves.Count && !String.IsNullOrWhiteSpace(_choice) && int.Parse(_choice) -1 >= 0){
                _filename = _saves[int.Parse(_choice) -1];
                _loop = false;
                SaveAppData.Save(_filename);
            }else{
                Console.WriteLine("That wasn't a valid selection, please try again...");
                System.Threading.Thread.Sleep(1000);
            }
        }
        var _file = System.IO.File.ReadAllLines(_filename);
        System.IO.File.WriteAllLines(_temp, _file);
    }
}

public class SaveGoals : SaveLoad{
    public static void Save(){
        var _loop = true;
        while(_loop){
            Console.WriteLine("Please select a file to save to: ");
            (List<string> _saves, var count) = LoadSaves();
            
            Console.WriteLine($" {count}: New File");
            var _choice = Console.ReadLine();
            if(!String.IsNullOrWhiteSpace(_choice) && int.Parse(_choice) <= _saves.Count && !String.IsNullOrWhiteSpace(_choice) && int.Parse(_choice) -1 >= 0){
                var _overwrite = System.IO.File.ReadAllLines(_temp);
                System.IO.File.WriteAllLines(_saves[int.Parse(_choice) -1], _overwrite);
                SaveAppData.Save(_saves[int.Parse(_choice) -1]);
                _loop = false;
            }else if(!String.IsNullOrWhiteSpace(_choice) && int.Parse(_choice) == count){
                SaveNewFile();
                _loop = false;
            }else{
                Console.WriteLine("That wasn't a valid selection, please try again...");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }  
    
    public static void AppendtoTemp(string _goal){
        System.IO.File.AppendAllText(_temp, $"\n{_goal}");
    }
}
