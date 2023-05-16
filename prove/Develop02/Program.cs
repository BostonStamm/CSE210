using System;
class Program{
    static void Main(string[] args){
        int[] Valid_Input = {1,2,3,4,5};
        int choice = 0;
        bool loop = true;
        
        Journal journal = new Journal();
        Prompts new_prompt = new Prompts();

        while(loop){
            choice = Choices();

            if(choice == 1){
                string DaTi = Get_DaTi();
                string prompt = new_prompt.Prompts_Fetch();

                Entries entry = new Entries();
                entry.Entry_DaTi = DaTi;
                entry.Entry_Prompt = prompt;

                Console.WriteLine($"{prompt}\n");
                string answer = Console.ReadLine();
                entry.Entry = answer;

                journal.Journal_Entry.Add(entry);
                }
            else if(choice == 2){
                journal.Display();
                }
            else if(choice == 3){
                journal.Journal_Generate();
                }
            else if(choice == 4){
                journal.Journal_Load();
                }
            else if(choice == 5){
                Console.WriteLine("See you next time!");
                loop = false;
                }
            else{
                Console.WriteLine($"{choice} is not a valid input. Please try again.");
                }
            }
        }
    
    static int Choices(){
        string choices = "1: Write \n2: Display \n3: Save \n4: Load \n5: Quit \nPlease select one of the following...\n";

        Console.Write(choices);
        string answer = Console.ReadLine();
        int choice = 0;
        try{
            choice = int.Parse(answer);
        }
        catch(FormatException){
            choice = 0;
        }
        catch(Exception error){
            Console.WriteLine($"Error: {error.Message}");
        }
        return choice;
    }

    static string Get_DaTi(){
        DateTime now = DateTime.Now;
        string DaTi = now.ToString("F");
        return DaTi;
    }
}
public class Prompts {
    public static string[] Prompts_List = {
        "How was your day, on a scale of 1-10?",
        "What was something good that happened today?",
        "How did you help another person today?",
        "What was the highlight of your day?",
        "What did you accomplish today?",
        "Who did you enjoy talking to the most today?",
        "What was most fun about your day?",
        "What was something you enjoyed today?",
        "How did you see the hand of the Lord today?"
    };
    public List<string> Prompt_List = new List<string>(Prompts_List);

    public Prompts(){}

    public string Prompts_Fetch(){
        var random = new Random();
        int Prompt_Index = random.Next(Prompt_List.Count);
        string Prompt_New = Prompt_List[Prompt_Index];
        return Prompt_New;
    }
}
public class Entries{ 
    public string Entry_DaTi = ""; 
    public string Entry_Prompt = ""; 
    public string Entry = "";
    public string Journal_File = ""; 

    public Entries(){}

    public void Display(){
        Console.Write($"Date/Time: {Entry_DaTi}");
        Console.WriteLine($" - Prompt: {Entry_Prompt}");
        Console.WriteLine($"Answer: {Entry}");
    }
}
public class Journal{
    public List<Entries> Journal_Entry = new List<Entries>();
    private string filename;

    public Journal(){}

    public void Display(){
        Console.WriteLine("\n__________________Start__________________\n");
        foreach (Entries entry in Journal_Entry){
            entry.Display();
        }
        Console.WriteLine("\n___________________End___________________");
    }

    public void Journal_Generate(){
        Console.WriteLine("What is your journal called? ");
        string answer = Console.ReadLine();
        filename = answer + "jrn.txt";

        if(!File.Exists(filename)){
            File.CreateText(filename);
            Console.WriteLine($"\n * {filename} has been generated...");
            Console.WriteLine("Your entries have been recorded.");
            Journal_Append(filename);
        }else{
            bool gen_loop = true; 
            while(gen_loop){
                Console.WriteLine($"Would you like to overwrite or add to to {filename}");
                Console.WriteLine("Over / Add");
                string gen_answer = Console.ReadLine();
                if(gen_answer.ToLower() == "over"){
                    Console.WriteLine("Your entries have been recorded to your journal.");
                    Journal_Save(filename);
                }
                else if(gen_answer.ToLower() == "add"){
                    Console.WriteLine("Your entries have been recorded to your journal.");
                    Journal_Append(filename);
                }else{
                    Console.WriteLine("That is not a valid input, please try again.");
                }
            }
        }
    }

    public void Journal_Append(string filename){
        using (StreamWriter Save_File = new StreamWriter(filename, append: true)){
            foreach (Entries entry in Journal_Entry){
                Save_File.WriteLine($"{entry.Entry_DaTi}; {entry.Entry_Prompt}; {entry.Entry}");
            }
        }
    }

    public void Journal_Save(string filename){
        using (StreamWriter Save_File = new StreamWriter(filename)){
            foreach (Entries entry in Journal_Entry){
                Save_File.WriteLine($"{entry.Entry_DaTi}; {entry.Entry_Prompt}; {entry.Entry}");
            }
        }
    }

    public void Journal_Load(){
        Console.WriteLine("What is your journal called? ");
        string answer = Console.ReadLine();
        filename = answer + "jrn.txt";

        if(File.Exists(filename)){
            List<string> Loaded_Text = File.ReadAllLines(filename).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach(string row in Loaded_Text){
                string[] Split_Text = row.Split("; ");

                Entries entry = new Entries();

                entry.Entry_DaTi = Split_Text[0];
                entry.Entry_Prompt = Split_Text[1];
                entry.Entry = Split_Text[2];

                Journal_Entry.Add(entry);
            }
        }
    }
}