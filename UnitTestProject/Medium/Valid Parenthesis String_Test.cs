using LeetCode.Medium;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class Valid_Parenthesis_String_Test
    {
        private IValid_Parenthesis_String validate;

        [SetUp]
        public void InitializeOperands()
        {
            validate = new Valid_Parenthesis_String();
        }

        #region IsTrue
       
        [Test]
        public void TestMethod1_IsTrue()
        {
            string input = "((*))";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod2_IsTrue()
        {
            string input = "((*)";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod3_IsTrue()
        {
            string input = "(*))";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod4_IsTrue()
        {
            string input = "*((**))*";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod5_IsTrue()
        {
            string input = "((*)*)*";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod6_IsTrue()
        {
            string input = "*(*(*))";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod7_IsTrue()
        {
            string input = "*()(*)";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod8_IsTrue()
        {
            string input = "(*(*)*()))";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod9_IsTrue()
        {
            string input = "*)(*";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod10_IsTrue()
        {
            string input = "(*";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod11_IsTrue()
        {
            string input = "*)";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod12_IsTrue()
        {
            string input = "(*()))*)";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod13_IsTrue()
        {
            string input = "**()))**";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod14_IsTrue()
        {
            string input = "*()*))*";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod15_IsTrue()
        {
            string input = "**(*(*)**";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod16_IsTrue()
        {
            string input = "(((*)*)";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestMethod17_IsTrue()
        {
            string input = "***(*(*)))***";
            var actual = validate.CheckValidString(input);

            Assert.IsTrue(actual);
        }
        
        #endregion

        #region IsFalse

        [Test]
        public void TestMethod1_IsFalse()
        {
            string input = "(()";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod2_IsFalse()
        {
            string input = "(((*)";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod3_IsFalse()
        {
            string input = "(*)))";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod4_IsFalse()
        {
            string input = "()()*(";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod5_IsFalse()
        {
            string input = ")*";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod6_IsFalse()
        {
            string input = "())*)";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod7_IsFalse()
        {
            string input = ")(";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod_especially1_IsFalse()
        {
            string input = "())*)*";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }
        
        [Test]
        public void TestMethod_especially2_IsFalse()
        {
            string input = "())**)";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod_especially3_IsFalse()
        {
            string input = "*((())";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod_especially4_IsFalse()
        {
            string input = "(**(()";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod_especially5_IsFalse()
        {
            string input = "*()))*";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod_especially6_IsFalse()
        {
            string input = "*()))**";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod_especially7_IsFalse()
        {
            string input = "*((()*";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod_especially8_IsFalse()
        {
            string input = "())((*)";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }

        [Test]
        public void TestMethod_especially9_IsFalse()
        {
            string input = "(())((())()()(*)(*()(())())())()()((()())((()))(*";
            var actual = validate.CheckValidString(input);

            Assert.IsFalse(actual);
        }
        #endregion
    }
}
