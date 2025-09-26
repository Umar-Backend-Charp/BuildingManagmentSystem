namespace Domain.Interfaces;

public class Resident
{
    public string Name { get; set; }
    public int ApartmentNumber { get; set; }
    public string PhoneNumber { get; set; }
    
    public Resident() {}

    public Resident(string name, int apartmentNumber, string phoneNumber)
    {
        Name = name;
        ApartmentNumber = apartmentNumber;
        PhoneNumber = phoneNumber;
    }
}