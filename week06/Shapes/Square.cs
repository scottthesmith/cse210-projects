

public class Square : Shape
{
    public Square(string color, int _side) : base(color)
    {
        
    }

     private double _side;

    public override double GetArea()
    {
        return _side;
    }
}