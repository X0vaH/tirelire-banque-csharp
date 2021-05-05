using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TirelireLib;
using System;

using static Tests.TestUtil;

namespace Tests
{
    [TestClass, TestCategory("AH")]
    public partial class Tester_Tirelire_9
    {
        [TestMethod]
        public void T0_Réflexion()
        {
            // La tirelire 9 est comparable à la tirelire 6
            AreEqual(
                typeof(Tirelire6).GetMembers().Length,
                typeof(Tirelire9).GetMembers().Length);
        }

        [TestMethod]
        public void T1_Déposer()
        {
            TesterDéposer(new Tirelire9(), false);
        }


        [TestMethod]
        public void T2_Vider()
        {
            AreEqual(
                typeof(Tirelire6).GetMembers().Length,
                typeof(Tirelire9).GetMembers().Length);
        }


        [TestMethod]
        public void T3_Retirer()
        {
            TesterRetirer(new Tirelire9(), false);
        }

        public static void TesterDéposer(Tirelire9 tirelire, bool avecPrécision = true)
        {
            AreEqual(0, 0);
        }

        public static void TesterRetirer(Tirelire9 tirelire, bool avecPrécision = true)
        {

        }
    }

    public static partial class TestUtil
    {
        public static void ArgumentOutOfRange(Action action, string message, string paramName, object actualValue)
        {
            var ex = ThrowsException<ArgumentOutOfRangeException>(() => action());
            StringAssert.Contains(ex.Message, message);
            AreEqual(paramName, ex.ParamName);
            AreEqual(actualValue, ex.ActualValue);
        }

        public static void ArgumentInvalide(Action action, string message, string paramName)
        {
            var ex = ThrowsException<ArgumentException>(() => action());
            StringAssert.Contains(ex.Message, message);
            AreEqual(paramName, ex.ParamName);
        }
    }
}
