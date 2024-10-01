using System.Collections.Generic;
using ListaLinkadaCircular;

CircularLinkedList<string> categories = [];
categories.AddLast("Sport");
categories.AddLast("Culture");
categories.AddLast("History");
categories.AddLast("Geography");
categories.AddLast("People");
categories.AddLast("Technology");
categories.AddLast("Nature");
categories.AddLast("Science");

Random random = new();
int totalTime = 0;
int remainingTime = 0;
foreach (string category in categories)
{
    if (remainingTime <= 0)
    {
        Console.WriteLine("Press [Enter] to start or any other key to exit");
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Enter:
                totalTime = random.Next(1000, 5000);
                remainingTime = totalTime;
                break;
            default:
                return;
        }
    }

    int categoryTime = (-450 * remainingTime) / (totalTime - 50) + 500 + (22500 / (totalTime - 50));
    remainingTime -= categoryTime;
    Thread.Sleep(categoryTime);

    Console.ForegroundColor = remainingTime <= 0 ? ConsoleColor.Red : ConsoleColor.Gray;
    Console.WriteLine(category);
    Console.ForegroundColor = ConsoleColor.Gray;
}