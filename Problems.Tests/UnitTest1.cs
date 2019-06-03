using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program testone = new Program();
            string test1 = testone.Prefix("well");
            Assert.AreEqual("4,1: well", test1);
        }
        public void Test2()
        {
            Program testtwo = new Program();
            string test2 = testtwo.Prefix("");
            Assert.AreEqual("0,1: ",test2);
        }
        public void Test3()
        {
            Program testthree = new Program();
            string test3 = testthree.Prefix("what  ..  did");
            Assert.AreEqual("13,7: what  ..  did", test3);
        }
        public void Test4()
        {
            Program testfour = new Program();
            string test4 = testfour.Prefix(null);
            Assert.AreEqual(null, test4);
        }
    }
}