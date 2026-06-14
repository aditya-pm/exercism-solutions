public static class Darts
{
    public static int Score(double x, double y)
    {
        double radius = Math.Sqrt(x * x + y * y);
        if (0 <= radius && radius <= 1)
            return 10;
        if (radius <= 5)
            return 5;
        if (radius <= 10)
            return 1;
        return 0;
    }
}
