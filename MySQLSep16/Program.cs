﻿// See https://aka.ms/new-console-template for more information
using MySQLSep16.DataAccess;
using MySQLSep16.Models;

//Alex Tamanaha P. 4

Console.WriteLine("Let's test our Bank Transactions!!! Woot WHoot!");

BankModel transaction = new BankModel
{
    Amt = 100,
    txDate = DateTime.Now,
    tx_type_typeID = 2
};

BankData banker = new BankData();
//banker.CreateTransaction(transaction);

List<BankModel> transactions = banker.ReadAllTransactsWithType();
foreach(BankModel b in transactions)
{
    Console.WriteLine(b);
}

Console.ReadLine();


static void RunCarStuff()
{
    CarData carData = new CarData();

    List<CarModel> cars = carData.getAllCars();
    List<int> carYears = carData.GetYears();
    List<string> carMake = carData.GetMake();
    List<CarModel> carSearchYear = carData.SearchYear();
    CarModel car1 = new CarModel
    {
        Year = 2022,
        Make = "Ford",
        Model = "F-150 Lightning",

    };

    //carData.CreateCar(car1);


    foreach (CarModel car in cars)
    {
        Console.WriteLine($"CarID: {car.CarID}, Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
    }


    CarModel carHold = carData.GetCarbyID(10);

    carHold.Make = car1.Make;
    carHold.Model = car1.Model;
    carHold.Year = car1.Year;

    carData.UpdateCar(carHold);

    foreach (int year in carYears)
    {

        Console.WriteLine($"Year: {year}");
    }

    foreach (string make in carMake)
    {
        Console.WriteLine($"Make: {make}");
    }
    foreach (CarModel car in carSearchYear)
    {
        Console.WriteLine($"CarID: {car.CarID}, Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
    }



}