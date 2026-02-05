using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class Osa2_funktsdioonid
    {
        public static string Juku(string nimi="Juku")
        {
            string otsus = "";
            string vastus = "";
            int vanus = 0;
            string pilet = "";
            Console.WriteLine("Mis on sinu nimi?       ");
            string nimi = Console.ReadLine();
            if (nimi.ToLower() =="juku")
            {
                Console.Write("Kui vana sa oled?:");
                try
                {
                    vanus = int.Parse(Console.ReadLine());
                    if (vanus > 0 && vanus<100)
                    {
                        if (vanus<6)
                        {
                            pilet = "Sulle on kinopilet tasuta"
                        }
                        pilet = "Sulle on kinopilet on lastepilet! ";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine
                }

                otsus = "Lähme kinno! {pilet}";
            }

            else
            {
                otsus = "Ma olen võivatud";
            }
            vastus = $"Tere {nimi}, {otsus}";
                return vastus;
        }
    }
}
