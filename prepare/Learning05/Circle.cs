public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
    double pi = Math.PI;
    public override double GetArea()
    {
        return pi * (_radius * _radius);
    }
}