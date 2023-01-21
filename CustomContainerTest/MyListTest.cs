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

            Assert.AreEqual(1, li[0]);
        }

        [TestMethod]
        public void AddingCoupleValues()
        {
            var li = new MyList<int>();

            int[] nums = { 1, 2, 4, 6 };
            foreach (int num in nums)
                li.Append(num);

            for (int i = 0; i < nums.Length; i++)
                Assert.AreEqual(nums[i], li[i]);
        }

        [TestMethod]
        public void StringListCheck()
        {
            var li = new MyList<string>();

            li.Append("abc");
            li.Append("def");

            Assert.AreEqual("abc", li[0]);
        }

        [TestMethod]
        public void ClearList()
        {
            var li = new MyList<string>();

            li.Append("abc");
            li.Append("def");
            li.Clear();

            Assert.AreEqual(0, li.Count);

            li.Append("ceg");
            Assert.AreEqual("ceg", li[0]);
        }

        [TestMethod]
        public void ForEachTest()
        {
            var li = new MyList<int>();

            int[] nums = { 1, 2, 4, 6 };
            foreach (int num in nums)
                li.Append(num);

            int i = 0;
            foreach (int element in li)
                Assert.AreEqual(nums[i++], element);
        }

        [TestMethod]
        public void IndexWork()
        {
            var li = new MyList<int>();

            int[] nums = { 1, 2, 4, 6 };
            foreach (int num in nums)
                li.Append(num);

            for (int i = 0; i < li.Count; i++)
                Assert.AreEqual(nums[i], li[i]);
        }
    }
}
