using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DZ_c_diez_7710
{
    public delegate void Action();
    public class Flower:IFlower
    {
        public string NomeFlower { get; set; }
        public double Altezza { get; set; }
        public int Salute { get; set; }
        public event Action SaluteChanged;
        public event Action FlowerGrowthEvent;
        public Flower() { }
        public Flower(string N,double Al,int Sal)
        {
            NomeFlower = N;Altezza = Al;Salute = Sal;
        }
        public void LivelloSalute()
        {
            Random rn=new Random();
            int d = rn.Next(-100, 100);
            Salute += d;
            Console.WriteLine(" Здоровье цветка " + NomeFlower + " = " + Salute);
        }
        public void LivAltezza()
        {
            Random rn1= new Random();
            double d1=rn1.Next(1,30);
            Altezza += d1;
            FlowerGrowthEvent?.Invoke();
            
            Console.WriteLine(" Высота цветка " + NomeFlower + " = " + Altezza);
        }
        public void MostraInfo()
        {
            Console.WriteLine(" : : : : : : : ");
            Console.WriteLine(" Имя : " + NomeFlower + "\n Высота : " + Altezza + "\n Уровень здоровья : " + Salute);
        }
        public void SSS()
        {
            SaluteChanged = () => Console.WriteLine("Растение полито. ");
            SaluteChanged?.Invoke();
        }
        public void PPP()
        {
            SaluteChanged = () => Console.WriteLine("Растение удобрено. ");
            SaluteChanged?.Invoke();
        }
    }
}
