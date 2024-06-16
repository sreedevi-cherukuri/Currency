using Microsoft.VisualStudio.TestTools.UnitTesting;
using Currency;
using System.Runtime.CompilerServices;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CurrencyDenominations denominations = new CurrencyDenominations(14.5);
            int[] noteDenomiations = denominations.noteDenominations;
            Assert.AreEqual(2, noteDenomiations[5]);
            Assert.AreEqual(1, noteDenomiations[3]);
            int[] coinDenominations = denominations.coinsDenominations;
            Assert.AreEqual(1, coinDenominations[0]);
        }
    }
}