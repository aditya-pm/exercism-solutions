using Microsoft.ApplicationInsights.Metrics.Extensibility;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = (max * (max + 1)) / 2;
        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;
        for (int i = 1; i <= max; i++)
        {
            sum += i * i;
        }
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}