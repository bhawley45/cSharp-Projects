
var recatngle1 = new Rectangle(5,10);

//Console.WriteLine($"width is: {recatngle1}");
//Console.WriteLine($"height is: {recatngle1}");
Console.WriteLine($"Area is {recatngle1.CalculateArea()}");
Console.WriteLine($"Circumference is {recatngle1.CalculateCircumference()}");

Console.ReadKey();

class Rectangle
{
    //fields (can have defaults assigned, otherwise int=0)
    private int _width;
    private int _height;

    //constructor
    public Rectangle(int width,int height)
    {
        //Typically contains field assignment and validations
        _width = width;
        _height = height;
    }

    //Methods: should always start w/ a verb (expression body method)
    public int CalculateCircumference() => 2 * _width + 2 * _height;
    public int CalculateArea() => _width * _height;
}




class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public MedicalAppointment(string patientName)
    {
        _patientName = patientName;
    }

    //If appointment date not specified, default to a week from
    //public MedicalAppointment(string patientName) : this(patientName, 7) { }

    /*Add default value of 7 if no number is provided (NEEDS to be: compile-time constant, 
     *  must appear after REQUIRED parameters, in case of ambiguity: the methods w/o Optional Parameters will be used
     *  ALL preceding optional parameters must be used (ex. new MedicalAppointment(10) wont work))
     *                  MODERATION IN USING THESE!! 
    */
    public MedicalAppointment(string patientName = "Unknown", int daysFromNow = 7)
    {
        _date = DateTime.Now.AddDays(daysFromNow);
    }


    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }
}
