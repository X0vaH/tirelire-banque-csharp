

using TirelireLib;

namespace TirelireStatiqueLib
{
    public static class Opérations1
    {
        public static bool Déposer(decimal montant)
        {
            if (montant > 0)
            {
                Tirelire1.MontantTotal += montant;
                return true;
            }

            return false;
        }
        public static bool Retirer(decimal montant)
        {
            if (montant > 0 && montant <= Tirelire1.MontantTotal)
            {
                Tirelire1.MontantTotal -= montant;
                return true;
            }

            return false;
        }
        public static decimal Vider()
        {
            decimal argentTotal = Tirelire1.MontantTotal;
            Tirelire1.MontantTotal = 0;
            return argentTotal;
        }
    }
}
