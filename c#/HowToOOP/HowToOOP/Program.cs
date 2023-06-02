public class Program
{
    public class Animal
    {
        protected bool Hart { get; set; }
        public virtual bool fetchHart() { return Hart; }
    }

    public class Dog : Animal
    {
        protected bool Fur { get; set; }
        public bool Eyes { get; set; }
    }

    public class Lab : Dog
    {
        public ConsoleColor Color { get; set; }
    }

    //Jo mere vi nedarver, jo mere specialisere vi klassen, jo mindre jo mere generalisere vi

    static void Main(string[] args)
    {
        Animal a = new Lab();
        ((Lab)a).Color = ConsoleColor.Green;
        Console.WriteLine();
    }
}