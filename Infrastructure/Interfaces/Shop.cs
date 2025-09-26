namespace Domain.Interfaces;

public class Shop
{
    public string Name { get; set; }
    public double RentAmount { get; set; }
    public bool IsRented { get; set; }
    
    public Shop() {}

    public Shop(string name)
    {
        Name = name;
        IsRented = true;
    }
}