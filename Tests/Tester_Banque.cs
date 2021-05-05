using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using BanqueLib;

using System;
using System.Linq;

using static Tests.TestUtil;
using System.Collections.Generic;

namespace Tests
{
    [TestClass, TestCategory("AH")]
    public partial class Tester_Banque
    {

        [TestMethod]
        [DataRow("Machin")]
        [DataRow("Truc")]
        public void T1_Construction_Avec_Nom(string nom)
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow(null)]
        public void T1e_Construction_Avec_Nom_Erroné()
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        [DataRow(1, 2, 1, 1)]
        [DataRow(2, 3, 3, 2)]
        [DataRow(3, 6, 7, 3)]
        [DataRow(4, 9, 15, 4)]
        [DataRow(5, 11, 31, 4, 1, 16)]
        [DataRow(6, 14, 63, 4, 2, 48)]
        [DataRow(7, 15, 127, 4, 3, 112)]
        [DataRow(8, 16, 127, 4, 3, 112, 1)]
        [DataRow(9, 20, 127, 4, 3, 112, 2)]
        public void T2_Construction_Avec_Comptes(int nb, int prochain,
            int actifTotal, int nbActifs, int nbGelés = 0,
            int actifGelé = 0, int nbFermés = 0)
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        public void T2b_Construction_Avec_Comptes_Désordonnés()
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        public void T2c_Construction_Avec_Comptes_Clonés()
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        public void T2e_BONUS_Construction_Avec_Doublons()
        {
            AreEqual(0, 1);
        }


        [TestMethod]
        public void T3_Ouvrir_Compte()
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void T3e_Ouvrir_Compte_Titulaire_Erroné(string titulaire)
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void T3f_Ouvrir_Compte_Montant_Erroné(int miseDeFond)
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        public void T4_Détruire_Compte()
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        [DataRow(20)]
        [DataRow(3)]
        public void T4e_Détruire_Compte_Numéro_Erroné(int numéro)
        {
            AreEqual(0, 1);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(13)]
        public void T4f_Détruire_Compte_Pas_Fermé(int numéro)
        {
            AreEqual(0, 1);
        }


        [TestMethod]
        [DataRow(1, 1.27)]
        [DataRow(10, 12.7)]
        [DataRow(100, 127)]
        [DataRow(1, 1.2, 3)]
        [DataRow(10, 12, 3)]
        [DataRow(1, 0, 7)]
        [DataRow(10, 0, 7)]
        public void T5_Verser_Intérêts(int pourcentage, double intérêtsAttendus, int nbVidés = 0)
        {
            AreEqual(0, 1);
        }


        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void T5e_Verser_Intérêts_Pourcentage_Erroné(int pourcentage)
        {
            AreEqual(0, 1);
        }


    }
}
