using System;

public class DisplayMenu : Menu{

    public DisplayMenu() : base
    ("Display Menu", new List<string> {
        "Display Raw Data",
    }, "Please select an option:"){}
}
