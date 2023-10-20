namespace Casting_Boxing.Models;

public class Apple:Fruit
{
    public int VitaminA;
    public int VitaminB;
    public Apple():base()
    {
        VitaminA = 0;
        VitaminB = 0;
    }
    public Apple(int vitaminA, int vitaminB, decimal price, string sort) : base(price,sort)
    {
        VitaminA = vitaminA;
        VitaminB = vitaminB;
    }
    public override void Taste()
    {
        Console.WriteLine("Alma sirin dadir");
    }
}
