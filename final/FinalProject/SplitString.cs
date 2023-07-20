using System;

static class SplitString{
    static SplitString(){}

    public static string[] Split(string toSplit, char delimiter){
        string[] splitString = toSplit.Split(delimiter);
        return splitString;
    }
}