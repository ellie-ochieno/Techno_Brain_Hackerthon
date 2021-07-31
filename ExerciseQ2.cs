
/*
    Q2:
        - Defines extension methods
        - using BigInteger

*/
using System;
using System.Numerics;
        // imports the BigInteger lib
        /* A function that prints given number in words */
void readToWords(char* nummber)
{
    int len = strlen(nummber); // Get number of digits in  number
 
    /* Base cases */
    if (len == 0) {
        fprintf(stderr, "empty input\n");
        return;
    }
    //if string length is greater than 4 digits
    if (len > 4) {
        fprintf(stderr,
                "Length limited to 4 digits\n");
        return;
    }
    //handling single digits hard coded
    char* singleDgts[] = { "zero", "one", "two",   "three", "four",
            "five", "six", "seven", "eight", "nine" };
 
    //handling 2 digits length hard coded
    char* twoDgts[] = { "",          "ten",      "eleven",  "twelve",
            "thirteen",  "fourteen", "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen" };
 
    //handling 10s multiple digits length
    char* tensMultiple[] = { "",       "",        "twenty",
                              "thirty", "forty",   "fifty",
                              "sixty",  "seventy", "eighty",
                              "ninety" };
 
    char* tensPwr[] = { "hundred", "thousand" };
    //debugs through the flow
    printf("\n%s: ", nummber);
 
    /* For single digit number */
    if (len == 1) {
        printf("%s\n", singleDgts[*nummber - '0']);
        return;
    }
 
    /*while number is not '\0' */
    while (*nummber != '\0') {
 
        /*for first 2 digits */
        if (len >= 3) {
            if (*nummber - '0' != 0) {
                printf("%s ", singleDgts[*nummber - '0']);
                printf("%s ",
                       tensPwr[len - 3]); // length can be 3 or 4
            }
            --len;
        }
 
        /* Code path for last 2 digits */
        else {
            /* handles btn 10-19 */
            if (*nummber == '1') {
                int sum = *nummber - '0' + *(nummber + 1) - '0';
                printf("%s\n", twoDgts[sum]);
                return;
            }
 
            /* Need to explicitely handle 20 */
            else if (*num == '2' && *(nummber + 1) == '0') {
                printf("twenty\n");
                return;
            }
 
            /* assumes rest of the two digit numbers i.e., 21 to 99
             */
            else {
                int i = *nummber - '0';
                printf("%s ", i ? tensMultiple[i] : "");
                ++nummber;
                if (*nummber != '0')
                    printf("%s ",
                           singleDgts[*nummber - '0']);
            }
        }
        ++nummber; //pre-increment the number in the operation
    }
}
 
class ExerciseQ2
    {
        static void Main()
        {
            //prompts user for i/p and reads to a variable number
            Console.Write(" Enter a number: ");
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            readToWords(number); //calls fn handler main
        }
}