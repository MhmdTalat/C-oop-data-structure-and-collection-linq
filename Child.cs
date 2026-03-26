namespace dotnet_recaver;
//inheritance
public class Child : Perant
{
    public Child(int num, int num1) : base(num, num1)
    {
    }

    public int Multiply(int num, int num1)
    {
        return num * num1;
    }
    public void DisplayChild()
    {
        Display();

    }

    public override void DisplayPerant()
    {
        Console.WriteLine("This is the child class overriding the parent method.");
        base.DisplayPerant();
    }
}
