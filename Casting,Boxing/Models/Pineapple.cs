namespace Casting_Boxing.Models;

public class Pineapple:Fruit
{
    public int VitaminE;
    public int VitaminD;
    public Pineapple():base()
    {
        VitaminE = 0;
        VitaminD = 0;
    }
    public Pineapple(int vitaminE,int vitaminD, decimal price, string sort):base(price, sort)
    {
        VitaminE = vitaminE;
        VitaminD = vitaminD;
    }
    public override void Taste()
    {
        Console.WriteLine("Ananas turs dadir");
    }
}
