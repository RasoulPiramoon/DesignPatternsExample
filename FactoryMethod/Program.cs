// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Start");

var snapFood = new SnapFoodMarketPlaceFactory().GetNewMarketplace();
snapFood.SendData();

var tapsiFood = new TapsiFoodMarketplaceFactory().GetNewMarketplace();
tapsiFood.SendData();

var delino = new DelinoMarketplaceFactory().GetNewMarketplace();
delino.SendData();

Console.ReadLine();