using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge395;
using System;

namespace Challenge395Tests
{
    [TestClass]
    public class Challenge395Tests
    {
        [TestMethod]
        public void nonogramTester()
        {
            Challenge395Class c395 = new Challenge395Class();

            //refactored to a new function instead of repeating the call
            Array actual;
            Array expected;

            expected = Array.Empty<int>();
            actual = c395.nonogram(new int[] { });

            TheTest(expected, actual);

            expected = Array.Empty<int>();
            actual = c395.nonogram(new int[] { 0, 0, 0, 0, 0 });

            TheTest(expected, actual);

            expected = new int[] { 5 };
            actual = c395.nonogram(new int[] { 1, 1, 1, 1, 1 });

            TheTest(expected, actual);

            expected = new int[] { 5, 4 };
            actual = c395.nonogram(new int[] { 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 });

            TheTest(expected, actual);

            expected = new int[] { 2, 1, 3 };
            actual = c395.nonogram(new int[] { 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0 });

            TheTest(expected, actual);

            expected = new int[] { 2, 1, 3 };
            actual = c395.nonogram(new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1 });

            TheTest(expected, actual);

            expected = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            actual = c395.nonogram(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 });

            TheTest(expected, actual);

            //could be further refactored to have two lists of array values that can be looped through of input/output instead of calling each by one

        }

        [Ignore]
        [TestMethod]
        public void nonogramTester1()
        {
            Challenge395Class c395 = new Challenge395Class();

            //Started with this here (failed all but the inital skeleton function)
            //known outputs that should match            
            CollectionAssert.AreEqual(c395.nonogram(new int[] { }), new int[] { });
            CollectionAssert.AreEqual(c395.nonogram(new int[] { 0, 0, 0, 0, 0 }), new int[] { });
            CollectionAssert.AreEqual(c395.nonogram(new int[] { 1, 1, 1, 1, 1 }), new int[] { 5 });
            CollectionAssert.AreEqual(c395.nonogram(new int[] { 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 }), new int[] { 5, 4});
            CollectionAssert.AreEqual(c395.nonogram(new int[] { 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0 }), new int[] { 2, 1, 3});
            CollectionAssert.AreEqual(c395.nonogram(new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1 }), new int[] { 2, 1, 3});
            CollectionAssert.AreEqual(c395.nonogram(new int[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 }), new int[] { 1, 1, 1, 1, 1, 1, 1, 1 });
        }

        private void TheTest(Array expected, Array actual)
        {            
            if (expected.Length != actual.Length)
            {
                Assert.Fail("Expected length (" + expected.Length.ToString() + ") and actual length (" + actual.Length.ToString() + ") do not match.");
            }
            else
            {
                CollectionAssert.AreEqual(expected, actual, "Same number of elements but not in the same order.");
            }
        
        }

        //initial function from refactor
        private void TheTest1(Array expected, Array actual)
        {
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
