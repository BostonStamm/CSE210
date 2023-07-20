using System;

public abstract class Menu{
    private string _desc;
    private List<string> _menu; 
    private string _prompt;
    private int _choices;
    
    public Menu(string _desc, List<string> _menu, string _prompt, int _choices){
        this._desc = _desc;
        this._menu = _menu;
        this._prompt = _prompt;
        this._choices = _choices;
    }

    public virtual int Show(){
        var result = 0;
        var loop = true;
        while(loop){
            Console.Clear();
            Console.WriteLine(_desc);
            for(int i = 0; i < _choices; i++){
                Console.WriteLine($"{i+1}: {_menu[i]}");
            }
            Console.Write(_prompt);
            try{
                result = int.Parse(Console.ReadLine());
                if(result <= _choices){
                    loop = false;
                }else{
                    Console.WriteLine($"Please enter a number between 1 and {_choices}.");
                }
            }
            catch{
                Console.WriteLine($"An integer is expected.");
            }
        }
        return result;
    }
}