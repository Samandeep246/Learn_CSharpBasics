public static class Darts
{
    public static int Score(double x, double y)
    {
        double dis= (Math.Sqrt(x*x + y*y));
        if (dis <= 1)  return 10;
        if (dis <= 5)  return 5;
        if (dis <= 10) return 1;   
        return 0;        
    }
}
