using System;

namespace ThisReference
{
    public class ThisRef
    {
        public class PolyMomo
        {
            public string PropertyOne = "DefaultOne";
            public string PropertyTwo = "DefaultTwo";

            public void Properties(string one, string two)
            {
                PropertyOne = one;
                PropertyTwo = two;
            }

            public void Properties(string onlyFirst)
            {
                PropertyOne = onlyFirst;
            }
        }
        static void Main(String[] args)
        {
            PolyMomo Demo = new PolyMomo();
            Console.WriteLine($"Property values before change, PropertyOne: {Demo.PropertyOne}, PropertyTwo: {Demo.PropertyTwo}");
            Demo.Properties("first", "second");
            Console.WriteLine($"Both properties were changed PropertyOne: {Demo.PropertyOne}, and PropertyTwo: {Demo.PropertyTwo}");
            PolyMomo DemoTwo = new PolyMomo();
            Console.WriteLine($"Property value before change, PropertyOne: {Demo.PropertyOne}!");
            DemoTwo.Properties("OnlyFirst");
            Console.WriteLine($"Only first property was changed to: {DemoTwo.PropertyOne}");
            Console.Read();
        }
    }
}