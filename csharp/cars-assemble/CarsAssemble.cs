static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (1 <= speed && speed < 5 ) return 1.0;
        if (5 <= speed && speed < 9) return 0.9;
        if (speed == 9) return 0.8;
        if (speed == 10) return 0.77;
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return 221 * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
