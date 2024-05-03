// getting user input
string input = Console.ReadLine();

// hashset for vowels upper and lower case
HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

// creating a counter for vowels
int counter = 0;

// loop through the input
foreach (char c in input)
{
    if(vowels.Contains(c))
    {
        counter++;
    }
}

// output the number of vowels
Console.WriteLine(counter);
Console.ReadLine();