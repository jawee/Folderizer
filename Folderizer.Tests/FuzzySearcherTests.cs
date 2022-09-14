using Folderizer.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Folderizer.Tests
{
    [TestClass]
    public class FuzzySearcherTests
    {
        [TestMethod]
        public void GetMatches_1()
        {
            var list = new List<string>()
            {
                "abc",
                "aabc",
                "bc",
            };

            var searcher = new FuzzySearcher();

            var results = searcher.GetMatches("ab", list);

            Assert.AreEqual(2, results.Count);
            Assert.IsFalse(results.Contains("bc"));
        }
        [TestMethod]
        public void GetMatches_2()
        {
            var list = new List<string>()
            {
                "abc",
                "aabc",
                "bc",
            };

            var searcher = new FuzzySearcher();

            var results = searcher.GetMatches("aab", list);

            Assert.AreEqual(1, results.Count);
            Assert.IsFalse(results.Contains("bc"));
            Assert.IsFalse(results.Contains("abc"));
        }
        [TestMethod]
        public void GetMatches_3()
        {
            var list = new List<string>()
            {
                "Abc",
                "aabc",
                "bc",
            };

            var searcher = new FuzzySearcher();

            var results = searcher.GetMatches("ab", list);

            Assert.AreEqual(2, results.Count);
            Assert.IsFalse(results.Contains("bc"));
        }
    }
}