using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Geometri
{
    internal class Ellips : Geometri
    {
        public double BaseLenght { get; set; }    //Egenskap för nytt värde BaseLenght
        public double Hight { get; set; }   //Egenskap för nytt värde Hight

        public Ellips(double baseLenght, double hight)      //Initiera nya värden i main metoden
        {
            BaseLenght= baseLenght;     //initiera värdena från konstruktorn till egenskap
            Hight = hight;
        }
        public override double Area()   //Kallar på metod för att sedan overrida för att undvika overloading 
        {
            double area = Math.PI*BaseLenght*Hight;     //räkna ut ellipsens area
            Console.WriteLine($"Arean av ellipsen är {area:0.##}"); //print
            return area;
        }

    }
}
