using System;
namespace ThisReference
{
    public class ThisRef
    {
        public class SampleClass {
            public string SampleProperty { get; set; }
            public string SampleMethod(string message)
            {
                return $"This is the message: {message}";
            }
        }
        static void Main(String[] args)
        {
            SampleClass test = new SampleClass();
            test.SampleProperty = "Pluralsight";
            Console.WriteLine($"This is the value of the SampleProperty: {test.SampleProperty}");
            Console.WriteLine($"This is the message from the SampleMethod: {test.SampleMethod("This is cool")}");
            Console.Read();
        }
    }
}