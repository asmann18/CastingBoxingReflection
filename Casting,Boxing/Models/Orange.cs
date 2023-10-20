using System.Diagnostics;

namespace Casting_Boxing.Models;

public class Orange:Fruit
{
    public int VitaminC;

    public Orange():base()
    {
        VitaminC = 0;
    }
    public Orange(int vitaminC,decimal price, string sort):base(price, sort) 
    {
        VitaminC=vitaminC;
    }
    public override void Taste()
    {
        Console.WriteLine("Portagal xaraso");
    }
}
