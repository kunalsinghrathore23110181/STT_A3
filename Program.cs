//Constructors and Data Control:

using System;

public class Program
{
    private int data;
    private static int counter = 0;

    public Program()
    {
        counter++;
        Console.WriteLine($"Constructor Called. Active Objects: {counter}");
    }

    ~Program()
    {
        counter--;
        Console.WriteLine($"Object Destroyed. Active Objects: {counter}");
    }

    public void set_data(int x)
    {
        data = x;
    }

    public void show_data()
    {
        Console.WriteLine($"Data = {data}");
    }

    public static void Main(string[] args)
    {
        {
            Program p1 = new Program();
            Program p2 = new Program();
            Program p3 = new Program();

            p1.set_data(10);
            p2.set_data(20);
            p3.set_data(30);

            p1.show_data();
            p2.show_data();
            p3.show_data();
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();
        System.Threading.Thread.Sleep(1000);  // Wait for 1 second


        Console.ReadKey();
    }
}



// To Run the below code do the commenting in the above code and uncomment the below code it will run successfully.





//Inheritance and Method Overriding:

/*using System;

public class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle(int s, int f)
    {
        speed = s;
        fuel = f;
    }

    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving...");
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}");
    }
}

public class Car : Vehicle
{
    int passengers;
    public Car(int s, int f, int p) : base(s, f)
    {
        passengers = p;
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine("Car is moving with passengers...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Passengers: {passengers}");
    }
}

public class Truck : Vehicle
{
    int cargoWeight;
    public Truck(int s, int f, int c) : base(s, f)
    {
        cargoWeight = c;
    }

    public override void Drive()
    {
        fuel -= 15;
        Console.WriteLine("Truck is moving with cargo...");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Speed: {speed}, Fuel: {fuel}, Cargo: {cargoWeight}kg");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Vehicle(60, 100);
        vehicles[1] = new Car(80, 90, 4);
        vehicles[2] = new Truck(50, 120, 2000);

        foreach (Vehicle v in vehicles)
        {
            v.Drive();
            v.ShowInfo();
            Console.WriteLine();
        }
    }
}
*/