﻿int size = 20;

int[] numbers = new int[size];
int[] ordered = new int[size];
int[] reversedVector = new int[size];

int lastOccurrence, minor, aux, higher, count;

do
{
    lastOccurrence = higher = count = 0;

    Console.WriteLine("\nChallenger vector");

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(0, 100);
        Console.Write($"{numbers[i]} ");
    }

    minor = numbers[0];
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] < minor)
        {
            minor = numbers[i];
            lastOccurrence = i;
        }
    }

    ordered[count++] = minor;

    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > numbers[higher])
            higher = i;
    }

    for (int index = 0; index < size; index++)
    {
        minor = higher;
        aux = count - 1;

        for (int i = 0; i < size; i++)
        {
            if (numbers[i] < numbers[minor] && numbers[i] >= ordered[aux])
                if (numbers[i] == ordered[aux])
                {
                    if (i > lastOccurrence)
                        minor = i;
                }
                else
                    minor = i;
        }

        lastOccurrence = minor;

        if (ordered[count - 1] != numbers[minor])
            ordered[count++] = numbers[minor];
    }

    Console.WriteLine("\n\nVector without same numbers");
    aux = count;

    for (int i = 0; i < count; i++)
        Console.Write(ordered[i] + " ");

    for (int i = 0; i < count; i++)
        reversedVector[i] = ordered[--aux];

    Console.WriteLine("\n\nReverted");

    for (int i = 0; i < count; i++)
        Console.Write(reversedVector[i] + " ");

    Console.WriteLine("\n\nType 'y' to continue");
} while (Console.ReadLine() == "y");