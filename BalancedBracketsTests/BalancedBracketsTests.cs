using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(true, true);
        //}

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OnlyBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void ReturnsFalseWhenNoBrackets() // When str has no brackets, confirm that HasBalancedBrackets() returns false.
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Hunter smells funny."));
        }

        [TestMethod]
        public void ReturnsFalseWhenBracketsInverted() // When str has "Launch]Code[" brackets, confirm return false.
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        //[TestMethod]
        //[ExpectedArgument]
        //public void ThrowsExceptionWhenOtherThanStringPassed()
        //{
        //    UnitTestAssertException(BalancedBrackets.HasBalancedBrackets(0));
        //}
    }
}
