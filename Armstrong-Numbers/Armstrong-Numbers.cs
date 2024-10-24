public class Solution 
{
    public bool ArmstrongNumber(int n) 
    {
        int originalNumber = n;
        int sum = 0;
        while (n != 0)
        {
            int lastDigit = n % 10;
            sum += (lastDigit * lastDigit * lastDigit);
            n /= 10;
        }
        if (sum == originalNumber)
            return true;
        else
            return false;
    }
}
