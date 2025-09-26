
using Domain.Interfaces;

BuildingManager buildingManager = new BuildingManager();
bool isRunning = true;

Console.WriteLine("Добро пожаловать в систему управления жилым домом!");

while (isRunning)
{
    Console.WriteLine("""
                      
                      1. Добавить жильца
                      2. Арендовать парковочное место
                      3. Освободить парковочное место
                      4. Арендовать магазин
                      5. Освободить магазин
                      6. Отобразить жильцов
                      7. Отобразить парковочные места
                      8. Отобразить магазины
                      9. Выйти из программы
                      """);
    Console.Write("Выберите действие, введя номер пункта меню: ");
    int input = int.Parse(Console.ReadLine());
    
    switch(input) 
    {
        case 1:
            Console.Write("Введите имя жильца: ");
            string rName = Console.ReadLine();
            Console.Write("Введите номер квартиры: ");
            int rApNum = int.Parse(Console.ReadLine());
            Console.Write("Введите номер телефона: ");
            string rPhoneNum = Console.ReadLine();
            buildingManager.AddResident(new Resident(rName, rApNum, rPhoneNum));

            Console.WriteLine($"Жилец \"{rName}\" успешно добавлен в квартиру №{rApNum}");
            break;
        case 2:
            Console.Write("Введите номер парковочного места: ");
            int psNum = int.Parse(Console.ReadLine());
            Console.Write("Введите номер квартиры: ");
            int rPsApNum = int.Parse(Console.ReadLine());
            var theResident = buildingManager.FindResident(rPsApNum);
            buildingManager.RentParkingSpot(psNum, theResident);
            Console.WriteLine($"Парковочное место №{rPsApNum} успешно арендовано жильцом квартиры №{psNum}.");
            break;
        case 3:
            Console.Write("Введите номер парковочного места: ");
            int psNumm = int.Parse(Console.ReadLine());
            buildingManager.FreeParkingSpot(psNumm);
            Console.WriteLine($"Парковочное место №{psNumm} освобождено.");
            break;
        case 4:
            Console.Write("Введите название магазина: ");
            string shName = Console.ReadLine();
            buildingManager.RentShop(shName);
            Console.WriteLine($"Магазин \"{shName}\" успешно арендован.");
            break;
        case 5:
            Console.Write("Введите название магазина: ");
            string shNameff = Console.ReadLine();
            buildingManager.FreeShop(shNameff);
            Console.WriteLine($"Магазин \"{shNameff}\" освобожден и доступен для аренды.");
            break;
        case 6:
            Console.WriteLine("Список всех жильцов: ");
            buildingManager.DisplayResidents();
            break;
        case 7:
            Console.WriteLine("Список всех парковочных мест: ");
            buildingManager.DisplayParkingSpots();
            break;
        case 8:
            Console.WriteLine("Список всех магазинов: ");
            buildingManager.DisplayShops();
            break;
        case 9:
            Console.WriteLine("Работа программы завершена");
            isRunning = false;
            break;
        default:
            Console.WriteLine("Неверный выбор");
            isRunning = false;
            break;
    }

    
}