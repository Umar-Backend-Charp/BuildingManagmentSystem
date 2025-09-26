namespace Domain.Interfaces;

public interface IShopManager
{
    void RentShop(string shopName);
    void FreeShop(string shopName);
    void DisplayShops();
}