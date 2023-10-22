using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Geometri
{
    internal class Rektangel : Geometri
    {
        public double Hight { get; set; }       //Skapar två nya egenskaper till klassen 
        public double BaseLenght { get; set; }

        public Rektangel(double hight, double baseLenght)   //initialiserar värden i konstruktorn som kan senare tilldelas i main
        {
            Hight = hight;      //tilldelar värden till egenskap 
            BaseLenght = baseLenght;
        }

        public override double Area()       //override för att unvika overload 
        {
            double area =Hight*BaseLenght;  //räkna ut arean 
            Console.WriteLine($"Arean av rektangeln är {area:0.##}");   //
            return area;
        }

        
    }
}
