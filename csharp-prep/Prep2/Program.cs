using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string Grade = Console.ReadLine();
        int GradeInt = int.Parse(Grade);

        string LetterGrade;

        if(GradeInt >= 90){
            LetterGrade = "A";
        }else if(GradeInt >= 80){
            LetterGrade = "B";
        }else if(GradeInt >= 70){
            LetterGrade = "C";
        }else if(GradeInt >= 60){
            LetterGrade = "D";
        }else{
            LetterGrade = "F";
        }

        if(GradeInt >= 60 && GradeInt < 93){
            Int32 LastDigit = GradeInt % 10;
            if(LastDigit >= 7 && LastDigit != 0){
                LetterGrade = ($"{LetterGrade}+");
            }else if(LastDigit < 3 && LastDigit != 0){
                LetterGrade = ($"{LetterGrade}-");
            }
        }

        Console.WriteLine($"Your grade is: {GradeInt}({LetterGrade})");

        if(GradeInt >= 70){
            Console.Write("You Passed!");
        }else{
            Console.Write("You didn't pass. Don't get discouraged, and try again!");
        }
    }
}