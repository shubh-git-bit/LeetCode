public class Solution 
{
    public int Reverse(int x) 
    {
        int reversedNumber = 0;
        while (x != 0)
        {
            int lastDigit = x % 10;
            if ((reversedNumber > int.MaxValue / 10) || (reversedNumber == int.MaxValue / 10 && lastDigit > 7))
                return 0;
            if ((reversedNumber < int.MinValue / 10) || (reversedNumber == int.MinValue / 10 && lastDigit < -8))
                return 0;
            reversedNumber = (reversedNumber * 10) + lastDigit;
            x /= 10;
        }
        return reversedNumber;
    }
}