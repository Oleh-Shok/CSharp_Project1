bool repeat = true;
while (repeat)
{
    string theFirstParameter = string.Empty;

    while (string.IsNullOrWhiteSpace(theFirstParameter))
    {
        Console.Write("If you want to know the length of the parameter, enter it's value here: ");
        theFirstParameter = Console.ReadLine();
    }

    int theFirstParameterLength = theFirstParameter.Length;
    
    Console.Write($"You have entered the value <{theFirstParameter}> with the length of " +
        $"{theFirstParameterLength} {(theFirstParameterLength > 1 ? "characters" : "character")}.");
    Console.WriteLine();

    Console.Write("Go again? Y/N: ");
    string go = Console.ReadLine();
    if (go.ToUpper() != "Y")
    {
        repeat = false;
    }
    Console.WriteLine();
}
