namespace program_execution;
class Game
{
    public void start()
    {
        int descision = 0;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("So let's choose the level first");
            Console.WriteLine("");
            Console.WriteLine("'Make sure to choose it based on the type builder you are!'");
            Console.WriteLine("");
            Console.WriteLine("(Normal => if you never built anything in life and don't have knowledge of Money Management )");
            Console.WriteLine("(Mediocre => if you have built something in life and have little knowledge of Money Management )");
            Console.WriteLine("(Specialist => if you have built many things in life and have good knowledge of Money Management )");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Select your builder level:");
            Console.WriteLine("1. Normal builder");
            Console.WriteLine("2. Mediocre builder");
            Console.WriteLine("3. Specialist builder");
            Console.WriteLine("");
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
             Console.WriteLine("Do you want to play again?");
             Console.WriteLine("1. Yes");
             Console.WriteLine("2. No");
             descision = int.Parse(Console.ReadLine());

        } while (descision == 1);
    }

    //methods for all the levels

    // Normal level method
    public void normal()
    {
        Console.WriteLine("");
        Console.WriteLine("OK, Let's Start!");
        Console.WriteLine("");
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
                Console.WriteLine("");
                Console.WriteLine($"so you will be given only ${Chair_Money}");
                Console.WriteLine("You have to build the chair with the given money only.");
                string[,] choice_sets = new string[4, 3]
                {
                    { "Wooden Block of 15 feet - $65", "wooden block of 20 feet - $75", "wooden block of 30 feet - $90" },
                    { "screw driver - $25", "Screws - $10", "Both - $30" },
                    { "Support Beam - $50", "Special Cutter - $30", "Axe - $25" },
                    {"Wood Stain - $50", "Paint Brush - $5", "Both - $45"}
                };
                Console.WriteLine("");
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("");
                Console.WriteLine("And just enter the amount in front of it");
                int chairindex = 0;
                while(chairindex < 4){
                    for (int j = 0; j < choice_sets.GetLength(1); j++) 
                    { 
                        Console.WriteLine(choice_sets[chairindex, j]);
                    }
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount_spent = int.Parse(Console.ReadLine());
                    Chair_Money = Chair_Money - amount_spent;
                    chairindex++;
                }
                if(Chair_Money>0){
                    Console.WriteLine($"You have ${Chair_Money} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the Chair!");
                    Console.WriteLine("You Win");
                }
                else if(Chair_Money<0){
                    Console.WriteLine($"You have exceeded the budget by ${-Chair_Money}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the chair");
                    Console.WriteLine("You Lose");

                }
                else{
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the Chair!");
                    Console.WriteLine("You Win");
                }
                break;
            
            case 2:
                Console.WriteLine("You have decided to build the bed");
                Console.WriteLine("");
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
                Console.WriteLine("");
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("");
                Console.WriteLine("And just enter the amount in front of it");
                int k = 0;
                while(k < 4){
                    for (int j = 0; j < choice_sets2.GetLength(1); j++) 
                    { 
                        Console.WriteLine(choice_sets2[k, j]);
                    }
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount = int.Parse(Console.ReadLine());
                    bedMoney = bedMoney - amount;
                    k++;
                }
                if(bedMoney>0){
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${bedMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the bed!");
                    Console.WriteLine("You Win");
                }
                else if(bedMoney<0){
                    Console.WriteLine("");
                    Console.WriteLine("You have no money left");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the bed");
                    Console.WriteLine("You Lose");
                }
                else{
                    Console.WriteLine("");
                    Console.WriteLine("You have no money left");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the bed!");
                    Console.WriteLine("So you still Win");
                }
                break;
            case 3:
                Console.WriteLine("You have decided to build the table");
                Console.WriteLine("");
                int tableBudget = 450;
                Console.WriteLine($"So you will be given only ${tableBudget}");
                Console.WriteLine("You have to build the table with the given money only.");
                Console.WriteLine("");
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
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list (just enter the amount in front of it): ");
                    int amount = int.Parse(Console.ReadLine());
                    tableBudget -= amount;
                    tableChoiceIndex++;
                }
                if (tableBudget > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${tableBudget} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the table!");
                    Console.WriteLine("You Win");
                }
                else if (tableBudget < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-tableBudget}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the table");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the table!");
                    Console.WriteLine("You Win");
                }
                break;
            case 4:
                Console.WriteLine("You have decided to build the dog house");
                Console.WriteLine("");
                int dogHouseBudget = 300;
                Console.WriteLine($"So you will be given only ${dogHouseBudget}");
                Console.WriteLine("You have to build the dog house with the given money only.");
                Console.WriteLine("");
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
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list (just enter the amount in front of it): ");
                    int amount = int.Parse(Console.ReadLine());
                    dogHouseBudget -= amount;
                    doghouseindex++;
                }
                if (dogHouseBudget > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${dogHouseBudget} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the dog house!");
                    Console.WriteLine("You Win");
                }
                else if (dogHouseBudget < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-dogHouseBudget}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the dog house");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the dog house!");
                    Console.WriteLine("You Win");
                }
                break;
                
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    // Mediocre level method
    public void mediocre()
    {
        Console.WriteLine("OK, Let's Start!");
        Console.WriteLine("Since you are a mediocre builder so you have given item choices:");
        string[] items = { "1. Sofa", "2. Bookshelf", "3. Cupboard", "4. Study Table" };
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");
        Console.Write("Select the item you want to build:");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("You have decided to build the sofa");
                Console.WriteLine("");
                int sofaMoney = 500;
                Console.WriteLine($"So you will be given only ${sofaMoney}");
                Console.WriteLine("You have to build the sofa with the given money only.");
                Console.WriteLine("");
                string[,] choice_sets = new string[4, 3]
                {
                    { "Wooden Block of 30 feet - $100", "Wooden block of 40 feet - $120", "Wooden block of 50 feet - $150" },
                    { "Nails - $10", "Wood Screws - $15", "Both - $20" },
                    { "Chisel - $30", "Jigsaw - $40", "Table Saw - $60" },
                    {"Varnish - $80", "Stain - $50", "Both - $120"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int sofaIndex = 0;
                while (sofaIndex < 4)
                {
                    for (int j = 0; j < choice_sets.GetLength(1); j++)
                    {
                        Console.WriteLine(choice_sets[sofaIndex, j]);
                    }
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list (just enter the amount in front of it): ");
                    int amount = int.Parse(Console.ReadLine());
                    sofaMoney -= amount;
                    sofaIndex++;
                }
                if (sofaMoney > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${sofaMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the sofa!");
                    Console.WriteLine("You Win");
                }
                else if (sofaMoney < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-sofaMoney}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the sofa");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the sofa!");
                    Console.WriteLine("You Win");
                }
                break;
            case 2:
                Console.WriteLine("You have decided to build the bookshelf");
                Console.WriteLine("");
                int bookshelfMoney = 300;
                Console.WriteLine($"So you will be given only ${bookshelfMoney}");
                Console.WriteLine("You have to build the bookshelf with the given money only.");
                Console.WriteLine("");
                string[,] choice_sets2 = new string[4, 3]
                {
                    { "Wooden Block of 20 feet - $80", "Wooden block of 30 feet - $110", "Wooden block of 40 feet - $140" },
                    { "Nails - $10", "Wood Screws - $15", "Both - $20" },
                    { "Chisel - $30", "Jigsaw - $40", "Table Saw - $60" },
                    {"Varnish - $80", "Stain - $50", "Both - $120"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int k = 0;
                while (k < 4)
                {
                    for (int j = 0; j < choice_sets2.GetLength(1); j++)
                    {
                        Console.WriteLine(choice_sets2[k, j]);
                    }
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount = int.Parse(Console.ReadLine());
                    bookshelfMoney = bookshelfMoney - amount;
                    k++;
                }
                if (bookshelfMoney > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${bookshelfMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the bookshelf!");
                    Console.WriteLine("You Win");
                }
                else if (bookshelfMoney < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-bookshelfMoney}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the bookshelf");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the bookshelf!");
                    Console.WriteLine("You Win");
                }
                break;
            case 3:
                Console.WriteLine("You have decided to build the cupboard");
                Console.WriteLine("");
                int cupboardMoney = 400;
                Console.WriteLine($"So you will be given only ${cupboardMoney}");
                Console.WriteLine("You have to build the cupboard with the given money only.");
                Console.WriteLine("");
                string[,] choice_sets3 = new string[4, 3]
                {
                    { "Wooden Block of 30 feet - $100", "Wooden block of 40 feet - $120", "Wooden block of 50 feet - $150" },
                    { "Nails - $10", "Wood Screws - $15", "Both - $20" },
                    { "Chisel - $30", "Jigsaw - $40", "Table Saw - $60" },
                    {"Varnish - $80", "Stain - $50", "Both - $120"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int l = 0;
                while (l < 4)
                {
                    for (int j = 0; j < choice_sets3.GetLength(1); j++)
                    {
                        Console.WriteLine(choice_sets3[l, j]);
                    }
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount = int.Parse(Console.ReadLine());
                    cupboardMoney = cupboardMoney - amount;
                    l++;
                }
                if (cupboardMoney > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${cupboardMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the cupboard!");
                    Console.WriteLine("You Win");
                }
                else if (cupboardMoney < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-cupboardMoney}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the cupboard");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the cupboard!");
                    Console.WriteLine("You Win");
                }
                break;
            case 4:
                Console.WriteLine("You have decided to build the study table");
                Console.WriteLine("");
                int studyTableMoney = 200;
                Console.WriteLine($"So you will be given only ${studyTableMoney}");
                Console.WriteLine("You have to build the study table with the given money only.");
                Console.WriteLine("");
                string[,] choice_sets4 = new string[4, 3]
                {
                    { "Wooden Block of 20 feet - $80", "Wooden block of 30 feet - $110", "Wooden block of 40 feet - $140" },
                    { "Nails - $10", "Wood Screws - $15", "Both - $20" },
                    { "Chisel - $30", "Jigsaw - $40", "Table Saw - $60" },
                    {"Varnish - $80", "Stain - $50", "Both - $120"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int m = 0;
                while (m < 4)
                {
                    for (int j = 0; j < choice_sets4.GetLength(1); j++)
                    {
                        Console.WriteLine(choice_sets4[m, j]);
                    }
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount = int.Parse(Console.ReadLine());
                    studyTableMoney = studyTableMoney - amount;
                    m++;
                }
                if (studyTableMoney > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${studyTableMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the study table!");
                    Console.WriteLine("You Win");
                }
                else if (studyTableMoney < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-studyTableMoney}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the study table");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the study table!");
                    Console.WriteLine("You Win");
                }
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }


    // Specialist level method
    public void specialist()
    {
        Console.WriteLine("OK, Let's Start!");
        Console.WriteLine("Since you are a mediocre builder so you have given item choices:");
        string[] items = { "1. Computer System", "2. Designer Wall", "3. Apartment Furniture", "4. CPU" };
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");
        Console.Write("Select the item you want to build:");
        int choice = int.Parse(Console.ReadLine());
        switch (choice){
            case 1:
                Console.WriteLine("You have decided to build the computer system");
                Console.WriteLine("");
                int computerSystemMoney = 500;
                Console.WriteLine($"So you will be given only ${computerSystemMoney}");
                Console.WriteLine("You have to build the computer system with the given money only.");
                Console.WriteLine("");
                string[,] choice_sets = new string[4, 3]
                {
                    { "Motherboard - $100", "CPU - $150", "RAM - $200" },
                    { "Hard Disk - $100", "SSD - $150", "Both - $200" },
                    { "Keyboard - $50", "Mouse - $40", "Both - $80" },
                    {"Monitor - $200", "Printer - $150", "Both - $300"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int i = 0;
                while (i < 4)
                {
                    for (int j = 0; j < choice_sets.GetLength(1); j++)
                    {
                        Console.WriteLine(choice_sets[i, j]);
                    }
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list (just enter the amount in front of it): ");
                    int amount = int.Parse(Console.ReadLine());
                    computerSystemMoney -= amount;
                    i++;
                }
                if (computerSystemMoney > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${computerSystemMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the computer system!");
                    Console.WriteLine("You Win");
                }
                else if (computerSystemMoney < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-computerSystemMoney}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the computer system");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the computer system!");
                    Console.WriteLine("You Win");
                }
                break;
            case 2:
                Console.WriteLine("You have decided to build the designer wall");
                Console.WriteLine("");
                int designerWallMoney = 300;
                Console.WriteLine($"So you will be given only ${designerWallMoney}");
                Console.WriteLine("You have to build the designer wall with the given money only.");
                Console.WriteLine("");
                string[,] choice_sets2 = new string[4, 3]
                {
                    { "Marble slabs - $150", "Granite slabs - $200", "Ceramic tiles - $100" },
                    { "Adhesive - $20", "Grout - $30", "Both - $40" },
                    { "Trowel - $25", "Tile cutter - $45", "Tile nipper - $35" },
                    {"Sealer - $50", "Polish - $80", "Both - $120"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int k = 0;
                while (k < 4)
                {
                    for (int j = 0; j < choice_sets2.GetLength(1); j++)
                    {
                        Console.WriteLine(choice_sets2[k, j]);
                    }
                    Console.WriteLine("");
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount = int.Parse(Console.ReadLine());
                    designerWallMoney = designerWallMoney - amount;
                    k++;
                }
                if (designerWallMoney > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${designerWallMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the designer wall!");
                    Console.WriteLine("You Win");
                }
                else if (designerWallMoney < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-designerWallMoney}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the designer wall");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the designer wall!");
                    Console.WriteLine("You Win");
                }
                break;
            case 3:
                Console.WriteLine("You have decided to build the apartment furniture");
                Console.WriteLine("");
                int apartmentFurnitureMoney = 400;
                Console.WriteLine($"So you will be given only ${apartmentFurnitureMoney}");
                Console.WriteLine("You have to build the apartment furniture with the given money only.");
                Console.WriteLine("");
                string[,] choice_sets3 = new string[4, 3]
                {
                    { "Wooden Block of 20 feet - $80", "Wooden block of 30 feet - $110", "Wooden block of 40 feet - $140" },
                    { "Nails - $10", "Wood Screws - $15", "Both - $20" },
                    { "Chisel - $30", "Jigsaw - $40", "Table Saw - $60" },
                    {"Varnish - $80", "Stain - $50", "Both - $120"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int l = 0;
                while (l < 4)
                {
                    for (int j = 0; j < choice_sets3.GetLength(1); j++)
                    {
                        Console.WriteLine(choice_sets3[l, j]);
                    }
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount = int.Parse(Console.ReadLine());
                    apartmentFurnitureMoney = apartmentFurnitureMoney - amount;
                    l++;
                }
                if (apartmentFurnitureMoney > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${apartmentFurnitureMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the apartment furniture!");
                    Console.WriteLine("You Win");
                }
                else if (apartmentFurnitureMoney < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-apartmentFurnitureMoney}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the apartment furniture");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the apartment furniture!");
                    Console.WriteLine("You Win");
                }
                break;
            case 4:
                Console.WriteLine("You have decided to build the CPU");
                int cpuMoney = 200;
                Console.WriteLine($"So you will be given only ${cpuMoney}");
                Console.WriteLine("You have to build the CPU with the given money only.");
                string[,] choice_sets4 = new string[4, 3]
                {
                    { "Wooden Block of 20 feet - $80", "Wooden block of 30 feet - $110", "Wooden block of 40 feet - $140" },
                    { "Nails - $10", "Wood Screws - $15", "Both - $20" },
                    { "Chisel - $30", "Jigsaw - $40", "Table Saw - $60" },
                    {"Varnish - $80", "Stain - $50", "Both - $120"}
                };
                Console.WriteLine("You have to choose the items from the following lists:");
                Console.WriteLine("And just enter the amount in front of it");
                int m = 0;
                while (m < 4)
                {
                    for (int j = 0; j < choice_sets4.GetLength(1); j++)
                    {
                        Console.WriteLine(choice_sets4[m, j]);
                    }
                    Console.Write("Enter the amount you want to take in this list(Just enter the amount in front of it):");
                    int amount = int.Parse(Console.ReadLine());
                    cpuMoney = cpuMoney - amount;
                    m++;
                }
                if (cpuMoney > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have ${cpuMoney} left");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list and still have money!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the CPU!");
                    Console.WriteLine("You Win");
                }
                else if (cpuMoney < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You have exceeded the budget by ${-cpuMoney}");
                    Console.WriteLine("");
                    Console.WriteLine("You have failed to build the CPU");
                    Console.WriteLine("You Lose");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You have spent all the money");
                    Console.WriteLine("");
                    Console.WriteLine("Congrats, you have got items from each list!");
                    Console.WriteLine("");
                    Console.WriteLine("You have successfully built the CPU!");
                    Console.WriteLine("You Win");
                }
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

}