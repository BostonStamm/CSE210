using System;

public class BaseIO{
    static BaseIO(){}

    public static string[] GetDirectory(){
        return default;
    }

    public static string[] LoadFile(string fileName){
        string[] lines = System.IO.File.ReadAllLines(fileName);
        return lines;
    }

    public static void ShowRaw(string fileName){
        string[] rawData = BaseIO.LoadFile(fileName);
        foreach(string line in rawData){
            Console.WriteLine(line);
        }
    } 

    public static void SaveFile(string fileName, List<string> saveData){
        System.IO.File.WriteAllLines(fileName, saveData);
    }

    public static bool CheckForFile(string filename){
        return default;
    }
}