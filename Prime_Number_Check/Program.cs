internal class Program
{
    private static void Main(string[] args)
    {
        Solution sol = new Solution();
        // this works
        //Console.WriteLine(sol.IsPalindrome(12));

        // test 2
        Console.WriteLine(sol.IsPalindrome2(12));
    }
}

public class Solution
{
    public bool IsPalindrome(int x)
    {
        for(int i = 2; i < x; i++)
        {
            if(x != i && x % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsPalindrome2(int x)
    {
        int counter = x;

        if(x !=0 && x % counter == 0)
        {
            return false;
        }
        if(counter == 1 && counter != x)
        {
            return true;
        }
        return IsPalindrome2(counter - 1);
    }
}