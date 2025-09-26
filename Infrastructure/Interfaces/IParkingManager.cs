namespace Domain.Interfaces;

public interface IParkingManager
{
    void RentParkingSpot(int spotNumber, Resident resident);
    void FreeParkingSpot(int spotNumber);
    void DisplayParkingSpots();
}