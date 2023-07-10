using System;

public class BuildCharacter{
    private string _name;
	private int _level;
	private string _race;
	private string _class;
	private int _HPMax;
	private int _HPNow;
	private int _AC;
	private int _initiative;
	private int _profBonus;
	private int _spMod;
	private int _spDC;
	private int _EXP;
	private int _hitDice;
	private List<int> _saves;
	private List<int> _scores;
	private List<string> _skills;
	private List<int> _movement;
	private List<string> _proficiencies;
	private List<string> _classFeats;
	private List<string> _otherFeats;
	private List<string> _traits;
	private List<string> _RIV;
	private int _weight;
	private int _carry;
	private List<string> _weapons;
	private List<string> _armors;
	private List<string> _munitions;
	private List<string> _consumables;
	private List<string> _otherItems;
	private List<int> _currencies;
	private string _armorEQ;
	private string _mainHand;
	private string _offHand;
	private List<string> _specials;
	private List<int> _spslots; 
    public BuildCharacter(){}

    public List<string> CharacterInfo(string _userName, string _name, int _level, string[] _race, string _class, 
    List<int> _scores, List<string> _skills, List<string> _inventory, List<int> _slots, int _profBonus, List<string> _modifiers){
        return default;
    }
}