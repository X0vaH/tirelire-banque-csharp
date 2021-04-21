
using System;

namespace TirelireLib
{
    public class Tirelire9
    {
        public decimal MontantTotal { get; set; }

        public void Déposer(decimal montant)
        {
            if (montant <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), montant, "Trop petit");
            }
            else
            {
                this.MontantTotal += montant;
            }
        }
        public void Retirer(decimal montant)
        {
            if (montant > this.MontantTotal)
            {
                throw new ArgumentOutOfRangeException(nameof(montant), montant, "Trop grand");
            }
            if (montant <= 0)
            {
                throw new ArgumentException("Trop petit", nameof(montant));
            }
            this.MontantTotal -= montant;
        }
        public decimal Vider()
        {
            decimal argentTotal = this.MontantTotal;
            this.MontantTotal = 0;
            return argentTotal;
        }
    }
}
