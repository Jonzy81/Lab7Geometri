using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lab7Geometri
{
    internal class Fyrkant : Geometri
    {
        public double Lenght { get; set; }  //Egenskap för nya värdet Lenght
        public Fyrkant(double lenght)   //Konstruktor för att kunna initiera värdet Lenght i main metoden 
        {
            Lenght = lenght;    //tilldela värdet till egenskapen 
        }

        public override double Area()       //Overrida för att undvika overloading
        {
            double area = Lenght * Lenght;  //räkna ut arean 
            Console.WriteLine($"Arean av fyrkanten är {area:0.##}");    //print
            return area;    //return area 
        }
    }
}
