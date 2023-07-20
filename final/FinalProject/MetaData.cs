using System;

public class MetaData : BaseIO{
    public static string LoadMetaData(string category, string search = "", bool item = false, int index = 0){
        var dataReturn = "";
        string[] lines = BaseIO.LoadFile(category);
        foreach(string line in lines){
            string[] items = SplitString.Split(line, ',');
            if(items[0] == search){
                if(item == true){
                    dataReturn = items[index];
                }else{
                    dataReturn = String.Join(',', items);
                }
            }
        }
        if(!string.IsNullOrWhiteSpace(dataReturn)){
            return dataReturn;
        }else{
            return "";
        }
    }
}