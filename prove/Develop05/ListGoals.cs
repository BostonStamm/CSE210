using System;
public class ListGoals{
    private static int ___type___ = 0;
    private static int ___completed___ = 1;
    private static int ___name___ = 2;
    private static int ___desc___ = 3;
    private static int ___points___ = 4;
    private static int ___checkgoal___ = 5;
    private static int ___checkcurrent___ = 6;
    public static void List(){
        var count = 0;
        SaveLoad _run = new SaveLoad();
        var lines = _run.LoadFile("tempfile.csv");
        Console.Clear();
        Console.WriteLine("\nGoals: ");
        foreach(string line in lines){
            string[] parts = line.Split(",");
            if(parts[___type___] == "simplegoal"){
                count += 1;
                Console.Write("Simple: ");
                Console.WriteLine($"{count}     [{parts[___completed___]}] {parts[___name___]}: {parts[___desc___]} (+{parts[___points___]})");
            }else if(parts[___type___] == "eternalgoal"){
                count += 1;
                Console.Write("Eternal: ");
                Console.WriteLine($"{count}    [{parts[___completed___]}] {parts[___name___]}: {parts[___desc___]} (+{parts[___points___]})");
            }else if(parts[___type___] == "checklistgoal"){
                count += 1;
                Console.Write("Checklist: ");
                Console.WriteLine($"{count}  [{parts[___completed___]}] {parts[___name___]}: {parts[___desc___]} [{parts[___checkcurrent___]}/{parts[___checkgoal___]}] (+{parts[___points___]})");
            }else if(parts[___type___] == "negativegoal"){
                count += 1;
                Console.Write("Demerit: ");
                Console.WriteLine($"{count}        {parts[___name___]}: {parts[___desc___]} (-{parts[___points___]})");
            }
        }
    }
}