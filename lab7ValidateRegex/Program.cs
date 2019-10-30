using System;
using System.Text.RegularExpressions;
namespace lab7ValidateRegex
{
    class Program
        
    {
        static void Main(string[] args)
        {
            string nameAns, emailAns, phoneAns, dateAns, startOver;
            
            Regex name = new Regex(@"^[A-Z]{1}[a-z]{1,29}[\s][A-Z]{1}[a-z]{1,29}$");
            Regex email = new Regex(@"^[A-Za-z0-9]{5,30}@{1}[A-Za-z0-9]{5,10}\.{1}[A-Za-z0-9]{2,3}$");
            Regex phone = new Regex(@"[0-9]{3}-{1}[0-9]{3}-{1}[0-9]{4}$");
            Regex date = new Regex(@"^([0]{1}[1-9]{1}|[1]{1}[0-9]{1}|[2]{1}[0-9]{1}|[3]{1}[0-1]{1})[/]{1}(0{1}[1-9]|1[012])[/]{1}(\d\d\d\d)$");
            //use of Regex sys to validate user entry , syntax patterns etc

            //prompt user for valid name, if not valid, will keep prompting until entry is good
            //must be Capital first letter first name, space, and Capital first letter last name

            
            do
            {
                do
                {
                    Console.WriteLine("Hi! What's your name?");
                    //(^[A-Za-z0-9]{5,30}@{1}[A-Aa-z0-9]{5,10}+\.{1}[A-Za-z0-9]{3,5}$)....this is email regex
                    //(^[A-Z]{1}[a-z]{1,29}[\s][A-Z]{1}[a-z]{1,29})  this is the valid name regex
                    //([0-9]{3}-{1}[0-9]{3}-{1}[0-9]{4})  this is the phone valid regex
                                                            
                    nameAns = Console.ReadLine();

                    if (name.Match(nameAns).Success == false)

                    {
                        Console.WriteLine("\nSorry, that's not valid, please try again.");
                        Console.WriteLine("Hint: Try Fname Lname format.");
                    }
                }
                while (name.Match(nameAns).Success == false);

                Console.WriteLine("\nName is valid! Thank you");
                //prompt user for valid entry of email (proper chars and @ followed by . and 2,3 char)
                //if not, will keep prompting for proper entry

                do
                {
                    Console.WriteLine("\nSo, " + nameAns + " what's your email?");
                    emailAns = Console.ReadLine();

                    if (email.Match(emailAns).Success == false)
                    {
                        Console.WriteLine("\nSorry, that's not valid, please try again.");
                        Console.WriteLine("Hint: Try alphanumeric@alphanumeric.com format or similar");
                    }
                }
                while (email.Match(emailAns).Success == false);
                Console.WriteLine("\nEmail is valid! Thank you");
                //prompt user for valid entry of ph# 3 dig followed by - 3 dig followed by - and 4 dig
                //if not keep prompting til correct entry rcvd
                do
                {
                    Console.WriteLine("\nSo, " + nameAns + " can I get your phone number? ###-###-####");
                    phoneAns = (Console.ReadLine());
                    if (phone.Match(phoneAns).Success == false)
                    {
                        Console.WriteLine("\nSorry, that's not valid, please try again.");
                        Console.WriteLine("Hint: I showed you how already.");
                    }
                }
                while (phone.Match(phoneAns).Success == false);
                Console.WriteLine("\nPhone number is valid! Thank you");

                //prompt user for valid date entry as mm/dd/yyy
                //if not , keep prompting til valid entry is rcvd
                do
                {
                    Console.WriteLine("\nAnd finally, " + nameAns + " I'd like to validate a date for you ");
                    dateAns = Console.ReadLine();
                    if (date.Match(dateAns).Success == false)
                    {
                        Console.WriteLine("\nSorry that's not valid, try again");
                        Console.WriteLine("Hint: must be dd/mm/yyyy format only.");
                    }
                }
                while (date.Match(dateAns).Success == false);
                Console.WriteLine("\nDate is valid! Thank you.");

                //this will prompt user if to start again, must be y or n response
                do
                {
                    Console.WriteLine("\nShall we start over? 'y' or 'n'");
                    startOver = Console.ReadLine().ToLower();
                    if (startOver != "n" && startOver != "y")
                    {
                        Console.WriteLine("\nOops, try again, 'y' or 'n'");
                    }
                    if (startOver == "n")
                    {
                        Console.WriteLine("\nOk, Ciao, adios, buh bye!");
                    }
                }

                while (startOver != "n" && startOver != "y");
            }
            while (startOver == "y");
        }


    }
}

