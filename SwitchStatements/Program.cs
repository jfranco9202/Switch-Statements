using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject = "Math";

            Console.WriteLine("What is you favorite school subject?");
            string userSubject = Console.ReadLine();

            switch(userSubject)
            {
                case "Math":
                    Console.WriteLine("You are correct about the subject");
                    break;
                case "Java":
                    Console.WriteLine("You are incorrect.");
                    break;
                case "English":
                    Console.WriteLine("You are incorrect");
                    break;
                case "History":
                    Console.WriteLine("You are incorrect");
                    break;
                case "Social Studies":
                    Console.WriteLine("You are incorrect");
                    break;

                default:
                    Console.WriteLine("We teach math here.");
                    break;

            }




            
        }
    }
}
