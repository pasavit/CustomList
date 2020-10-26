using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestStarter;

namespace CustomListTests
{
    [TestClass]
    public class CustomListUnitTests
    {

        //ADD METHOD
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 10;
            int actual;

            // Act
            testList.Add(item);
            actual = testList[0]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Count; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToPopulatedList_ItemGoesToLastIndex()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int expected = 10;
            int actual;

            // Act
            testList.Add(item);
            actual = testList[4]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_AddItemToPopulatedList_CountIncrementsByOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int expected = 5;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Count; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_AddMoreItemsThanCurrentCapacity_CapacityDoubles()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int expected = 8;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Capacity; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        //REMOVE METHODS
        [TestMethod]
        public void Remove_RemoveItemFromList_FourGoesToIndexZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int item = 2;
            int expected = 4;
            int actual;
            // Act
            testList.Remove(item);
            actual = testList[0]; // error expected until "indexer property" is added to class
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveNonExistingItem_CountRemainsTheSame()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int item = 3;
            int expected = 4;
            int actual;
            // Act
            testList.Remove(item);
            actual = testList.Count(); // error expected until "Count" is added to class
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveItemOnceFromList_SixAtIndexTwo()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int item = 4;
            int expected = 6;
            int actual;
            // Act
            testList.Remove(item);
            actual = testList[2]; // error expected until "indexer property" is added to class
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveNumberTwoFromList_CountDecrementsByOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int item = 2;
            int expected = 3;
            int actual;
            // Act
            testList.Remove(item);
            actual = testList.Count; // error expected until "Count" is added to class
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveAllFromList_CountOfZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int expected = 0;
            int actual;
            // Act
            testList.Remove(2);
            testList.Remove(4);
            testList.Remove(4);
            testList.Remove(6);
            actual = testList.Count; // error expected until "Count" is added to class
            // Assert
            Assert.AreEqual(expected, actual);
        }  
        [TestMethod]
        public void Remove_RemoveOneOfTwoSameItemFromList_CountOfOneItem()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int expected = 1;
            int actual;
            // Act
            testList.Remove(4);
            actual = testList.Count(4); // error expected until "Count" is added to class
            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        //[TestMethod]
        //public void Find_FindFirstIndexOf4_IndexOf1()
        //{
        //    // Arrange
        //    CustomList<int> testList = new CustomList<int>() { 2, 4, 4, 6 };
        //    int expected = 1;
        //    int actual;

        //    // Act
        //    actual = testList.IndexOf(4); // error expected until "Count" is added to class

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}
        
        //[TestMethod]
        //public void Find_FindLastIndexOf4_IndexOf2()
        //{
        //    // Arrange
        //    CustomList<int> testList = new CustomList<int>() { 2, 4, 4, 6 };
        //    int expected = 1;
        //    int actual;

        //    // Act
        //    actual = testList.IndexOf(4); // error expected until "Count" is added to class

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}



        // what if i .Add to a list that has a couple things in it already (position of item)?
        // what if i .Add to a list that has a couple things in it already (value of Count)?
        // how does the Capacity change as you add things? (starts at 4, and doubles)

        // REMOVE TESTS:
    }
}
