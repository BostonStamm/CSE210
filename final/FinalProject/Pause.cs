using System;

public class Pause{
    static Pause(){}

    public static void WaitFor(int seconds){
        System.Threading.Thread.Sleep(seconds * 1000);
    }
}