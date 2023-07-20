using System;

public class RaceMenu : Menu{

    public RaceMenu() : base
    ("Under Construction", new List<string> {
        "Exit.",
    }, "Please select an option: ", 1){}

    public virtual void RaceOption(){
        /// There will be more options here in the future, allowing the user to enter a description of their character.
    }
}
