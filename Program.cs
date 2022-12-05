using System;  
namespace CSharpFeatures  
{  
    public class Student  
    {  
        // Creating dynamic property  
        public dynamic Name { get; set; }  
        // Creating a dynamic method  
        public dynamic ShowMSG(string msg)  
        {  
            return msg;  
        }  
    }  
    public class DynamicExample  
    {  
        public static void Main(string[] args)  
        {  
            Student student = new Student();  
            student.Name = "MILAN";  
            Console.WriteLine(student.Name);  
            // Storing result in dynamic object  
            dynamic msg = student.ShowMSG("Welcome to the Bajra");  
            Console.WriteLine(msg);  
        }  
    }  
}  