using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class Automobil
    {


        public Automobil()
        {


        }
        public string naziv;
        public int godinaProizvodnje;
        public double osnovnaCijena;


        public int IzracunajStarost()
        {
            int starost = DateTime.Now.Year - godinaProizvodnje;
            return starost;
        }

        public double UkupnaCijena()
        {
            double ukupnaCijena;
            if (osnovnaCijena <= 70000)
            {

                ukupnaCijena = osnovnaCijena * 1.3;
                return ukupnaCijena;
            }
            else if (70000 < osnovnaCijena && osnovnaCijena < 100000)
            {
                ukupnaCijena = osnovnaCijena * 1.4;
                return ukupnaCijena;
            }
            else if (osnovnaCijena >= 100000)
            {
                ukupnaCijena = osnovnaCijena * 1.5;
                return ukupnaCijena;
            }
            else
            {
                return 0;
            }

        }



    }
}
