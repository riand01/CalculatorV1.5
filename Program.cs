
using System.Diagnostics.SymbolStore;


// Creating a list to save the calculations in
List<string> result = new List<string>();


// Creating a string to capture user input choise
string category = "";


// Choosing a while loop to loop the meny and delcaring char 3 from user to be the exit
while (category != "3")
{


    // Printing Meny text
    Console.WriteLine("   Kalkylator\n----------------");
    Console.WriteLine("\n Gör något av följande val:\n\n 1. Kalkylator\n 2. Tidigare Resultat\n 3. Avsluta Programmet");
    Console.Write(" ");


    // Converting the string category in too user input
    category = Console.ReadLine();


    // Applying a switch case to handle meny choises
    switch (category)
    {

        // Case 1 includes Calculator
        case "1":

            // declare the letter y to continue the loop
            char more = 'y';

            // Aslong the user chooses y the calculator-loop will continue
            while (more == 'y')
            {

                // Meny text for calculator
                Console.Clear();
                Console.WriteLine("   Kalkylator");
                Console.WriteLine("----------------\n");
                Console.WriteLine("Skriv in en valfri beräkning, t.ex 4,6*3,2\n");

                // Declare user input to a string
                string calc = Console.ReadLine();


                // if user calulation input contains * then the following shall happen
                if (calc.Contains("*"))
                {

                    // declar operator
                    int timesIndex = calc.IndexOf("*");
                    // declar first number
                    string tal1Text = calc[..timesIndex];
                    // declar second number
                    string tal2Text = calc[(timesIndex + 1)..];
                    // try catch method to catch invalid user input chars
                    try
                    {
                        // convert numbers from string to double
                        double tal1 = double.Parse(tal1Text);
                        double tal2 = double.Parse(tal2Text);
                        // declare the calculation
                        double product = tal1 * tal2;
                        // Print the calculation
                        Console.WriteLine(calc + " = " + product);
                        // catch the calculation to the list
                        string execution1 = $"{calc} = {product.ToString()}";
                        result.Add(execution1);
                        // Ask user to do a new calculation or return to meny
                        Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                        // control char y
                        more = Convert.ToChar(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                    Console.Clear();

                }

                // Same but different operator
                else if (calc.Contains("-"))
                {
                    int subIndex = calc.IndexOf("-");
                    string tal1Text = calc[..subIndex];
                    string tal2Text = calc[(subIndex + 1)..];
                    try
                    {
                        double tal1 = double.Parse(tal1Text);
                        double tal2 = double.Parse(tal2Text);
                        double product = tal1 - tal2;
                        Console.WriteLine(calc + " = " + product);
                        string execution2 = $"{calc} = {product.ToString()}";
                        result.Add(execution2);
                        Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                        more = Convert.ToChar(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                    Console.Clear();
                }

                // Same but different operator
                else if (calc.Contains("+"))
                {
                    int addIndex = calc.IndexOf("+");
                    string tal1Text = calc[..addIndex];
                    string tal2Text = calc[(addIndex + 1)..];
                    try
                    {
                        double tal1 = double.Parse(tal1Text);
                        double tal2 = double.Parse(tal2Text);
                        double product = tal1 + tal2;
                        Console.WriteLine(calc + " = " + product);
                        string execution3 = $"{calc} = {product.ToString()}";
                        result.Add(execution3);
                        Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                        more = Convert.ToChar(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                    Console.Clear();
                }

                // Same but different operator
                else if (calc.Contains("/"))
                {
                    int divIndex = calc.IndexOf("/");
                    string tal1Text = calc[..divIndex];
                    string tal2Text = calc[(divIndex + 1)..];
                    try
                    {


                        double tal1 = double.Parse(tal1Text);
                        double tal2 = double.Parse(tal2Text);
                        double product = tal1 / tal2;

                        // Catch error when dividing with zero
                        if (tal2 == 0)
                        {
                            Console.WriteLine("Du kan inte dividera med 0");
                            Console.ReadKey();
                            continue;
                        }
                        else
                            Console.WriteLine(calc + " = " + product);
                        string execution4 = $"{calc} = {product.ToString()}";
                        result.Add(execution4);
                        Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                        more = Convert.ToChar(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                    Console.Clear();
                }
                else
                {
                    // Invalid Operator
                    Console.WriteLine("Ogiltigt val!");
                    Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                    more = Convert.ToChar(Console.ReadLine());
                }
            }
            break;


        // Case 2 includes List of former calculations   
        case "2":

            // Meny Text
            Console.Clear();
            Console.WriteLine("   Tidigare Resultat");
            Console.WriteLine("-------------------------\n");

            // Print entire List with foreach loop
            foreach (string print in result)
            {
                Console.WriteLine(print + " ");
            }

            // Text to navigate user back to meny
            Console.WriteLine("\n\nTryck Enter för att gå tillbaka till menyn");
            Console.ReadKey();
            Console.Clear();
            break;


        // Quite Program 
        case "3":
            // Text to let the user know the program is about to end
            Console.WriteLine("\n Programmet kommer att avslutas!");
            Console.WriteLine(" Tryck Enter för att bekräfta!");
            Console.ReadKey();

            // Code to exit program
            Environment.Exit(1);
            break;


        // Catch invalid choise
        default:

            // Text to let the user know an invalid choise was made
            Console.WriteLine("Ogiltigt val, Tryck Enter och försök igen!");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}

