using System;
using System.Collections;
class Vehicle
{
    int year;
    string make;
    string model;
    public Vehicle(int year, string make, string model)
    {
        this.year = year;
        this.make = make;
        this.model = model; 
    }

    public int getYear()
    {
        return year;
    }
    public String getMake()
    {
        return make;
    }

    public String getModel()
    {
        return model;
    }

    public void modifyYear(int year)
    {
        this.year = year;
    }

    public void modifyMake(string make)
    {
        this.make = make;
    }

    public void modifyModel(string model)
    {
        this.model = model;
    }
}

class programOps
{
    static List<Vehicle> vehicles = new List<Vehicle>();
    static string divider = "--------------------";
    public static void addVehicle()
    {
        int year = 0;
        string make = "";
        string model = "";
        Console.Write("Enter year: ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter make: ");
        make = Console.ReadLine();
        Console.Write("Enter model: ");
        model = Console.ReadLine();
        Vehicle createdVehicle = new Vehicle(year, make, model);
        vehicles.Add(createdVehicle);
        Console.WriteLine(divider + "\nAdded the following vehicle: \n");
        Console.WriteLine("Year: " + createdVehicle.getYear());
        Console.WriteLine("Make: " + createdVehicle.getMake());
        Console.WriteLine("Model: " + createdVehicle.getModel() + "\n" + divider);
    }

    public static void removeVehicle(int index)
    {
        Console.WriteLine(divider);
        index--;
        if (index > vehicles.Count || index < 0)
        {
            Console.WriteLine("Invalid vehicle");
        }
        else
        {
            vehicles.RemoveAt(index);
            Console.WriteLine("Successfully removed vehicle!");
        }
    }

    public static void editVehicle(int index)
    {
        Console.WriteLine(divider);
        index--;
        if (index > vehicles.Count || index < 0)
        {
            Console.WriteLine("Invalid vehicle!");
        }
        else
        {
            Console.WriteLine("Successfully removed vehicle!");
            programOps.editVehicleOption(index--);
        }
    }

    public static void editVehicleOption(int index)
    {
        Console.WriteLine("Current Vehicle Details: ");
        Console.WriteLine("1. Year: " + vehicles[index].getYear() + "\n2. Make: " + vehicles[index].getMake() + "\n3. Model: " + vehicles[index].getModel());
        Console.WriteLine("Enter which detail to change (enter 0 to return): ");
        string option = Console.ReadLine();
        Console.WriteLine(divider);
        switch(option)
        {
            case "0":
                break;
            case "1":
                Console.WriteLine("What is the new year?");
                vehicles[index].modifyYear(Int32.Parse(Console.ReadLine()));
                Console.WriteLine(divider);
                Console.WriteLine("Successfully changed year!");
                break;
            case "2":
                Console.WriteLine("What is the new make?");
                vehicles[index].modifyMake(Console.ReadLine());
                Console.WriteLine(divider);
                Console.WriteLine("Successfully changed make!");
                break;
            case "3":
                Console.WriteLine("What is the new model?");
                vehicles[index].modifyModel(Console.ReadLine());
                Console.WriteLine(divider);
                Console.WriteLine("Successfully changed model!");
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }
    public static void viewVehicles()
    {
        if (vehicles.Count == 0)
        {
            Console.WriteLine("No vehicles in inventory!");
        }
        else
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + vehicles[i].getYear() + " " + vehicles[i].getMake() + " " + vehicles[i].getModel());
            }
        }
    }

    static void Main(String[] args)
    {
        Console.WriteLine("Welcome!\n" + divider + "\n");
        while (true)
        {
            Console.WriteLine("Please enter an option: ");
            Console.WriteLine("1: Add to inventory");
            Console.WriteLine("2. Remove from inventory");
            Console.WriteLine("3. Edit inventory details");
            Console.WriteLine("4: View inventory");
            Console.WriteLine("5: Exit");
            string option = Console.ReadLine();
            Console.WriteLine(divider);
            switch (option)
            {
                case "1":
                    programOps.addVehicle();
                    break;
                case "2":
                    Console.WriteLine("Which vehicle would you like to remove?");
                    programOps.viewVehicles();
                    programOps.removeVehicle(Int32.Parse(Console.ReadLine()));
                    break;
                case "3":
                    Console.WriteLine("Which vehicle would you like to edit?");
                    programOps.viewVehicles();
                    programOps.editVehicle(Int32.Parse(Console.ReadLine()));
                    break;
                case "4":
                    programOps.viewVehicles();
                    Console.WriteLine(divider);
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            if (option == "5")
            {
                break;
            }
        }
        Console.WriteLine("Have a great day:)");
    }
}