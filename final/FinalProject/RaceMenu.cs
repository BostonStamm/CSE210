using System;

public class RaceMenu : Menu{

    public RaceMenu() : base
    ("Race Menu", new List<string> {
        "abcd",
        "defg",
    }, "Please select an option."){}

    public virtual void RaceOption(){
        /// There will be more options here in the future, allowing the user to enter a description of their character.
    }
}
