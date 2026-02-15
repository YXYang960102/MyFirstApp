namespace MyFirstApp;

public class Calculator 
{
    public static double GetAverage(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
            return 0;

        
        return (double)numbers.Sum() / numbers.Count;
    }

    public static int GetMax(List<int> numbers) => numbers.Count > 0 ? numbers.Max() : 0;
}