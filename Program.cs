Car.Suv();
class Car
{
  public string model;
  public string color;
  public int year;
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
    public static void Suv()
    {
        Car Ford = new Car("Mustang", "Red", 1969);
        Car Opel = new Car("Astra", "White", 2005);
        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);     
    }
}
