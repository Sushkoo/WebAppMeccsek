namespace WebApplication1.Models
{
    public class CsapatEredmenyei
    {
        public string CsapatNev { get; set; }
        public int Gyozelmek { get; set; }
        public int Dontetlenek { get; set; }
        public int Veresegek { get; set; }
        public int RugottGol { get; set; }
        public int KapottGol { get; set; }

        public int JatszottMeccsekSzama { get => Gyozelmek + Veresegek + Dontetlenek; }

        public int GolKulonbseg { get => RugottGol - KapottGol * Dontetlenek; }
    }
}
