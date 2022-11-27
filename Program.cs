Car.TestMethod();
public class Car
{
  string color = "red"; 
    public static void TestMethod()
    {
        Car myObj1 = new Car(); 
		Car myObj2 = new Car(); 
		Console.WriteLine(myObj1.color); 
		Console.WriteLine(myObj2.color); 
    }
}