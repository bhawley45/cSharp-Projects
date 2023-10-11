
var recatngle1 = new Rectangle(5,10);

//Console.WriteLine($"width is: {recatngle1}");
//Console.WriteLine($"height is: {recatngle1}");
Console.WriteLine($"Area is {recatngle1.CalculateArea()}");
Console.WriteLine($"Circumference is {recatngle1.CalculateCircumference()}");

Console.ReadKey();

class Rectangle
{
    //fields (can have defaults assigned, otherwise int=0)
    int _width;
    int _height;

    //constructor
    public Rectangle(int width,int height)
    {
        //Typically contains field assignment and validations
        this._width = width;
        this._height = height;
    }

    //Methods: should always start w/ a verb
    public int CalculateCircumference() { return 2 * _width + 2 * _height; }

    public int CalculateArea() { return _width * _height; }
}
