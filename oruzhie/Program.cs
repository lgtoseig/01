using System;

namespace oruzhie
{
    class Weapon
    {
        public string name;    // название
        public float caliber;  // калибр
        public double range;   // дальность


        public Weapon(string name, float caliber, double range)
        {
            this.name = name;
            this.caliber = caliber;
            this.range = range;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Оружие: {name}, Калибр: {caliber}мм, Дальность: {range}м");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Weapon myGun = new Weapon("АК-74", 5.45f, 1000.0);

            Console.WriteLine("--- Информация об оружии ---");
            myGun.ShowInfo();

            Console.ReadKey();
        }
    }
}