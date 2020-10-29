using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList_Proj;

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


        //Test to check that all items are removed
        [TestMethod]
        public void Remove_AddThenRemoveItems_CheckToSeeTheyAreAllGone()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int expected = 0;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Remove(item1);
            testList.Remove(item2);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        //Test to check that when one item is removed, the count goes down by one.
        [TestMethod]
        public void Remove_AddSeveralItems_ButOnlyRemoveOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int expected = 0;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Remove(item1);
            testList.Remove(item2);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        //Test to check that when one item is removed from the middle, the items slide down the index.
        [TestMethod]
        public void Remove_AddSeveralItemsThenRemoveOne_IndexShouldSlideToFillTheBlank()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            int expected = 50;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            testList.Remove(item3);
            actual = testList[3];

            // Assert
            Assert.AreEqual(expected, actual);
        }
        //Test that when multiple items with same value exist, and one is removed, the correct one is removed.
        [TestMethod]
        public void Remove_AddItemsWithSameValues_RemoveJustOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 10;
            int item3 = 10;
            int expected = 2;
            int actual;

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Remove(item2);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddingLists_UseThePlusOperatorWithTwoLists_FinalListCountShouldHaveAllItems()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            int expected = 10;
            int actual;

            //Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            testList2.Add(item1);
            testList2.Add(item2);
            testList2.Add(item3);
            testList2.Add(item4);
            testList2.Add(item5);
            testListOutput = testList + testList2;
            actual = testListOutput.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddingLists_AddListsSeveralTimes_FinalListCountShouldHaveAllItems()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            int expected = 20;
            int actual;

            //Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            testList2.Add(item1);
            testList2.Add(item2);
            testList2.Add(item3);
            testList2.Add(item4);
            testList2.Add(item5);
            testListOutput = testList + testList2 + testList2 + testList2;
            actual = testListOutput.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractLists_UseTheSubtractOperatorWithTwoLists_FinalListCountShouldBeLessByOne()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            int expected = 4;
            int actual;

            //Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            testList2.Add(item5);
            testListOutput = testList - testList2;
            actual = testListOutput.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractLists_UseTheSubtractOperatorWithTwoEqualLists_FinalListCountShouldBeZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            int expected = 0;
            int actual;

            //Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            testList2.Add(item1);
            testList2.Add(item2);
            testList2.Add(item3);
            testList2.Add(item4);
            testList2.Add(item5);
            testListOutput = testList - testList2;
            actual = testListOutput.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractLists_UseTheSubtractOperatorWithTwoDifferentLists_FinalListCountShouldNotChange()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            int item6 = 5;
            int item7 = 15;
            int item8 = 25;
            int expected = 5;
            int actual;

            //Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            testList2.Add(item6);
            testList2.Add(item7);
            testList2.Add(item8);

            testListOutput = testList - testList2;
            actual = testListOutput.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddingAndSubtractingLists_AddListsTogetherThenSubtactLists_FinalCountShouldOnlyShowCurrentItems()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            int item6 = 5;
            int item7 = 15;
            int item8 = 25;
            int expected = 5;
            int actual;

            //Act
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
            testList2.Add(item3);
            testList2.Add(item4);
            testList2.Add(item5);
            testList2.Add(item6);
            testList2.Add(item7);
            testList2.Add(item8);
            testList3.Add(item3);
            testList3.Add(item4);
            testList3.Add(item5);


            testListOutput = testList + testList2 - testList3;
            actual = testListOutput.Count;
        }
        [TestMethod]
        public void ToStringMethod_AddItemsToList_DisplayItemsInList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            string expected = "10";

            // Act
            testList.Add(item1);
            string actual = testList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToStringMethod_AddTwoLists_DisplayTotalList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            string expected = "10, 20";

            // Act
            testList.Add(item1);
            testList2.Add(item2);
            testListOutput = testList + testList2;
            string actual = testListOutput.ToString();

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ToStringMethod_SubtractTwoLists_DisplayTotalList()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            string expected = "10";

            // Act
            testList.Add(item1);
            testList.Add(item2);
            testList2.Add(item2);
            testListOutput = testList - testList2;
            string actual = testListOutput.ToString();

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Zip_CombineTwoLists_OutputShouldBeAlternatingItemsFromBothLists()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 4;
            string expected = "1, 2, 3, 4";
            string actual;

            //Act
            testList.Add(item1);
            testList.Add(item3);
            testList2.Add(item2);
            testList2.Add(item4);
            testListOutput = testListOutput.Zip(testList, testList2);
            actual = testListOutput.ToString();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Zip_CombineTwoListsAndThenTwoMoreLists_OutputShouldBeAlternatingItemsFromAllLists()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            CustomList<int> testList4 = new CustomList<int>();
            CustomList<int> testList5 = new CustomList<int>();
            CustomList<int> testList6 = new CustomList<int>();
            CustomList<int> testListOutput = new CustomList<int>();
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int item4 = 4;
            string expected = "1, 1, 2, 2, 3, 3, 4, 4";
            string actual;

            //Act
            testList.Add(item1);
            testList.Add(item3);
            testList2.Add(item2);
            testList2.Add(item4);
            testList3.Add(item1);
            testList3.Add(item3);
            testList4.Add(item2);
            testList4.Add(item4);
            testList5 = testList5.Zip(testList, testList2);
            testList6 = testList6.Zip(testList3, testList4);
            testListOutput = testListOutput.Zip(testList5, testList6);
            actual = testListOutput.ToString();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
