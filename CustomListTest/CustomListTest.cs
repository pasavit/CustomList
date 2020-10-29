using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections;

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
            string expected = "2 4 4 6";
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
            string expected = "This is a test.";
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
            string expected = "True False True False";
            string actual;
            // Act
            actual = testList.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        //Operator+
        [TestMethod]
        public void Overload_TwoIntLists_ToOneList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testListTwo = new CustomList<int>();
            CustomList<int> testListResult = new CustomList<int>();
            CustomList<int> actual;
            testList.Add(2);
            testList.Add(4);
            testListTwo.Add(4);
            testListTwo.Add(6);
            testListResult.Add(2);
            testListResult.Add(4);
            testListResult.Add(4);
            testListResult.Add(6);
            CustomList<int> expected = testListResult;

            // Act
            actual = testList + testListTwo;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        
        [TestMethod]
        public void Overload_TwoStringLists_ToOneList()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            CustomList<string> testListTwo = new CustomList<string>();
            CustomList<string> testListResult = new CustomList<string>();
            CustomList<string> actual;
            testList.Add("This");
            testList.Add("is");
            testListTwo.Add("a");
            testListTwo.Add("test.");
            testListResult.Add("This");
            testListResult.Add("is");
            testListResult.Add("a");
            testListResult.Add("test.");
            CustomList<string> expected = testListResult;

            // Act
            actual = testList + testListTwo;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Overload_TwoIntListsButOneIsEmpty_ToOneList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testListTwo = new CustomList<int>();
            CustomList<int> testListResult = new CustomList<int>();
            CustomList<int> actual;
            testList.Add(2);
            testList.Add(4);
            testListResult.Add(2);
            testListResult.Add(4);
            CustomList<int> expected = testListResult;

            // Act
            actual = testList + testListTwo;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        //OPERATOR-
        [TestMethod]
        public void OverloadMinus_TwoIntLists_RemoveDupesInListTwoFromListOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testListTwo = new CustomList<int>();
            CustomList<int> testListResult = new CustomList<int>();
            CustomList<int> actual;
            testList.Add(2);
            testList.Add(4);
            testListTwo.Add(4);
            testListTwo.Add(6);
            testListResult.Add(2);
            CustomList<int> expected = testListResult;

            // Act
            actual = testList - testListTwo;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void OverloadMinus_TwoStringLists_RemoveDupesInListTwoFromListOne()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            CustomList<string> testListTwo = new CustomList<string>();
            CustomList<string> testListResult = new CustomList<string>();
            CustomList<string> actual;
            testList.Add("This");
            testList.Add("test");
            testList.Add("is");
            testList.Add("a");
            testList.Add("SUCCESS");
            testListTwo.Add("This");
            testListTwo.Add("is");
            testListTwo.Add("a");
            testListTwo.Add("test");
            testListResult.Add("SUCCESS");
            CustomList<string> expected = testListResult;

            // Act
            actual = testList - testListTwo;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void OverloadMinus_ListOneHasMultipleOfSame_RemoveAllDupesInListTwoFromListOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testListTwo = new CustomList<int>();
            CustomList<int> testListResult = new CustomList<int>();
            CustomList<int> actual;
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testListTwo.Add(4);
            testListTwo.Add(6);
            testListResult.Add(2);
            CustomList<int> expected = testListResult;

            // Act
            actual = testList - testListTwo;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        //ZIP METHOD
        [TestMethod]
        public void Zip_TwoIntLists_ToOneList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testListTwo = new CustomList<int>();
            CustomList<int> testListResult = new CustomList<int>();
            CustomList<int> actual;
            testList.Add(1);
            testList.Add(3);
            testList.Add(5);
            testListTwo.Add(2);
            testListTwo.Add(4);
            testListTwo.Add(6);
            testListResult.Add(1);
            testListResult.Add(2);
            testListResult.Add(3);
            testListResult.Add(4);
            testListResult.Add(5);
            testListResult.Add(6);
            CustomList<int> expected = testListResult;

            // Act
            actual = CustomList<int>.Zip(testList, testListTwo);

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Zip_TwoStringLists_ToOneList()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            CustomList<string> testListTwo = new CustomList<string>();
            CustomList<string> testListResult = new CustomList<string>();
            CustomList<string> actual;
            testList.Add("This");
            testList.Add("a");
            testList.Add("test");
            testListTwo.Add("is");
            testListTwo.Add("successful");
            testListResult.Add("This");
            testListResult.Add("is");
            testListResult.Add("a");
            testListResult.Add("successful");
            testListResult.Add("test");
            CustomList<string> expected = testListResult;

            // Act
            actual = CustomList<string>.Zip(testList, testListTwo);

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Zip_TwoIntListsOneIsEmpty_ToOneList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testListTwo = new CustomList<int>();
            CustomList<int> testListResult = new CustomList<int>();
            CustomList<int> actual;
            testList.Add(1);
            testList.Add(3);
            testList.Add(5);
            testListResult.Add(1);
            testListResult.Add(3);
            testListResult.Add(5);
            CustomList<int> expected = testListResult;

            // Act
            actual = CustomList<int>.Zip(testList, testListTwo);

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

    }
}
