
namespace TirelireLib
{
    public class Tirelire5
    {
        public decimal MontantTotal { get; set; }

        public static bool Déposer(Tirelire5 tirelire, decimal montant)
        {
            if (montant > 0)
            {
                tirelire.MontantTotal += montant;
                return true;
            }

            return false;
        }
        public static bool Retirer(Tirelire5 tirelire, decimal montant)
        {
            if (montant > 0 && montant <= tirelire.MontantTotal)
            {
                tirelire.MontantTotal -= montant;
                return true;
            }

            return false;
        }
        public static decimal Vider(Tirelire5 tirelire)
        {
            decimal argentTotal = tirelire.MontantTotal;
            tirelire.MontantTotal = 0;
            return argentTotal;
        }
    }
}
