using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using pazienti;

namespace Pazienti_biglietto
{
    public class Pazienti
    {
        static bool[] numeri = new bool[91];
        static Random r = new Random();
        static int estratti = 0;
        public void Estrattore(object lista)
        {
            int n;
            do
            {
                n = r.Next(1, 90);
                if (!numeri[n])
                {
                    dynamic losta = lista;
                    losta.Items.Add($"{n}");
                    numeri[n] = true;
                    ++estratti;
                    Thread.Sleep(1000);
                }
            }
            while (numeri[n] && estratti < 90);
        }

    }






}
