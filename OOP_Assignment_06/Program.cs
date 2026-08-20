using OOP_Assignment_06.Resources;

namespace OOP_Assignment_06
{
    internal class Program
    {
        static void Main()
        {
            #region Part 01
            #region Q1  Object Copying
            // a) What happens when you assign one object variable to another object variable?
            // Answer => that will create new refrence at stack refer to the same object at the heap .

            // b) Does assigning one object to another create a new object? Explain.
            // Answer => no , because when you assign you make a new refrence and copy what exist at the first refrence at the satck (address of the object) so the two refrences will refer to the same object .

            // c) What is the difference between copying an object and copying its reference?
            // Answer => copying an object creates a separate instance in memory, copying its reference just points another variable to the original instance .
            #endregion
            #region Q2  Shallow Copy vs Deep Copy 
            // a) What is a Shallow Copy? 
            // Answer => create a new object with all members of the original and the Nested objects are shared .

            // b) What is a Deep Copy? 
            // Answer => create a new object with all members of the original and create a new objects of Nested objects  (the original and copy are completely independent) .

            // c) What happens to reference-type members when a Shallow Copy is created? 
            // Answer => the two objects will refere to the same object .

            // d) What happens to reference-type members when a Deep Copy is created? 
            // Answer => the two objects will refer to diffrent objects (independent) .

            // e) Give one situation where Deep Copy would be safer than Shallow Copy. 
            // Answer => When modifying nested data ande this data are refrence type .

            #endregion
            #region Q3  Static Members 
            // a) What is a static field, and how is it different from an instance field? 
            // Answer => field belong to the class not the object and shared across all instances (class member) , but instance field belongs to a specific object  .

            // b) What is a static method? Can a static method directly access instance members? 
            // Answer => Helper Method call it by name of class not from object .

            // c) What is a static constructor, and when is it executed? 
            // Answer => constructor that initializes static data ,called automatically before the class is first used or an instance is created .

            // d) What is a static class? Can you create an object from a static class? 
            // Answer => class group related static members ande cant create object from it .

            #endregion
            #region Q4  Extension Methods 
            // a) What is an Extension Method? 
            // Answer => static method that can be called with instance method syntax on an existing type without modifying its source code .

            // b) What keyword must be used in the first parameter of an extension method? 
            // Answer => this keyword

            // c) Where must an extension method be declared? 
            // Answer => inside static class.

            // d) Can an extension method access private members of the class it extends? 
            // Answer => No it can't .

            #endregion
            #region Q5  Partial Classes and Partial Methods 
            // a) What is a Partial Class? 
            // Answer => class whose definition is split across two or more files .

            // b) Why would a developer split one class into multiple files? 
            // Answer => to allow multiple developers to work on the same class , or keep auto-generated code separate from custom code .

            // c) What is a Partial Method? 
            // Answer => method declared in one partial part with its implementation optionally defined in another part .

            // d) What happens if a declared partial method has no implementation? 
            // Answer => The compiler completely removes the method declaration and calls at compile time .

            #endregion
            #endregion
            #region Part 02
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Smart Delivery Management System");
            DeliveryUtilities.PrintSeparator();
            #region center name
            DeliveryCenter Center01 = new DeliveryCenter("Cairo Center");
            #endregion
            #region StandardShipment
            string code1 = "SH001";
            string desc1 = "Mobile";
            double weight1 = 20;
            decimal fee1 = 50;
            string city1 = "Zagazigggggg";
            string street1 = "Altahrirrrrrrrr";
            int buildingNumber1 = 20;
            DeliveryAddress standard01add = new(city1!, street1!, buildingNumber1);
            StandardShipment s01 = new(code1!, desc1!, weight1, fee1, standard01add);
            #endregion
            #region ExpressShipment
            string code2 = "SH002";
            string desc2 = "PC";
            double weight2 = 15;
            decimal fee2 = 50;
            decimal extrafee2 = 50;
            string city2 = "Zagazig";
            string street2 = "Altahrir";
            int buildingNumber2 = 11;
            DeliveryAddress standard02add = new(city2!, street2!, buildingNumber2);
            ExpressShipment s02 = new(code2!, desc2!, weight2, fee2, extrafee2, standard02add);
            #endregion
            #region InternationalShipment
            string distination3 = "Egypt";
            string code3 = "SH003";
            string desc3 = "Laptop";
            double weight3 = 15;
            decimal fee3 = 50;
            decimal customfee3 = 50;
            string city3 = "Zag";
            string street3 = "Altahrir";
            int buildingNumber3 = 15;
            DeliveryAddress standard03add = new(city3!, street3!, buildingNumber3);
            InternationalShipment s03 = new(distination3!, code3!, desc3!, weight3, fee3, customfee3, standard03add);
            #endregion
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Creating Shipments...");
            DeliveryUtilities.PrintSeparator();
            #region Add all shipments to the DeliveryCenter
            Center01.AddShipment(s01);
            Center01.AddShipment(s02);
            Center01.AddShipment(s03);
            Console.WriteLine($"\nTotal Shipments Created : {Shipment.GetTotalShipmentsCreated()}\n");
            DeliveryUtilities.PrintSeparator();
            #endregion
            #region Object Copying
            Shipment standard01 = s01;
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Object Copying");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine($"\nOriginal Shipment  :{s01.TrackingCode}");
            Console.WriteLine($"Assigned Shipment  :{standard01.TrackingCode}\n");
            Console.WriteLine($"Same Object : {object.ReferenceEquals(standard01, s01)}\n");
            #endregion
            #region Shallow Copy
            Shipment standard02 = s01.ShallowCopy();
            DeliveryUtilities.PrintSingleSeparator();
            DeliveryUtilities.PrintSystemTitle("Shallow Copy");
            DeliveryUtilities.PrintSingleSeparator();
            Console.WriteLine($"Original Shipment Address : {s01.Destination.city}");
            Console.WriteLine($"Copied Shipment Address : {standard02.Destination.city}");
            Console.WriteLine("\nChanging copied shipment address...\n");
            standard02.Destination.city = "zag";
            Console.WriteLine($"Original Shipment Address : {s01.Destination.city}");
            Console.WriteLine($"Copied Shipment Address : {standard02.Destination.city}");
            Console.WriteLine($"\nSame DeliveryAddress Object : {object.ReferenceEquals(s01.Destination.city, standard02.Destination.city)}\n");
            #endregion
            #region Deep Copy
            Shipment standard03 = s01.DeepCopy();
            DeliveryUtilities.PrintSingleSeparator();
            DeliveryUtilities.PrintSystemTitle("Deep Copy");
            DeliveryUtilities.PrintSingleSeparator();
            Console.WriteLine($"\nOriginal Shipment Address : {s01.Destination.city}");
            Console.WriteLine($"Copied Shipment Address : {standard03.Destination.city}");
            Console.WriteLine("\nChanging copied shipment address...\n");
            standard03.Destination.city = "Cairo";
            Console.WriteLine($"Original Shipment Address : {s01.Destination.city}");
            Console.WriteLine($"Copied Shipment Address : {standard03.Destination.city}");
            Console.WriteLine($"\nSame DeliveryAddress Object : {object.ReferenceEquals(s01.Destination.city, standard03.Destination.city)}\n");
            #endregion
            #region Extension Methods
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Extension Methods");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine();
            Console.WriteLine(s01.GetSummary());
            Console.WriteLine(s02.GetSummary());
            Console.WriteLine(s03.GetSummary());
            Console.WriteLine($"\nSH001 Is Delivered : {s01.IsDelivered()}");
            Console.WriteLine($"SH003 Is Delivered : {s03.IsDelivered()}\n");
            #endregion
            #region Tracking Status
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Tracking Status");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine();
            s03.UpdateTrackingStatus("Out For Delivery");
            Console.WriteLine();
            #endregion
            #region Static Utilities
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Static Utilities");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine();
            DeliveryUtilities.PrintSingleSeparator();
            DeliveryUtilities.PrintSystemTitle("Delivery Center");
            DeliveryUtilities.PrintSingleSeparator();

            Console.WriteLine($"\nTotal Shipments Created : {Shipment.TotalShipmentsCreated}\n");

            #endregion
            #region Partial Method
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Partial Method");
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine();
            s02.UpdateTrackingStatus("Delivered");
            Console.WriteLine();
            #endregion
            #region Assignment Completed
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Assignment Completed");
            DeliveryUtilities.PrintSeparator();
            #endregion
            #endregion
        }
    }
}
