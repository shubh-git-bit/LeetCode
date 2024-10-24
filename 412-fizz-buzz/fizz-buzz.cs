public class Solution 
{
    public IList<string> FizzBuzz(int n) 
    {
        List<string> resultList = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            string result = "";
            if (i % 3 == 0)
                result += "Fizz";
            if (i % 5 == 0)
                result += "Buzz";
            if (result == "")
                result = i.ToString();

            resultList.Add(result);
        }
        return resultList;
    }
}