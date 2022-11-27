Car.TestMethod();
public class Car
{
  string color = "red"; 
    public static void TestMethod()
    {
        Car myObj = new Car(); 	
		Console.WriteLine(myObj.color);
    }
}