using System;
using System.Security.AccessControl;

Console.WriteLine("Welcome to Meal Plannerama(Trademark Pending)! Choice paralisys got you down?");
Console.WriteLine("Well dont worry, because Meal Plannerama(Trademark Pending) is here to make your choices for you.");
Console.WriteLine("Now lets start off easy for you, when is this for; Breakfast, Lunch or Dinner?");
Console.WriteLine();

string firstResponse = Console.ReadLine();

if (firstResponse == "breakfast")
{
    Console.WriteLine();
    Console.WriteLine("You chose Breakfast. Now for the type of meal, do you want a light Breakfast or a heavy Breakfast?");
    Console.WriteLine();

    string secondResponse = Console.ReadLine();

    if (secondResponse == "light")
    {
        Console.WriteLine("You chose light Breakfast (boringgggggg).");
        Console.WriteLine("Hear are your Breakfast options;");
        Console.WriteLine("A. Avacado Toast");
        Console.WriteLine("B. BlueBerry Biscuits");
        Console.WriteLine("C. Omelet?");
        Console.WriteLine();

        string thirdResponse = Console.ReadLine();

        if (thirdResponse == "A")
        {
            Console.WriteLine("Your chose Avacado Toast(a little pertentious but okay-).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "B")
        {
            Console.WriteLine("Your chose BlueBerry Biscuits.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)");
        }
        else if (thirdResponse == "C")
        {
            Console.WriteLine("Your chose Omelet(ooooh so your basic-).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
    }

    else if (secondResponse == "heavy")
    {
        Console.WriteLine("You chose heavy Breakfast (boringgggggg).");
        Console.WriteLine("Hear are your Breakfast options;");
        Console.WriteLine("A. Egg, Spinach, Cheddar, Breakfast Sandwich");
        Console.WriteLine("B. Frittata with Asparagus Leek & Ricotta");
        Console.WriteLine("C. Oatmeal with Tomato & Sausage?");
        Console.WriteLine();

        string thirdResponse = Console.ReadLine();

        if (thirdResponse == "A")
        {
            Console.WriteLine("Your chose Egg, Spinach, Cheddar, Breakfast Sandwich(ngl that sounds pretty good-).");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "B")
        {
            Console.WriteLine("Your chose Frittata with Asparagus Leek & Ricotta.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
        else if (thirdResponse == "C")
        {
            Console.WriteLine("Your chose Oatmeal with Tomato & Sausage.");
            Console.WriteLine("CONGRATULATIONS! You have chosen your meal! Thank you for using Meal Plannerama(Trademark Pending)!");
        }
    }
}