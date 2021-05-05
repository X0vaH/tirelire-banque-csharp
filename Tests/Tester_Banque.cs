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
            AreEqual(0, 0);
        }

        [TestMethod]
        public void T1e_Construction_Avec_Nom_Erroné()
        {
            AreEqual(0, 0);
        }

        [TestMethod]
        [DataRow("Machin")]
        [DataRow("Truc")]
        [DataRow("Machin")]
        [DataRow("Truc")]
        public void T2_Construction_Avec_Comptes(string nom)
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
            AreEqual(0, 0);
        }

        [TestMethod]
        public void T2b_Construction_Avec_Comptes_Désordonnés()
        {
            AreEqual(0, 0);
        }

        [TestMethod]
        [DataRow("Machin")]
        [DataRow("Truc")]
        [DataRow("Machin")]
        [DataRow("Truc")]
        [DataRow("Machin")]
        [DataRow("Truc")]
        public void T2c_Construction_Avec_Comptes_Clonés(string nom)
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
        }

        [TestMethod]
        [DataRow("Machin")]
        [DataRow("Truc")]
        public void T2e_BONUS_Construction_Avec_Doublons(string nom)
        {
            AreEqual(0, 0);
        }


        [TestMethod]
        public void T3_Ouvrir_Compte()
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
            AreEqual(0, 0);
            AreEqual(0, 0);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void T3e_Ouvrir_Compte_Titulaire_Erroné(string titulaire)
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void T3f_Ouvrir_Compte_Montant_Erroné(int miseDeFond)
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
        }

        [TestMethod]
        [DataRow("Machin")]
        [DataRow("Truc")]
        public void T4_Détruire_Compte(string nom)
        {
            AreEqual(0, 0);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        [DataRow(20)]
        [DataRow(3)]
        public void T4e_Détruire_Compte_Numéro_Erroné(int numéro)
        {
            AreEqual(0, 0);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(13)]
        public void T4f_Détruire_Compte_Pas_Fermé(int numéro)
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
            AreEqual(0, 0);
            AreEqual(0, 0);
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
            AreEqual(0, 0);
            AreEqual(0, 0);
        }


        [TestMethod]
        [DataRow(-1)]
        [DataRow(-10)]
        public void T5e_Verser_Intérêts_Pourcentage_Erroné(int pourcentage)
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
        }


    }
}
