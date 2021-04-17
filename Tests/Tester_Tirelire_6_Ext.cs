using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TirelireLib;

namespace Tests
{
    [TestClass, TestCategory("AH")]
    public class Tester_Tirelire_6_Ext
    {

        [TestMethod]
        public void T1_Reset()
        {
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

    }
}
