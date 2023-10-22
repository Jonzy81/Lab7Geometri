namespace Lab7Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonny Touma NET23 uppgift 07 polymorphism

            Fyrkant square=new Fyrkant(4.0);    //skapa en instans av klassen fyrkant och tilldela värden till konstruktorn 
            square.Area();              //anropa metoden 

            Ellips ellips = new Ellips(4, 8);
            ellips.Area();

            Parallellogram parell = new Parallellogram(6, 9);
            parell.Area();

            Cirkel circle = new Cirkel(3.4);
            circle.Area();

            Rektangel rectangle = new Rektangel(2.7, 9);
            rectangle.Area();

            
        }
    }
}