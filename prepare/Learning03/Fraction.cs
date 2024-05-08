public class Fraction
{
    private int _top;
    private int _bottom;

    public string WholeFraction()
    {
        //constructor with no parameters
        _top = 1;
        _bottom = 1;
        return $"{_top}/{_bottom}";
    }
    public string TopFraction(int top)
    {
        _top = top;
        _bottom = 1;
        
        return $"{_top}/{_bottom}";
    }
    public string BothFraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        return $"{_top}/{_bottom}";
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}