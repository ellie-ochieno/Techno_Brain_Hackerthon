
/*
    Q1. Regular expression
        Prompts user for:
            - regular expression
            - some i/p
            - compare the 2 until press Esc key

*/
using System;
using System.Text.RegularExpressions;
    //impotrs support libs
class RegEpressionHandler {
     
    // Main Method
    public static void Main(string[] args)
    {
        // regular exp pattern dfn b, ab, aab, ...
        Regex regex = new Regex(@"a*b");
        string checkFlag = "y";

            while(checkFlag == "y" || checkFlag == "Y")
            {
               //prompt for user i/p for regex
                Console.Write("Enter a regular expression: ");
                string usrInputRegex = Console.ReadLine();
                Regex regex = new Regex(usrInputRegex);

                //user i/p for val to compare to regex
                Console.Write("Enter an expression to compare: ");
                string usrInputExpre = Console.ReadLine();

                //compares the input to regex
                Match match = regex.Match(usrInputExpre);

                //print result
                if(match == true)
                {
                    Console.WriteLine("Match, correct!");
                }
                else{
                    Console.WriteLine("Match, incorrect!");
                }

                //prompt for new i/p 
                Console.WriteLine("Do you want to continue?(y/n)");
                string usrChoice = Console.ReadLine();
                if(usrChoice == "y" || usrChoice == "Y")
                {
                    Console.Write("Enter another expression to compare: ");
                    string usrInputExpre = Console.ReadLine();
                    //reloads the program afresh with new value to compare
                }
                else{
                    checkFlag = "n";
                    Console.Write("Program exiting...");
                    //change check flag and exit the program
                }

            }
 
    }
}