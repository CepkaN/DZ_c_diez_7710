namespace DZ_c_diez_7710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garden gard=new Garden();
            Flower flo1 = new Flower(" Цветок 1 ", 32.3, 32);
            Flower flo2 = new Flower(" Цветок 2 ", 101, 39);
            Flower flo3 = new Flower(" Цветок 3 ", 77.3, 88);
            Flower flo4 = new Flower(" Цветок 4 ", 12, 50);
            gard.Add(flo1);
            gard.Add(flo2);
            gard.Add(flo3);
            gard.Add(flo4);
            gard.FFF();
            
        }
    }
}