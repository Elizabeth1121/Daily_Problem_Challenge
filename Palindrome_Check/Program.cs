using Palindrome_Check;

// Checking for palindrome Assignment:
// Write a function in C# that checks whether a given string is a palindrome. A palindrome is a word, phrase, or sequence that reads the same backward as forward (ignoring spaces, punctuation, and capitalization).

// ask for user input
Console.WriteLine("Hello! Daily problem 1! please type your word or sentence!");

// getting user input
string userInput = Console.ReadLine();

// call on the palindrom check class
Palindrome_Check.Palindrome_Check palindrome = new Palindrome_Check.Palindrome_Check();

// call on the strToArray method
palindrome.strToArray(userInput);

// check the output of strToArray method
foreach (var item in palindrome.charArr)
{
    Console.WriteLine(item);
}

// call on the isPalindrome method
bool isPalindrome = palindrome.isPalindrome();

// write the output of isPalindrome method
if (isPalindrome)
{
    Console.WriteLine("The word or sentence is a palindrome!");
}
else
{
    Console.WriteLine("The word or sentence is not a palindrome!");
}