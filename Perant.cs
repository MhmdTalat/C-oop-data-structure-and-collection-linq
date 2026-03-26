using System.Data;

namespace dotnet_recaver;


public class Perant
{
    // access modifier, data type, property name, getter and setter
    private int Number { get; set; }
    public int num { get; set; }
    public int Num
    {
        get { return Number; }
        set { Number = value; }
    }
    public int num1 { get; set; }
    //initializer
    //constructor
    public Perant(int num, int num1, int Num = 0)
    {
        this.num = num;
        this.num1 = num1;
        this.Num = Num;
    }

    //protected method
    protected void Display()
    {
        Console.WriteLine($"The numbers are: {num} and {num1}");
    }

    static void Increment(int x) // نسخة من المتغير
    {
        x = x + 1;
        Console.WriteLine($"Inside method: {x}");
    }
    static void IncrementRef(ref int x) // مرجع للمتغير
    {
        x = x + 1;
        Console.WriteLine($"Inside method: {x}");
    }
    //overloaded method
    public int Add(int num, int num1)
    {
        int inc = 5;
        Increment(inc);
        IncrementRef(ref inc);

        return num + num1 + inc; // inc is passed by value, so it will not be modified outside the method
    }

    public int Add(int num, int num1, int Num)
    {
        return num + num1 * Num;
    }

    public virtual void DisplayPerant()
    {
        Display();
    }



}
