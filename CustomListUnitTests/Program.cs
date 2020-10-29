using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);
            testList.Add(item4);
            testList.Add(item5);
           

            CustomList<int> testList2 = new CustomList<int>();
            int itemA = 10;
            int itemB = 20;
            int itemC = 30;
            int itemD = 40;
            int itemE = 50;
            testList.Add(itemA);
            testList.Add(itemB);
            testList.Add(itemC);
            testList.Add(itemD);
            testList.Add(itemE);

            CustomList<int> testListOutput = new CustomList<int>();
            testListOutput = testList + testList2;
            Console.WriteLine(testListOutput);
            Console.ReadLine();





        }
    }
}
