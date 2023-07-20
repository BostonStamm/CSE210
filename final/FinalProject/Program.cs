using System;

class Program
{
    static void Main(string[] args)
    {
        MainMenu mainMenu = new MainMenu();
        int input = 0;

        var loop = true;
        while(loop){
            string fileName = MetaData.LoadMetaData(GlobalReferences.___appData___, "previous_file", true, 1);
            Console.WriteLine();

            input = mainMenu.Show();

            switch(input){
                case 1:
                    // Create
                    Creation creation = new Creation();
                    creation.CharacterCreator();
                    break;
                case 2:
                    // Display
                    DisplayMenu displayMenu = new DisplayMenu();
                    input = displayMenu.Show();
                        switch(input){
                            case 1:
                                // Display Raw
                                if(!string.IsNullOrWhiteSpace(fileName)){
                                    Console.WriteLine();
                                    BaseIO.ShowRaw(fileName);
                                }else{
                                    Console.WriteLine("No file could be found. Please create or load a character before reading.");
                                }
                                Console.WriteLine("Press Enter to continue.");
                                Console.ReadLine();
                                break;
                            case 2:
                                break;
                        
                    }
                    break;
                case 3:
                    // Save
                    SaveMenu saveMenu = new SaveMenu();
                    saveMenu.Show();
                    break;
                case 4:
                    // Load
                    LoadMenu loadMenu = new LoadMenu();
                    loadMenu.Show();
                    break;
                case 5:
                    // Quit
                    loop = false;
                    break;
            }
        }
    }
}