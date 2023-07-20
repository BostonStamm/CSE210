using System;

public class MainMenu : Menu{

    public MainMenu() : base
    ("Main Menu", new List<string> {
        "Create a Character",
        "Display Loaded Character",
        "Save",
        "Load",
        "Quit",
    }, "Please select an option: ", 5){}
}
