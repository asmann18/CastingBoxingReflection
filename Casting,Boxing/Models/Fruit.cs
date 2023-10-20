namespace Casting_Boxing.Models;

public abstract class Fruit
{
    public decimal Price;
    public string Sort;

    public Fruit()
    {
        Price = 0;
        Sort = "empty";
    }
    public Fruit(decimal price,string sort)
    {
        Price= price;
        Sort = sort;
    }
    public virtual void Taste()
    {
        Console.WriteLine("Meyve dadlidir");
    }
}
