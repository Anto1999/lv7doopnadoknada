using System;
using NUnit.Framework;
using lv7ponovno;
namespace lv7ponovnotest
{
    [TestFixture]
    public class PalindromDetectorTest
    {
        [TestCase("anavolimilovana")]
        [TestCase("AnavoliMilovana")]
        [TestCase("a")]
        [TestCase(" ")]
        [TestCase("Ana voli Milovana")]
        public void TestPalindormDetector(string input)
        {
            PalindromDetector palindromDetector = new PalindromDetector();
            Assert.IsTrue(palindromDetector.CheckIsPalindrom(input));
        }
        [TestCase("ananevolimilovana")]
        [TestCase("palindrom")]
        public void TestPalindormDetectorFalse(string input)
        {
            PalindromDetector palindromDetector = new PalindromDetector();
            Assert.IsFalse(palindromDetector.CheckIsPalindrom(input));
        }

    }
}
