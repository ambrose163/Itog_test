using System;
Console.Clear();

string[] stringArray = {"hello", "2", "world", "!", "-65", "Kazan", "and", "computer science", ":)"};

PrintNewArray(stringArray);

void PrintNewArray(string[] array)
{
    string[] newArray = Array.FindAll(array, item => item.Length <=3);

    for (int idx = 0; idx < newArray.Length; idx++)
    {
        if (idx != newArray.Length - 1)
            Console.Write($"{newArray[idx]}, ");
        else
            Console.WriteLine($"{newArray[idx]}");
    }
}