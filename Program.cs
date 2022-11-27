Car.Suv();
class Car
{
  string model;
    public Car()
    {
        model = "Mustang";
    }
    public static void Suv()
    {
        Car Ford = new Car();
        Console.WriteLine(Ford.model);       
    }
}
