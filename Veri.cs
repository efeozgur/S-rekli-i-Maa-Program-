using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sürekli_İşçi_Maaş_Programı
{
    class Veri
    {
        public string personelAdSoyad { get; set; }
        public string tcKimlikNo { get; set; }
        public string meslek { get; set; }
        public string personelIbanNo { get; set; }
        public string ogrenimDurumu { get; set; }
        public double AGIFazlalikOrani { get; set; }
        public string esDurumu { get; set; }
        public int cocukSayisi { get; set; }
        public string sigortaSicilNo { get; set; }
        public string iseGirisTarihi { get; set; }
        public string istenCikisTarihi { get; set; }
        public string istenCikisNedeni { get; set; }
        public int sendikaDurumu { get; set; }
        public string engellilikDurumu { get; set; }
        public string bes { get; set; }
        public string kefalet { get; set; }
        public IcraBorcu icraBorcu { get; set; }

    }
}
