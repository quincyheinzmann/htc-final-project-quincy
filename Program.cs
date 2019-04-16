using System;

namespace htc_final_project_quincy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*REQUIREMENTS
            Use at least one conditional statement
            Use a loop! Can be for, foreach or while. Up to you!
            Use at least one method, show us you understand how to use them
            If your project would benefit from a List, use one!*/
            Console.WriteLine("Welcome to this MadLibs game!");
            Console.WriteLine("Give me a noun.");
            string word1 = Console.ReadLine();
            Console.WriteLine("Give me an adjective.");
            string word2 = Console.ReadLine();
            Console.WriteLine("Give me a verb.");
            string word3 = Console.ReadLine();
            Console.WriteLine("Give me a noun.");
            string word4 = Console.ReadLine();
            Console.WriteLine("Give me a name.");
            string word5 = Console.ReadLine();
            Console.WriteLine("Give me a setting.");
            string word6 = Console.ReadLine();
            Console.WriteLine("Give me a positive integer.");
            int word7 = Convert.ToInt32(Console.ReadLine());
            if (word7 > 9999) {
                Console.WriteLine("WOW! THAT'S A HIGH NUMBER! LET'S TRY A LOWER NUMBER!");
            }
            Console.WriteLine("Once, there was a very ugly " + word1 + ". The " + word1 + " was very " + word2 + ". Because of all of its problems, it was completely friendless. One day, it decided to " + word3 + " off a cliff. The " + word4 + " was that there were no cliffs nearby. So, it went on a mission. " + word5 + " decided to head for the " + word6 + ". In the end " + word5 + " gave up and lived in a tree. Finally, " + word5 + " died of loneliness at age " + word7 + ".");
        }
    }
}