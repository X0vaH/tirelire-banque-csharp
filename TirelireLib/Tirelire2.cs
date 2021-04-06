
namespace TirelireStatiqueLib
{
    public static class Tirelire2
    {
        public static decimal MontantTotal { get; private set; }

        public static bool Déposer(decimal montant)
        {
            if (montant > 0)
            {
                MontantTotal += montant;
                return true;
            }

            return false;
        }
        public static bool Retirer(decimal montant)
        {
            if (montant > 0 && montant <= MontantTotal)
            {
                MontantTotal -= montant;
                return true;
            }

            return false;
        }
        public static decimal Vider()
        {
            decimal argentTotal = MontantTotal;
            MontantTotal = 0;
            return argentTotal;
        }
    }
}
