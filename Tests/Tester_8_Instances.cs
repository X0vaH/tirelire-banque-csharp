using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System.Reflection;
using System.Linq;

namespace Tests
{
    [TestClass, TestCategory("AH")]
    public class Tester_8_Instances
    {


        [TestMethod]
        public void T1_Singleton_NonStatique()
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
        }

        [TestMethod]
        public void T2_GetInit()
        {
            AreEqual(0, 0);
            AreEqual(0, 0);
            AreEqual(0, 0);
        }



    }
}
