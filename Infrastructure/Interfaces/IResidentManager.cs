namespace Domain.Interfaces;

public interface IResidentManager
{
    void AddResident(Resident resident);
    Resident FindResident(int apartmentNumber);
    void DisplayResidents();
}