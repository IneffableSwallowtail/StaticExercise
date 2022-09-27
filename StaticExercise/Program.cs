
bool valid1 = true;
bool valid2 = true;
bool cont = true;

string invalid = "Invalid selection";
string response;

while (cont)
{
    do
    {
        Console.WriteLine("\nChoose a conversion type.\n1. Fahrenheit to Celsius\n2. Celsius to Fahrenheit");

        switch (Console.ReadLine())
        {
            case "1":
                Console.Write("\nEnter the Fahrenheit value: ");
                valid1 = Double.TryParse(Console.ReadLine(), out double userInput);
                if (valid1 == false)
                {
                    Console.WriteLine(invalid);
                    break;
                }
                else
                {
                    Console.WriteLine($"Celsius: {StaticExercise.TempConverter.FahrenheitToCelsius(userInput)} degrees");
                    break;
                }
            case "2":
                Console.Write("\nEnter the Celsius value: ");
                valid1 = Double.TryParse(Console.ReadLine(), out userInput);
                if (valid1 == false)
                {
                    Console.WriteLine(invalid);
                    break;
                }
                else
                {
                    Console.WriteLine($"Fahrenheit: {StaticExercise.TempConverter.CelsiusToFahrenheit(userInput)} degrees");
                    break;
                }
            default:
                Console.WriteLine(invalid);
                valid1 = false;
                break;
        }
    } while (valid1 == false);
    Console.Write("\nSelect another function? ");
    do
    {
        response = Console.ReadLine().ToLower();
        if (response == "yes" || response == "y")
        {
            cont = true;
            valid2 = true;
        }
        else if (response == "no" || response == "n")
        {
            cont = false;
            valid2 = true;
        }
        else
        {
            Console.WriteLine(invalid);
            valid2 = false;
        }
    } while (valid2 == false);
}