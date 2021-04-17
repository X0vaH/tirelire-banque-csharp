using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TirelireLib;

namespace Tests
{
    [TestClass, TestCategory("AH")]
    public class Tester_Tirelire_6_Plus
    {

        [TestMethod]
        public void T0_Réflexion()
        {
            // La tirelire 6 plus compte un membre de plus que la tirelire 6. 
            var tirelire = new Tirelire6();
            AreEqual(0, tirelire.MontantTotal);

            AreEqual(0, tirelire.Vider());
            IsTrue(tirelire.Déposer(100));
            AreEqual(100, tirelire.Vider());
            AreEqual(0, tirelire.MontantTotal);
            IsTrue(tirelire.Déposer(500));
            AreEqual(500, tirelire.Vider());
            AreEqual(0, tirelire.MontantTotal);
        }

        [TestMethod]
        public void T1_Init()
        {
            var tirelire = new Tirelire6();
            AreEqual(0, tirelire.MontantTotal);
        }

    }
}
