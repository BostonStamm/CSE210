using System;

public class BaseIO{

    protected string _cache = "Cache.csv";
    protected string _appData = "AppData.csv";
    protected string _dataReturn;

    public BaseIO(){}

    public string[] GetDirectory(){
        return default;
    }

    public string[] LoadFile(string fileName){
        return default;
    }

    public void SaveFile(string fileName, string[] saveData){

    }

    public bool CheckForFile(string filename){
        return default;
    }
}