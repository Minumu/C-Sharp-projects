using System;

namespace classes
{
    class Duck
    {
        public Duck(string name, string color, int life)
        {
            Name = name;
            Color = color;
            Life = life;
        }
        public string Color;
        public string Name;
        public int Life;

        public void Fly(string place)
        {
            Console.WriteLine("Flying... " + place + ". Duck name: " + Name + ", duck color: " + Color + ", life is: " + Life);
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Duck johnDuck = new Duck("John", "Black", 2);
            johnDuck.Fly("tree");
            Duck bobDuck = new Duck("Bob", "Blue", 1);
            bobDuck.Color = "white";
            bobDuck.Fly("sky");
        }
    }
}
