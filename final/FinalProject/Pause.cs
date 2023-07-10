using System;

public static class Pause{
    static Pause(){}

    static void WaitFor(int seconds){
        System.Threading.Thread.Sleep(seconds * 1000);
    }
}