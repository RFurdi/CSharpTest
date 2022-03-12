using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    internal class Program 
    {
        static void Main(string[] args)
        {
        
                bool menu = true;
                string odabir;

                Automobil automobil = new Automobil();

                while (menu)
                {
                    Console.WriteLine(
                        "1. Unos automobila." +
                        "\n2. Ispis unesenos automobila." +
                        "\n3. Starost automobila." +
                        "\n4. Ukupna cijena automobila." +
                        "\n5. Promjena godine proizvodnje automobila." +
                        "\n6. Exit");
                    odabir = Console.ReadLine();

                    if (odabir == "1")
                    {
                        //Unos automobila.
                        Console.WriteLine("Naziv automobila:");
                        automobil.naziv = Console.ReadLine();

                        //Unos godine proizvodnje automobila.
                        Console.WriteLine("Godina proizvodnje automobila:");
                        automobil.godinaProizvodnje = Convert.ToInt32(Console.ReadLine());

                        //Unos Osnovne cijene automobila.
                        Console.WriteLine("Osnovna cijena automobila je:");
                        automobil.osnovnaCijena = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Automobil uspjesno unesen!");
                    }

                    else if (odabir == "2")
                    {
                        //Ispis unesenog automobila.
                        string uneseniAutomobil = $"Naziv automobila:{automobil.naziv}." +
                            $"\nGodina proizvodnje automobila:{automobil.godinaProizvodnje}." +
                            $"\nOsnovna cijena automobila:{automobil.osnovnaCijena}.";
                        Console.WriteLine(uneseniAutomobil);
                    }
                    else if (odabir == "3")
                    {
                        //Ispis starosti automobila.
                        string starostAutomobila = $"Automobil je star:{automobil.IzracunajStarost()} godina.";
                        Console.WriteLine(starostAutomobila);
                    }
                    else if (odabir == "4")
                    {
                        //Ispis ukupne cijene automobila.
                        string ukupnaCijena = $"Ukuna cijena automobila je:{automobil.UkupnaCijena()}.";
                        Console.WriteLine(ukupnaCijena);
                    }
                    else if (odabir == "5")
                    {
                        //Promjena godine proizvodnje automobila.
                        Console.WriteLine("Promjena godine proizvodnje");
                        automobil.godinaProizvodnje = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (odabir == "6")
                    {
                        //Izlaz iz programa.
                        Environment.Exit(0);
                    }
                }
        }

    }
}
    

