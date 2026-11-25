
enum FuelType
{
    Petrol,
    Diesel,
    Electric
}
class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public FuelType Fuel { get; set; }
    public static int Count { get; private set; } = 0;
    public Vehicle(string brand, string model, int year, FuelType fuel)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Fuel = fuel;
        Count++;
    }
    public virtual void StartEngine()
    {
        Console.WriteLine($"{Brand} {Model}: Vehicle engine started.");
    }
    public string Info()
    {
        return $"{Brand} {Model} ({Year}, {Fuel})";
    }
}
class Car : Vehicle
{
    public Car(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }
    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} {Model}: Car engine started smoothly.");
    }
}
class Truck : Vehicle
{
    public Truck(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }
    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} {Model}: Heavy-duty truck engine roaring!");
    }
}
class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }
    public override void StartEngine()
    {
        Console.WriteLine($"{Brand} {Model}: Motorcycle engine revving!");
    }
}
class Program
{
    static void Main()
    {
        Vehicle[] fleet = new Vehicle[]
        {
            new Car("Togg", "T10X", 2024, FuelType.Electric),
            new Truck("Ford", "F-MAX", 2023, FuelType.Diesel),
            new Motorcycle("Yamaha", "MT-07", 2022, FuelType.Petrol)
        };

        Console.WriteLine($"Total Vehicles Created: {Vehicle.Count}\n");

        foreach (Vehicle v in fleet)
        {
            Console.WriteLine(v.Info());
            v.StartEngine();
            Console.WriteLine();
        }
    }
}