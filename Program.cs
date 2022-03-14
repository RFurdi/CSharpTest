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

            string upisaniTekst = "";
            bool pocetnitekst = true;

            Automobil automobil = new Automobil();

            while (pocetnitekst)
            {
                Console.WriteLine("1. Unos automobila." +
                "\n2. Ispis unesenos automobila." +
                "\n3. Starost automobila." +
                "\n4. Ukupna cijena automobila." +
                "\n5. Promjena godine proizvodnje automobila." +
                "\n6. Exit");
                upisaniTekst = Console.ReadLine();

                if (upisaniTekst == "1")
                {
                    string nazivautomobila = null;
                    string godinaautomobila = null;
                    string cijenaautomobila = null;

                    while (nazivautomobila == null || !nazivautomobila.All(char.IsLetter))
                    {
                        Console.WriteLine("Naziv automobila:");
                        nazivautomobila = Console.ReadLine();

                    }
                    automobil.naziv = nazivautomobila;
                    while (godinaautomobila == null || !godinaautomobila.All(char.IsNumber))
                    {
                        Console.WriteLine("Godina proizvodnje automobila:");
                        godinaautomobila = Console.ReadLine();

                    }
                    automobil.godinaProizvodnje = int.Parse(godinaautomobila);
                    while (cijenaautomobila == null || !cijenaautomobila.All(char.IsNumber))
                    {
                        Console.WriteLine("Osnovna cijena automobila:");
                        cijenaautomobila = Console.ReadLine();

                    }
                    automobil.osnovnaCijena = double.Parse(cijenaautomobila);
                }
                else if (upisaniTekst == "2")
                {
                    //Ispis unesenog automobila.
                    string uneseniAutomobil = $"Naziv automobila:{automobil.naziv}." +
                        $"\nGodina proizvodnje automobila:{automobil.godinaProizvodnje}." +
                        $"\nOsnovna cijena automobila:{automobil.osnovnaCijena}.";
                    Console.WriteLine(uneseniAutomobil);
                }
                else if (upisaniTekst == "3")
                {
                    //Ispis starosti automobila.
                    string starostAutomobila = $"Automobil je star:{automobil.IzracunajStarost()} godina.";
                    Console.WriteLine(starostAutomobila);
                }
                else if (upisaniTekst == "4")
                {
                    //Ispis ukupne cijene automobila.
                    string ukupnaCijena = $"Ukuna cijena automobila je:{automobil.UkupnaCijena()}.";
                    Console.WriteLine(ukupnaCijena);
                }
                else if (upisaniTekst == "5")
                {
                    string godinaautomobila = null;
                    while (godinaautomobila == null || !godinaautomobila.All(char.IsNumber))
                    {
                        Console.WriteLine("Promjena godine proizvodnje automobila:");
                        godinaautomobila = Console.ReadLine();

                    }
                    automobil.godinaProizvodnje = int.Parse(godinaautomobila);
                }
                else if (upisaniTekst == "6")
                {
                    //Izlaz iz programa.
                    Environment.Exit(0);
                }
            }

        }
    }
}





