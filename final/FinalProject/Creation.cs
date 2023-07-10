using System;

public class Creation{

    protected string _userName;
    protected string _name;
    protected int _level;
    protected string[] _race;
    protected string _class;
    protected List<int> _scores;
    protected List<string> _skills;
    protected List<string> _inventory;
    protected List<int> _slots;
    protected int _profBonus;
    protected List<string> _modifiers = new List<string> { "", 
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