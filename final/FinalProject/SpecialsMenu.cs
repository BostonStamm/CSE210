using System;

public class SpecialsMenu : Menu{

    public SpecialsMenu() : base
    ("Special Actions", new List<string> {
        "abcd",
        "defg",
    }, "Please select an option."){}
}
