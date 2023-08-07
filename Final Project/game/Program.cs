using System;
using System.Collections.Generic;
using System.Linq;


namespace game;
class game
{
    static void Main(string[] args)
    {
        int descision = 0;
        do
        {
            Console.WriteLine("So let's choose the level first");
            Console.WriteLine("'Make sure to choose it based on the type builder you are!'");
            Console.WriteLine("(Normal => if you never built anything in life and don't have knowledge of Money Management )");
            Console.WriteLine("(Mediocre => if you have built something in life and have little knowledge of Money Management )");
            Console.WriteLine("(Specialist => if you have built many things in life and have good knowledge of Money Management )");
            Console.WriteLine("Select your builder level:");
            Console.WriteLine("1. Normal builder");
            Console.WriteLine("2. Mediocre builder");
            Console.WriteLine("3. Specialist builder");
            Console.Write("Enter your level of choice:");
            int level = int.Parse(Console.ReadLine());
            if (level == 1)
            {
                normal();
            }
            else if (level == 2)
            {
                mediocre();
            }
            else if (level == 3)
            {
                specialist();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            // Console.WriteLine("Do you want to play again?");
            // Console.WriteLine("1. Yes");
            // Console.WriteLine("2. No");
            // descision = int.Parse(Console.ReadLine());

        } while (descision == 1);
    }

    //methods for all the levels

    // Normal level method
    static void normal()
    {
        Console.WriteLine("OK, Let's Start!");
        Console.WriteLine("Since you are a normal builder so you have given item choices:");
        string[] items = { "1. Chair", "2. Bed", "3. Table", "4. Dog House" };
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
        Console.Write("Select the item you want to build:");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("You have decided to build the chair");
                int Chair_Money = 200;
                Console.WriteLine($"so you will be given only ${Chair_Money}");
                Console.WriteLine("You have to build the chair with the given money only.");
                string[,] choice_sets = new string[4, 3]
                {
                    { "Wooden Block of 15 feet - $65", "wooden block of 20 feet - $75", "wooden block of 30 feet - $90" },
                    { "screw driver - $25", "Screws - $10", "Both - $30" },
                    { "Support Beam - $50", "Special Cutter - $30", "Axe - $25" },
                    {"Wood Stain - $50", "Paint Brush - $5", "Both - $45"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int chairindex = 0;
                while(chairindex < 4){
                    for (int j = 0; j < choice_sets.GetLength(1); j++) 
                    { 
                        Console.WriteLine(choice_sets[chairindex, j]);
                    }
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount_spent = int.Parse(Console.ReadLine());
                    Chair_Money = Chair_Money - amount_spent;
                    chairindex++;
                }
                Console.WriteLine($"You have ${Chair_Money} left");
                break;
            
            case 2:
                Console.WriteLine("You have decided to build the bed");
                int bedMoney = 350;
                Console.WriteLine($"So you will be given only ${bedMoney}");
                Console.WriteLine("You have to build the bed with the given money only.");
                string[,] choice_sets2 = new string[4, 3]
                {
                    { "Wooden Block of 20 feet - $80", "Wooden block of 30 feet - $100", "Wooden block of 40 feet - $120" },
                    { "Screws - $15", "Nails - $10", "Both - $20" },
                    { "Hammer - $20", "Saw - $25", "Electric Drill - $50" },
                    {"Mattress - $200", "Bedsheet - $40", "Both - $220"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int k = 0;
                while(k < 4){
                    for (int j = 0; j < choice_sets2.GetLength(1); j++) 
                    { 
                        Console.WriteLine(choice_sets2[k, j]);
                    }
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount = int.Parse(Console.ReadLine());
                    bedMoney = bedMoney - amount;
                    k++;
                }
                Console.WriteLine($"You have ${bedMoney} left");
                break;
            case 3:
                Console.WriteLine("You have decided to build the table");
                int tableBudget = 450;
                Console.WriteLine($"So you will be given only ${tableBudget}");
                Console.WriteLine("You have to build the table with the given money only.");
                string[,] tableChoiceSets = new string[4, 3]
                {
                    { "Wooden Block of 30 feet - $100", "Wooden block of 40 feet - $120", "Wooden block of 50 feet - $150" },
                    { "Nails - $10", "Wood Screws - $15", "Both - $20" },
                    { "Chisel - $30", "Jigsaw - $40", "Table Saw - $60" },
                    {"Varnish - $80", "Stain - $50", "Both - $120"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int tableChoiceIndex = 0;
                while (tableChoiceIndex < 4)
                {
                    for (int j = 0; j < tableChoiceSets.GetLength(1); j++)
                    {
                        Console.WriteLine(tableChoiceSets[tableChoiceIndex, j]);
                    }
                    Console.Write("Enter the amount you want to take in this list (just enter the amount in front of it): ");
                    int amount = int.Parse(Console.ReadLine());
                    tableBudget -= amount;
                    tableChoiceIndex++;
                }
                Console.WriteLine($"You have ${tableBudget} left");
                break;
            case 4:
                Console.WriteLine("You have decided to build the dog house");
                int dogHouseBudget = 300;
                Console.WriteLine($"So you will be given only ${dogHouseBudget}");
                Console.WriteLine("You have to build the dog house with the given money only.");
                string[,] dogHouseItems = new string[4, 3]
                {
                    { "Roofing material - $75", "Wooden block of 20 feet - $80", "Wooden block of 30 feet - $110" },
                    { "Screws - $10", "Nails - $5", "Both - $12" },
                    { "Support Beam - $50", "Hacksaw - $35", "Axe - $25" },
                    { "Wood Stain - $50", "Paint Brush - $5", "Both - $45" }
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int doghouseindex = 0;
                while (doghouseindex < 4)
                {
                    for (int j = 0; j < dogHouseItems.GetLength(1); j++)
                    {
                        Console.WriteLine(dogHouseItems[doghouseindex, j]);
                    }
                    Console.Write("Enter the amount you want to take in this list (just enter the amount in front of it): ");
                    int amount = int.Parse(Console.ReadLine());
                    dogHouseBudget -= amount;
                    doghouseindex++;
                }
                Console.WriteLine($"You have ${dogHouseBudget} left");
                break;
                
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    // Mediocre level method
    static void mediocre()
    {
        
    }

    // Specialist level method
    static void specialist()
    {

    }

}