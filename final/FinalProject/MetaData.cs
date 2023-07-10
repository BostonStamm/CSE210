using System;

public class MetaData : BaseIO{
    private string[] _metaData;

    public MetaData(string fileName){
        _metaData = LoadFile(fileName);
    }

    public string[] LoadMetaData(string category, string search = "", bool item = false, int index = 0){
        return default;
    }
}