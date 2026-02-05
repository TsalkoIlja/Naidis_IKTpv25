using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string [] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüüpid, Alamfunktsioonid/meetodid");
            string tekst = "Tere tulemast C3-i maailma!";
            Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
            Console.WriteLine("Oli loodud muutuja tekst, mis võrdub: {0}", tekst);
            //Console.Write("Mis on sinu nimi?");

            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            Console.WriteLine(Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv));
            
           
            //try
            //{
            //    int vanus = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.Write("Arv 1: ");
            //float a = float.Parse(Console.ReadLine());
            //Console.Write("Arv 2:");
            //float b = float.Parse(Console.ReadLine());
            //float vastus = Naidis_funktsioonid.Summa(a, b);
            //Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");

            //try
            //{

            //}
             
            //catch (Exception e)

            //{ 
            //Console.WriteLine(e);
            //}


        }
    }
}
