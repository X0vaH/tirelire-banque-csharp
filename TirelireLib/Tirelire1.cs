using System;

namespace TirelireLib
{
    public static class Tirelire1
    {
        public static decimal MontantTotal { get; set; }

        public static class Opérations1
        {
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

}
