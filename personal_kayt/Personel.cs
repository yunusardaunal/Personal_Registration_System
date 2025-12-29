using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal_kayt
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        public string Meslek { get; set; }
        public int Maas { get; private set; }
        public bool Durum { get; private set; }

       
        public void MaasBelirle(int maas)
        {
            if (maas >= 0)
            {
                Maas = maas;
            }
        }

        public void DurumBelirle(bool durum)
        {
            Durum = durum;
        }
    }
}



