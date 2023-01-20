int count = 0;
while (true)
{
    Console.Write("Enter a number (or 'stop' to end): ");
    string input = Console.ReadLine();
    if (input == "stop")
    {
        break;
    }
    int number = int.Parse(input);
    if (number > 0)
    {
        count++;
    }
}
Console.WriteLine("You entered " + count + " numbers greater than 0.");
