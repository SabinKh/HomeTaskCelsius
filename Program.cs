using System;

namespace Celsius_hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin(500);
            Celsius obj1 = kelvin;
            Console.WriteLine(obj1.Degree);
            
        }
    }
    class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double c)
        {
            Degree = c;
        }
        
    }
    class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin(double k)
        {
            Degree = k;
        }
        public static implicit operator Celsius(Kelvin kk)
        {
            return new Celsius(kk.Degree - 273.15);
        }
    }
}
