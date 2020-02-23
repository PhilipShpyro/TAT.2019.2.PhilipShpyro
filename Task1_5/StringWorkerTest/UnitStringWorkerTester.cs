using NUnit.Framework;
using Task1_5;

namespace StringWorkerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestShowMaxNotEqualSequenceIn()
        {
            Assert.AreEqual(StringWorker.ShowMaxNotEqualSequenceIn("agbdlciid1agbdlcid"), "id1agbdlcid");
        }
        [Test]
        public void TestShowMaxNotEqualDigitSequenceIn()
        {
            Assert.AreEqual(StringWorker.ShowMaxNotEqualDigitSequenceIn("IDDQD 9999888888"), "98");
        }
        [Test]
        public void TestShowMaxNotEqualLatinSequenceIn()
        {
            Assert.AreEqual(StringWorker.ShowMaxNotEqualLatinSequenceIn("IDONTLIKEPLAYINGGAMES"), "IDONTLIKEPLAYING");
        }
    }
}