
using System;
using System.Text.Json.Serialization;

using TirelireLib;

namespace BanqueLib
{
    public class Compte1 : Tirelire9
    {
        public int Numéro { get; set; }

        public string Titulaire { get; set; }

        [JsonConstructor]
        public Compte1(int numéro, string titulaire, decimal montantTotal = 0)
        {
            if (numéro == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numéro), 0, "trop petit");
            }
            if (numéro < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numéro), -10, "trop petit");
            }
            if (montantTotal < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.MontantTotal), -10m, "trop petit");
            }

            this.Numéro = numéro;
            this.Titulaire = titulaire;
            this.MontantTotal = montantTotal;
        }

        public Compte1(Compte1 autre)
        {
            this.Titulaire = autre.Titulaire;
            this.Numéro = autre.Numéro;
            this.MontantTotal = autre.MontantTotal;
        }

        public override string ToString()
        {
            string message = $"Numéro de compte: {this.Numéro}\n" +
                $"Titulaire: {this.Titulaire}\n" +
                $"Montant total: {this.MontantTotal:C}";
            return message;
        }

        public override bool Equals(object? obj)
            => obj is Compte1 c
            && c.Numéro == this.Numéro
            && c.MontantTotal == this.MontantTotal
            && c.Titulaire == this.Titulaire;

        public override int GetHashCode()
            => HashCode.Combine(this.Numéro, this.MontantTotal, this.Titulaire);
    }
}
