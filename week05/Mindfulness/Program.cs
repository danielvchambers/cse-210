using System;

class Program
{
    static void Main(string[] args)
    {
        console.WriteLine("Please Pick A Mindful Activity by typing the number infront of the activity");
        console.WriteLine("1. Breathing Activity");
        console.WriteLine("2. Reflecting Activity");
        console.WriteLine("3. Listing Activity");
        console.WriteLine("4. Quit");
        string _choice = console.ReadLine();
        if (_choice == 1)
        {
            Breathing.Run();
        }
        else if (_choice == 2)
        {
            Relfecting.Run();
        }
        else if (_choice == 3)
        {
            Listing.Run();
        }
    }
}
