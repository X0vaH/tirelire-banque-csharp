
namespace TirelireLib
{
    public class Tirelire6 : ActifDeBase
    {

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
