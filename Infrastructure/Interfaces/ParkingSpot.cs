namespace Domain.Interfaces;

public class ParkingSpot
{
    public int SpotNumber { get; set; }
    public bool isOccupied { get; set; }
    public Resident? Occupant { get; set; }
}