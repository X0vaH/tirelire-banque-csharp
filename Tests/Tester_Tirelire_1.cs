using Microsoft.VisualStudio.TestTools.UnitTesting;

using TirelireLib;

using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static TirelireLib.Tirelire1;

namespace Tests
{
    [TestClass, TestCategory("AH")]
    public class Tester_Tirelire_1
    {
        [TestMethod]
        public void T1_Déposer()
        {
            MontantTotal = 0;
            AreEqual(0, MontantTotal);

            IsFalse(Opérations1.Déposer(0));
            IsFalse(Opérations1.Déposer(-10));

            IsTrue(Opérations1.Déposer(100));
            IsTrue(Opérations1.Déposer(50));

            IsFalse(Opérations1.Déposer(0));
            IsFalse(Opérations1.Déposer(-10));

            AreEqual(150, MontantTotal);
        }

        [TestMethod]
        public void T2_Vider()
        {
            MontantTotal = 0;
            AreEqual(0, Opérations1.Vider());
            IsTrue(Opérations1.Déposer(100));
            AreEqual(100, Opérations1.Vider());
            AreEqual(0, MontantTotal);
            IsTrue(Opérations1.Déposer(500));
            AreEqual(500, Opérations1.Vider());
            AreEqual(0, MontantTotal);
        }

        [TestMethod]
        public void T3_Retirer()
        {
            MontantTotal = 0;
            AreEqual(0, MontantTotal);

            IsFalse(Opérations1.Retirer(0));
            IsFalse(Opérations1.Retirer(-10));
            IsFalse(Opérations1.Retirer(1));

            IsTrue(Opérations1.Déposer(1000));
            IsTrue(Opérations1.Retirer(50));
            IsTrue(Opérations1.Retirer(100));

            IsFalse(Opérations1.Retirer(0));
            IsFalse(Opérations1.Retirer(-10));
            IsFalse(Opérations1.Retirer(851));

            AreEqual(850, MontantTotal);
        }

    }
}
