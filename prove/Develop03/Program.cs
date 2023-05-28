using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        References reference = new References();
        reference.ReferencesLoad();
        Scriptures scripture = new Scriptures();
        scripture.ScripturesLoad();
        Clip word = new Clip();

        bool loop = true;
        string new_scripture = scripture.ScripturesRandom();
        string new_reference = reference.ReferencesGet(scripture);
        word.GetScripture(scripture);
        while(loop){
            Console.Clear();
            Console.WriteLine($"{new_reference}: {new_scripture}");
            Console.WriteLine("\n\nPress ENTER to obscure text.\nEnter QUIT to exit.");
            string answer = Console.ReadLine();
            if(answer.ToLower() == "quit"){
                loop = false;
            }else{
                new_scripture = word.ClipScripture(new_scripture);
            }
        }
    }   
}