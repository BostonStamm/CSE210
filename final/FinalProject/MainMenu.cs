using System;

public class MainMenu : Menu{

    public MainMenu() : base
    ("Main Menu", new List<string> {
        "Display a Character",
        "Save",
        "Load",
    }, "Please select an option"){}
}
