
namespace TirelireLib
{
    public static class Opérations3
    {
        public static bool Déposer(Tirelire3 tirelire, decimal montant)
        {
            if (montant > 0)
            {
                tirelire.MontantTotal += montant;
                return true;
            }

            return false;
        }
        public static bool Retirer(Tirelire3 tirelire, decimal montant)
        {
            if (montant > 0 && montant <= tirelire.MontantTotal)
            {
                tirelire.MontantTotal -= montant;
                return true;
            }

            return false;
        }
        public static decimal Vider(Tirelire3 tirelire)
        {
            decimal argentTotal = tirelire.MontantTotal;
            tirelire.MontantTotal = 0;
            return argentTotal;
        }
    }
}
