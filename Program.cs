using System;

namespace ThisReference
{
    public class ThisRef
    {
        public class Thissser
        {
            public string whatever;
            public Thissser(string whatever) {
                this.whatever = whatever;
                Console.WriteLine($"The constructor was called with argument :: {whatever}");
            }
        }
        static void Main(String[] args)
        {
            Thissser Demo = new Thissser("Well this is it!");
            Console.Read();
        }
    }
}