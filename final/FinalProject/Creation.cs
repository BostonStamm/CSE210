using System;

public class Creation{
    protected List<string> _rawData = new List<string> {};
    private string _userName;
    private string _name;
    private int _level;
    private string _race;
    private string _class;
    private List<int> _scores;
    private List<string> _skills;
    private List<string> _inventory;
    private List<int> _slots;
    private int _profBonus;
    private List<string> _modifiers = new List<string> { "", 
                                                           "", 
                                                           "",
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           "", 
                                                           ""};
    public Creation(){}

    public void CharacterCreator(){
        var loop = true;
        Console.Clear();
        Console.WriteLine("Please enter you, the user's, name or pseudonym: ");
        string _userName = Console.ReadLine();
        Console.WriteLine("Now, please enter a name for the character you will be creating: ");
        string _name = Console.ReadLine();
        while(loop){
            Console.WriteLine("Now, please enter the level of your character.");
            Console.WriteLine("The level must be between 1 and 20: ");
            try{
                _level = int.Parse(Console.ReadLine());
                if(_level >= 1 && _level <= 20){
                    loop = false;
                }
            }
            catch{
                Console.WriteLine($"An integer is expected.");
            }
        }
        _rawData.Add($"user_name,{_userName}");
        _rawData.Add($"character_name,{_name}");
        _rawData.Add($"character_level,{_level}");
        BaseIO.SaveFile($"{_name}.sav", _rawData);
        AppData.SaveAppData($"{_name}.sav");
    }

    private List<int> CalculateAbilityScores(List<int> scores, string race, List<int> classFeats, List<string> otherFeats, List<string> modifiers){
        return default;
    }

    private int CalculateMaxHitPoints(int level, string race, string uClass, int constitution, List<string> otherFeats, List<string> modifiers){
        return default;
    }

    private int FindProfBonus(int level, List<string> otherFeats){
        return default;
    }

    private int CalculateArmorClass(string race, string uClass, int dexterity, string armor, string offHand, List<string> otherFeats, List<string> modifiers){
        return default;
    }

    private List<string> GetSkillProficiencies(string uClass){
        return default;
    }

    private List<string> BuildInventory(string uClass){
        return default;
    }

    private List<int> FindSpecialSlots(string uClass, int level){
        return default;
    }
}