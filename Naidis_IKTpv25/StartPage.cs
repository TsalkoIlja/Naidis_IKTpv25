using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid, Alamfunktsioonid/meetodid");
            //Console.BackgroundColor= ConsoleColor.Green;
            //Console.ForegroundColor= ConsoleColor.Blue;
            string tekst= "Tere tulemast C#-i maailma!";
            Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
            Console.WriteLine("Oli loodud muutuja tekst, mis võrdub: {0}", tekst);
            Console.Write("Mis on sinu nimi?: ");
            string nimi = Console.ReadLine();
            /*Console.Write("Kui vana sa oled?: ");
            try
            {
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);              
            }
            try
            {
                Console.Write("Arv 1: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Arv 2: ");
                float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_funktsioonid.Summa(a, b);
                Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }*/

            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            //1.
            Console.WriteLine(Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);
            //2. 
            tekst = Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv);
            Console.WriteLine(tekst);
            //Juku ja kino
            Console.Write(Osa2_funktsioonid.Juku());//vaikimisi nimi= juku
            Console.Write(Osa2_funktsioonid.Juku(nimi));
            Console.Write(Osa2_funktsioonid.Juku("Python"));
            // Pinginaabrid
            Console.WriteLine("\nPinginaabrid:");
            Console.WriteLine(Osa2_funktsioonid.Pinginaabrid());
            // Ristkülik + remont
            Console.WriteLine("\nRistkülik ja remont:");
            Osa2_funktsioonid.RistkylikJaRemont();
            // 30% soodustusega alghind
            Console.WriteLine("\nAlghinna arvutamine 30% soodustuse järgi:");
            Osa2_funktsioonid.Alghind();
            // Temperatuur
            Console.WriteLine("\nTemperatuuri kontroll:");
            Osa2_funktsioonid.Temperatuur();
            // Pikkus
            Console.WriteLine("\nPikkuse kontroll:");
            Osa2_funktsioonid.Pikkus();
            // Pikkus + sugu
            Console.WriteLine("\nPikkus ja sugu:");
            Osa2_funktsioonid.PikkusJaSugu();
            // Pood
            Console.WriteLine("\nPoe ostude arvutamine:");
            Osa2_funktsioonid.Pood();

            Console.WriteLine("\nKõik ülesanded on lõpule viidud!");

        }
    }
}
