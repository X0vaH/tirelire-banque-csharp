using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TirelireLib;

namespace Tests
{
    [TestClass, TestCategory("AH")]
    public class Tester_Actif
    {


        [TestMethod]
        public void T1_ActifDeBase()
        {
            IsTrue(typeof(ActifDeBase).IsAbstract);
            var tirelire = new Tirelire9();
        }

        [TestMethod]
        public void T2_ActifVidable()
        {
            var tirelire = new Tirelire9();
        }

        [TestMethod]
        public void T3_Héritage_Tirelire5()
        {
            IsTrue(new Tirelire5() is ActifDeBase);
        }

        [TestMethod]
        public void T4_Héritage_Tirelire6()
        {
            IsTrue(new Tirelire6() is ActifDeBase);
        }

        [TestMethod]
        public void T5_Héritage_Tirelire9()
        {
            IsTrue(new Tirelire9() is ActifDeBase);
        }

    }
}
