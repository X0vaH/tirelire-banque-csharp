using System.Collections.Generic;

namespace Tests
{
    internal class Banque
    {
        public string Nom { get; internal set; }
        public int ProchainNuméroDeCompte { get; internal set; }
        public IEnumerable<Compte3> Comptes { get; internal set; }
        public decimal ActifTotal { get; internal set; }
        public decimal ActifGelé { get; internal set; }
        public int NbComptes { get; internal set; }
        public int NbActifs { get; internal set; }
        public int NbGelés { get; internal set; }
    }
}