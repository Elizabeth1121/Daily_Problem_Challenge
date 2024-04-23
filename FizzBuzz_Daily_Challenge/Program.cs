// loop for 1 to 100
for (int i = 2; i < 100; i++)
{
    // if i is divisible by 3 and 5
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("{0} FizzBuzz", i);
    }
    // if i is divisible by 3
    else if (i % 3 == 0)
    {
        Console.WriteLine("{0} Fizz", i);
    }
    // if i is divisible by 5
    else if (i % 5 == 0)
    {
        Console.WriteLine("{0} Buzz", i);
    }
    // if i is not divisible by 3 or 5 or both
    else
    {
        Console.WriteLine("{0}", i);
    }
}

// keep console open 
Console.ReadLine();