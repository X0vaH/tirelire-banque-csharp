
namespace TirelireLib
{
    public class Tirelire6
    {
        public decimal MontantTotal { get; set; }

        public bool Déposer(decimal montant)
        {
            if (montant > 0)
            {
                this.MontantTotal += montant;
                return true;
            }

            return false;
        }
        public bool Retirer(decimal montant)
        {
            if (montant > 0 && montant <= this.MontantTotal)
            {
                this.MontantTotal -= montant;
                return true;
            }

            return false;
        }
        public decimal Vider()
        {
            decimal argentTotal = this.MontantTotal;
            this.MontantTotal = 0;
            return argentTotal;
        }
    }
}
