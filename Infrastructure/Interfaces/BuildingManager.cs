namespace Domain.Interfaces;

public class BuildingManager : IResidentManager, IParkingManager, IShopManager
{
    public List<Resident> residents = new List<Resident>();
    public List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
    List<Shop> shops = new List<Shop>();


    public void AddResident(Resident resident)
    {
        residents.Add(resident);
    }

    public Resident FindResident(int apartmentNumber)
    {
        foreach (var res in residents)
        {
            if (res.ApartmentNumber == apartmentNumber) return res;
        }
        return null;
    }

    public void DisplayResidents()
    {
        foreach (var res in residents)
        {
            Console.WriteLine($"Resident-Name:  {res.Name}, Apartment-Number: {res.ApartmentNumber},  PhoneNumber: {res.PhoneNumber}");
        }
    }

    public void RentParkingSpot(int spotNumber, Resident resident)
    {
        var theSpot = new ParkingSpot();
        foreach (var parkingSpot in parkingSpots)
        {
            if (parkingSpot.SpotNumber == spotNumber)  theSpot = parkingSpot;
        }

        theSpot.isOccupied = true;
        theSpot.Occupant = resident;
    }

    public void FreeParkingSpot(int spotNumber)
    {
        var theSpot = new ParkingSpot();
        foreach (var parkingSpot in parkingSpots)
        {
            if (parkingSpot.SpotNumber == spotNumber)  theSpot = parkingSpot;
        }
        theSpot.isOccupied = false;
        theSpot.Occupant = null;
    }

    public void DisplayParkingSpots()
    {
        foreach (var parkingSpot in parkingSpots)
        {
            Console.WriteLine($"Parking-Spot-Number: {parkingSpot.SpotNumber}, Is Occupied: {parkingSpot.isOccupied}, Occupant Name: {parkingSpot.Occupant.Name}");
        }
    }

    public void RentShop(string shopName)
    {
        shops.Add(new Shop(shopName));
    }

    public void FreeShop(string shopName)
    {
        foreach (var shop in shops)
        {
            if (shop.Name == shopName) shop.IsRented = false;
        }
    }

    public void DisplayShops()
    {
        foreach (var shop in shops)
        {
            Console.WriteLine($"Shop Name: {shop.Name}, Is rented: {shop.IsRented}");
        }
    }
}