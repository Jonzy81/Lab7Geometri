using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Geometri
{
    internal class Cirkel :Geometri
    {
        public double Radius { get; set; }      //Ny egenskap Radius

        public Cirkel(double radius)        //Initiera värde i konstruktor som kan tilldelas i main 
        {
            Radius = radius;        //tilldela värdet till egenskaen 
        }
        public override double Area()       //Override för at undvika overload 
        {
            double area= Math.PI*Math.Pow(Radius,2);        //räkna ut arean 
            Console.WriteLine($"Arean av cirkeln är {area:0.##}");  //Print och begränsar kommatecken 
            return area;
        }
    }
}
