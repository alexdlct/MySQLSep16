// See https://aka.ms/new-console-template for more information
using MySQLSep16.DataAccess;
using MySQLSep16.Models;


CarData carData = new CarData();

List<CarModel> cars = carData.getAllCars();
List<int> carYears = carData.GetYears();

/*CarModel car1 = new CarModel
{
    Year = 2022,
    Make = "Ford",
    Model = "F-150 Lightning",

};

carData.CreateCar(car1);*/

foreach (CarModel car in cars)
{
    Console.WriteLine($"CarID: {car.CarID}, Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
}

foreach (int year in carYears)
{
    
    Console.WriteLine($"Year: {year}");
}

Console.ReadLine();


