using System;

class Program
{
    static string _closing = "\nThank you for taking care of yourself.";
    static void Main(string[] args)
    {
        
        Console.Clear();

        bool loop = true;
        while(loop){
            Console.Clear();
            Console.WriteLine("Please select one of the following activities:");
            Console.WriteLine("1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit");
            string _answer = Console.ReadLine();
            if(_answer == "1"){
                var _activity = new BreathingActivity();
                _activity.RunBreathing();
                Console.WriteLine(_closing);
                loop = false;
            }else if(_answer == "2"){
                var _activity = new ReflectionActivity();
                _activity.RunReflection();
                Console.WriteLine(_closing);
                loop = false;
            }else if(_answer == "3"){
                var _activity = new ListingActivity();
                _activity.RunListing();
                Console.WriteLine(_closing);
                loop = false;
            }else if(_answer == "4"){
                loop = false;
            }else{
                Console.WriteLine("That's not a valid choice.");
            }
        }
    }
}