using System;

namespace ThisReference
{
    public class ThisRef
    {
        public class A
        {
            public string whatstring = "Default value";
            public void WhatMethod()
            {
                Console.WriteLine($"Coming from class A, what string: {whatstring}!");
            }
        }
        public class B : A
        {
            public void setstring (string newvalue)
            {
                whatstring = newvalue;
            }
        }
        static void Main(String[] args)
        {
            B c = new B();
            Console.WriteLine($"Default value of whatstring: {c.whatstring} coming from class A!");
            c.setstring("New Value");
            Console.WriteLine($"Calling inherited method of WhatMethod: c.setstring() with result of: {c.whatstring}");
            Console.Read();
        }
    }
}