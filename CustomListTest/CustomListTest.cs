using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        //INDEXER METHOD
        [TestMethod]
        public void Check_ItemAtIndex3_Int6()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            int expected = 6;
            int actual;

            // Act
            actual = testList[3]; 

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        //[TestMethod]
        //public void Check_InvalidIndex_ExceptionThrown()
        //{
        //    // Arrange
        //    CustomList<int> testList = new CustomList<int>();
        //    testList.Add(2);
        //    testList.Add(4);
        //    testList.Add(4);
        //    testList.Add(6);
        //    var expected = new IndexOutOfRangeException();
        //    int actual;

        //    // Act
        //    actual = testList[5]; 

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

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
            actual = testList[0]; 
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
            actual = testList.Count; 
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
            actual = testList[4];

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
            actual = testList.Count; 
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
            actual = testList.Capacity;

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
            actual = testList[0]; 
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
            actual = testList.Count;
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
            actual = testList[2]; 
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
            actual = testList.Count; 
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
            actual = testList.Count; 
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
            int expected = 3;
            int actual;
            // Act
            testList.Remove(4);
            actual = testList.Count; 
            // Assert
            Assert.AreEqual(expected, actual);
        }

        //TOSTRING
        [TestMethod]
        public void ListToString_AddFourIntsToList_PrintFourIntsInString()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);
            string expected = "2, 4, 4, 6";
            string actual;
            // Act
            actual = testList.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ListToString_AddFourStringsToList_PrintFourStringsInString()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("This");
            testList.Add("is");
            testList.Add("a");
            testList.Add("test.");
            string expected = "This, is, a, test.";
            string actual;
            // Act
            actual = testList.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ListToString_AddFourBoolsToList_PrintFourBoolsInString()
        {
            // Arrange
            bool test1 = true;
            bool test2 = false;
            bool test3 = true;
            bool test4 = false;
            CustomList<bool> testList = new CustomList<bool>();
            testList.Add(test1);
            testList.Add(test2);
            testList.Add(test3);
            testList.Add(test4);
            string expected = "true, false, true, false";
            string actual;
            // Act
            actual = testList.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
