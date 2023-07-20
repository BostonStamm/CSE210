using System;

public class AppData : BaseIO{

    public AppData(){}

    public static void SaveAppData(string newfile){
        var index = 0;
        string[] appData = LoadFile(GlobalReferences.___appData___);
        foreach(string line in appData){
            string[] split = SplitString.Split(line, ',');
            if(split[0] == "previous_file"){
                split[1] = newfile;
            }
            appData[index] = string.Join(',',split);
            index += 1;
        }
        File.WriteAllLines(GlobalReferences.___appData___, appData);
    }

    public static void ToCache(List<string> saveData){
        System.IO.File.WriteAllLines(GlobalReferences.___cache___, saveData);
    }

    public string[] LoadCache(string fileName){
        return default;
    }
}