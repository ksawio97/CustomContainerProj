using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomContainer;

namespace CustomContainerTest
{
    [TestClass]
    public class MyListTest
    {
        [TestMethod]
        public void CreatingEmptyList()
        {
            var li = new MyList<int>();

            Assert.AreEqual(0, li.Count);
        }

        [TestMethod]
        public void AddingValue()
        {
            var li = new MyList<int>();

            li.Append(1);

            Assert.AreEqual(1, li.Show(0));
        }

        [TestMethod]
        public void AddingCoupleValues()
        {
            var li = new MyList<int>();

            int[] nums = { 1, 2, 4, 6 };
            foreach (int num in nums)
                li.Append(num);

            for (int i = 0; i < nums.Length; i++)
                Assert.AreEqual(nums[i], li.Show(i));
        }

        [TestMethod]
        public void StringListCheck()
        {
            var li = new MyList<string>();

            li.Append("abc");
            li.Append("def");

            Assert.AreEqual("abc", li.Show(0));
        }
    }
}
