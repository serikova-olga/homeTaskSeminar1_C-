﻿Console.WriteLine ("input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("input number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine ());
if (number1>number2)
{
    if (number1>number3)
    {
        Console.WriteLine("max="+ number1);
    }
}
else
{
    if (number2>number3)
    {
        Console.WriteLine("max="+ number2);
    }

    Console.WriteLine("max="+ number3);
}
