using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForCustomList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingItemsToEmptyList_ItemIndexIsZero()
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
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // what if i .Add to a list that has a couple things in it already (position of item)?
        [TestMethod]
        public void Add_AddItemToFilledList_ItemIndexesToNextIndex()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 15;
            int item3 = 20;
            int expected = 20;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            actual = testList[2];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        // what if i .Add to a list that has a couple things in it already (value of Count)?

        [TestMethod]
        public void Add_AddingItemsToList_CountIsTotalItemsInList()
        {   //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 15;
            int item3 = 20;
            int indexCount = testList.Count;
            int expected = 3;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // how does the Capacity change as you add things? (starts at 4, and doubles)
        [TestMethod]
        public void Add_AddingItemsToCapacity_CapacityDoubles()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 15;
            int item3 = 20;
            int item4 = 25;
            int item5 = 30;
            int expected = 8;
            int actual;

            //Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            actual = testList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        // REMOVE TESTS:
        // To remove items, the items will need to be added first.

        [TestMethod]
        //Test to check that all items are removed
        //Test to check that when one item is removed, the count goes down by one.
        //Test to check that when one item is removed from the middle, the items slide down the index.
        //

    }
    
        

}
