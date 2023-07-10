using System;

public abstract class Menu{
    private string _desc;
    private List<string> _menu; 
    private string _prompt;
    
    public Menu(string _desc, List<string> _menu, string _prompt){
        this._desc = _desc;
        this._menu = _menu;
        this._prompt = _prompt;
    }

    public virtual int Show(){
        return default;
    }

    protected bool ValidInput(){
        return default;
    }
}