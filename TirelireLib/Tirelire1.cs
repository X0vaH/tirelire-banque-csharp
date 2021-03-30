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
                    return true;
                }

                return false;
            }
            public static bool Retirer(decimal montant)
            {
                if (montant >= 0 && montant <= MontantTotal)
                {
                    return true;
                }

                return false;
            }
            public static bool Vider()
            {
                return true;
            }
        }

    }

}
