public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        // i < j < k and i + j + k = sum.
        //
        // The smallest possible values larger than i are
        // j = i + 1 and k = i + 2.
        //
        // Therefore:
        //     sum = i + j + k
        //     sum >= i + (i + 1) + (i + 2)
        //     sum >= 3i + 3
        //       i <= (sum - 3) / 3
        // roughly i < sum / 3
        //
        // So i cannot be greater than roughly one third of sum.
        for (int i = 1; i < sum / 3; i++)
        {
            // After fixing i:
            //     j + k = sum - i
            //
            // Since j < k, j can occupy at most half of the
            // remaining sum; otherwise k would become <= j.
            for (int j = i + 1; j <= (sum - i) / 2; j++)
            {
                int k = sum - i - j;

                if (i * i + j * j == k * k)
                    yield return (i, j, k);
            }
        }
    }
}