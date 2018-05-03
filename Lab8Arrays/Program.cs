using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = { "Abra", "Alakazam", "Articuno", "Blastoise", "Buterfree", "Beedrill", "Bulbasaur", "Charmander", "Charmeleon", "Charizard", "Caterpie", "Diglett", "Dugtrio", "Dragonite", "Ekans", "Electrode", "Exeggcutor", "Geodude", "Slowpoke", "Zapdos" };
            string[] Country = { "Bangladesh", "Pakistan", "Sri Lanka", "India", "United States", "Mexico", "Egypt", "Yeman", "Iraq", "Iran", "Dubai", "Qatar", "Germany", "Bosnia", "Croatia", "China", "Japan", "Thailand", "Saudi Arabia", "Somalia" };
            string[] Food = { "Biryani", "Boar Ragu", "Chicken Parmesan", "Lasagna", "Doritos", "Kale", "Grass", "Glazed Donuts", "Strawberries", "Tandoori Chicken", "Romaine lettuce", "Garlic", "Apples", "Oranges", "Grapefruit", "Olives", "Lentil Soup", "Salmon", "Focaccia Bread", "Pralines and Cream - Ice Cream" };

            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to the Safari Zone, which Pokemon would you like to learn more about?\n(Enter a number from 1-20)");
                    string input = Console.ReadLine();
                    bool statement = int.TryParse(input, out int index);
                    index --;

                    Console.WriteLine($"Pokemon {input} is {Name[index]}, would you like to know {Name[index]}'s Country(C), Favorite Food(F) or both(B)?");

                    string input1 = Console.ReadLine().ToLower();
                    if (input1 == "country" || input1 == "c")
                    {
                        Console.WriteLine($"{Name[index]}'s is from {Country[index]}");
                    }
                    else if (input1 == "favorite food" || input1 == "f")
                    {
                        Console.WriteLine($"{Name[index]}'s favorate food is {Food[index]}");
                    }
                    else if (input1 == "both" || input1 == "b") 
                    {
                        Console.WriteLine($"{Name[index]}'s is from {Country[index]} and his/her favorite food is {Food[index]}");
                    }
                    while (true)
                    {
                        Console.Write("Would you like to learn about another Pokemon [Y/N]?");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                            break; // Exit the inner while-loop and continue in the outer while loop.
                        if (answer == "N")
                            return;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please try again!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input, please enter numbers from 1-20!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter numbers!");
                }
            }
        }
    }
}
