using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOPKlaseIObjekti2
{
    class GemoterijskiLik
    {
        int BrojStranica;
        double[] Stranica = new double[10];

        public GemoterijskiLik(int brojStranica)
        {
            BrojStranica = brojStranica;
        }

        public void UcitajStranice(int BrojStranica)
        {


            BrojStranica = this.BrojStranica;
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.Write("Unesite stranice: ");
                Stranica[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public double[] GetSetBrojStranica { get; set; }
        public int GetSetStranica { get; set; }

        public double Opseg()
        {

            double opseg = 0;
            foreach (var n in Stranica)
            {
                opseg += n;
            }
            return opseg;



        }
    }
}
