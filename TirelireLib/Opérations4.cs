
namespace TirelireLib
{
    public static class Opérations4
    {
        public static bool Déposer(this Tirelire4 tirelire, decimal montant)
        {
            if (montant > 0)
            {
                tirelire.MontantTotal += montant;
                return true;
            }

            return false;
        }
        public static bool Retirer(this Tirelire4 tirelire, decimal montant)
        {
            if (montant > 0 && montant <= tirelire.MontantTotal)
            {
                tirelire.MontantTotal -= montant;
                return true;
            }

            return false;
        }
        public static decimal Vider(this Tirelire4 tirelire)
        {
            decimal argentTotal = tirelire.MontantTotal;
            tirelire.MontantTotal = 0;
            return argentTotal;
        }
    }
}
