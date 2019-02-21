using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_112_collections;
using lab_113_arraylist;

namespace labs_tests
{
    [TestClass]
    public class LabsTest
    {
        [TestMethod]
        public void Lab112CollectionsTest()
        {
            // Arrange 
            var expected01 = 22400;
            var instanceLab112Collection = new Collection();
            // act
            var actual01 = instanceLab112Collection.Collection20MinLab(10, 20, 30);
            // assert
            Assert.AreEqual(expected01, actual01);
        }
        [TestMethod]
        public void Lab112CollectionsTest2()
        {
            // Arrange 
            var expected02 = 7312;

            var instanceLab112Collection = new Collection();
            // act
            var actual02 = instanceLab112Collection.Collection20MinLab(12, 12, 13);
            // assert
            Assert.AreEqual(expected02, actual02);
        }
        [TestMethod]
        public void Lab113ArrayListTest()
        {
            // arrange 
            var expected = -10;
            var instanceLab113 = new ArrayList1();
            // act 
            var actual = instanceLab113.ArrayListMethod(10, 20, 30, 40);
            // assert
            Assert.AreEqual(expected,actual);
        }

    }
}
