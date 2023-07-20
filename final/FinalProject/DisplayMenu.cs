using System;

public class DisplayMenu : Menu{

    public DisplayMenu() : base
    ("Display Menu", new List<string> {
        "Display Raw Data",
        "Quit",
    }, "Please select an option: ", 2){}
}
