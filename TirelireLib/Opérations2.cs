
namespace TirelireLib
{
    public static class Opérations2
    {
        public static bool Déposer(decimal montant)
        {
            if (montant > 0)
            {
                Tirelire2.MontantTotal += montant;
                return true;
            }

            return false;
        }
        public static bool Retirer(decimal montant)
        {
            if (montant > 0 && montant <= Tirelire2.MontantTotal)
            {
                Tirelire2.MontantTotal -= montant;
                return true;
            }

            return false;
        }
        public static decimal Vider()
        {
            decimal argentTotal = Tirelire2.MontantTotal;
            Tirelire2.MontantTotal = 0;
            return argentTotal;
        }
    }
}
