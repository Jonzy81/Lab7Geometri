using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Geometri
{
    internal class Parallellogram : Geometri
    {
        public double Hight { get; set; }       //Nya egenskaper Hight och Lenght
        public double BaseLenght { get; set; }

        public Parallellogram(double hight, double baseLenght)  //Initiera värden till konstruktorn i main metoden 
        {
            Hight = hight;      //Tilldela värden till egenskap 
            BaseLenght = baseLenght;
        }
        public override double Area()       //Override för att undvika overload
        {
            double area = BaseLenght * Hight;   //räkna ut arean
            Console.WriteLine($"Arean av parallellogrammet är {area:0.##}");    //print
            return area;
        }
    }
}
