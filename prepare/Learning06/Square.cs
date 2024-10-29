using System.Drawing;
using System.Reflection.Metadata.Ecma335;

class Square : Shape
{
    public double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}