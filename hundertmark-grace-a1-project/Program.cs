using System;
using System.Security.AccessControl;

Console.WriteLine("Welcome to Meal Plannerama(Trademark Pending)! Choice paralisys got you down?");
Console.WriteLine("Well dont worry, because Meal Plannerama(Trademark Pending) is here to make your choices for you.");
Console.WriteLine("Now lets start off easy for you, when is this for; Breakfast, Lunch or Dinner?");
Console.WriteLine();

string firstResponse = Console.ReadLine();

if (firstResponse == "Breakfast")
{
    Console.WriteLine();
    Console.WriteLine("You chose Breakfast. Now for the type of meal, do you want a light Breakfast or a heavy Breakfast?");
    Console.WriteLine();

    string secondResponse = Console.ReadLine();

    if (secondResponse == "light")
    {
        Console.WriteLine();
        Console.WriteLine("You chose light Breakfast (boringgggggg).");
        Console.WriteLine("Here are your Breakfast options;");
        Console.WriteLine("A. Avacado Toast");
        Console.WriteLine("B. BlueBerry Biscuits");
        Console.WriteLine("C. Omelet?");
        Console.WriteLine();

        string thirdResponse = Console.ReadLine();

        if (thirdResponse == "A")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Avacado Toast(a little pertentious but okay-).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "B")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose BlueBerry Biscuits.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)");
        }
        else if (thirdResponse == "C")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Omelet(ooooh so your basic-).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"INVALID RESPONSE {thirdResponse}. Please choose A, B, or C. ");
        }
    }

    else if (secondResponse == "heavy")
    {
        Console.WriteLine();
        Console.WriteLine("You chose heavy Breakfast.");
        Console.WriteLine("Here are your Breakfast options;");
        Console.WriteLine("A. Egg, Spinach, Cheddar, Breakfast Sandwich");
        Console.WriteLine("B. Frittata with Asparagus Leek & Ricotta");
        Console.WriteLine("C. Oatmeal with Tomato & Sausage?");
        Console.WriteLine();

        string thirdResponse = Console.ReadLine();

        if (thirdResponse == "A")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Egg, Spinach, Cheddar, Breakfast Sandwich(ngl that sounds pretty good-).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "B")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Frittata with Asparagus Leek & Ricotta.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "C")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Oatmeal with Tomato & Sausage.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"INVALID RESPONSE {thirdResponse}. Please choose A, B, or C. ");
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"INVALID RESPONSE {secondResponse}. Please choose light or heavy.");
    }
}

else if (firstResponse == "Lunch")
{
    Console.WriteLine();
    Console.WriteLine("You chose Lunch. Now for the type of meal, do you want a light Lunch or a heavy Lunch?");
    Console.WriteLine();

    string secondResponse = Console.ReadLine();

    if (secondResponse == "light")
    {
        Console.WriteLine();
        Console.WriteLine("You chose light Lunch.");
        Console.WriteLine("Here are your Lunch options;");
        Console.WriteLine("A. Kale Caesar Salad");
        Console.WriteLine("B. Taco Stuffed Peppers");
        Console.WriteLine("C. PB&J Sandwich?");
        Console.WriteLine();

        string thirdResponse = Console.ReadLine();

        if (thirdResponse == "A")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Kale Caesar Salad(a little pertentious but okay-).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "B")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Taco Stuffed Peppers.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)");
        }
        else if (thirdResponse == "C")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose PB&J Sandwich(ooooh so your basic-).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"INVALID RESPONSE {thirdResponse}. Please choose A, B, or C. ");
        }
    }

    else if (secondResponse == "heavy")
    {
        Console.WriteLine();
        Console.WriteLine("You chose heavy Lunch.");
        Console.WriteLine("Here are your Lunch options;");
        Console.WriteLine("A. Sheet Pan Cashew Chicken");
        Console.WriteLine("B. Salmon Stir Fry");
        Console.WriteLine("C. Loaded Burger Bowels");
        Console.WriteLine();

        string thirdResponse = Console.ReadLine();

        if (thirdResponse == "A")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Sheet Pan Cashew Chicken.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "B")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Salmon Stir Fry.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "C")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Loaded Burger Bowels.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"INVALID RESPONSE {thirdResponse}. Please choose A, B, or C. ");
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"INVALID RESPONSE {secondResponse}. Please choose light or heavy.");
    }
}

else if (firstResponse == "Dinner")
{
    Console.WriteLine();
    Console.WriteLine("You chose Dinner. Now for the type of meal, do you want a light Dinner or a heavy Dinner?");
    Console.WriteLine();

    string secondResponse = Console.ReadLine();

    if (secondResponse == "light")
    {
        Console.WriteLine();
        Console.WriteLine("You chose light Dinner.");
        Console.WriteLine("Here are your Dinner options;");
        Console.WriteLine("A. Roasted Acorn Squash Salad");
        Console.WriteLine("B. Veggie Udon Stir Fry");
        Console.WriteLine("C. Cold Peanut Noodles");
        Console.WriteLine();

        string thirdResponse = Console.ReadLine();

        if (thirdResponse == "A")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Roasted Acorn Squash Salad.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "B")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Veggie Udon Stir Fry.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)");
        }
        else if (thirdResponse == "C")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Cold Peanut Noodles(boringggg... ).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"INVALID RESPONSE {thirdResponse}. Please choose A, B, or C. ");
        }
    }

    else if (secondResponse == "heavy")
    {
        Console.WriteLine();
        Console.WriteLine("You chose heavy Dinner.");
        Console.WriteLine("Here are your Dinner options;");
        Console.WriteLine("A. Buffalo Chicken Lasagna");
        Console.WriteLine("B. Beef & Sausage Chili");
        Console.WriteLine("C. Fruit Pecan Pork Roast");
        Console.WriteLine();

        string thirdResponse = Console.ReadLine();

        if (thirdResponse == "A")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Buffalo Chicken Lasagna.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "B")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Beef & Sausage Chili.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "C")
        {
            Console.WriteLine();
            Console.WriteLine("Your chose Fruit Pecan Pork Roast.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"INVALID RESPONSE {thirdResponse}. Please choose A, B, or C. ");
        }
    }

    else
    {
        Console.WriteLine();
        Console.WriteLine($"INVALID RESPONSE {secondResponse}. Please choose light or heavy.");
    }
}

else
{
    Console.WriteLine();
    Console.WriteLine($"INVALID RESPONSE {firstResponse}. Please choose Breakfast, Lunch, or Dinner. ");
}