using System;
using System.Collections.Generic;
using JT.Algorithm;
using Xunit;

namespace Calculate24.Test
{
    public class UnitTest1
    {

        #region 有解
        [Fact]
        public void Test1234()
        {
            var x = new Calculator24();
            var s = new List<int>() { 1, 2, 3, 4 };
            var r = x.CalculateNode(s.ToArray());

            Assert.Equal(24.0f, r.val);
        }

        [Fact]
        public void Test3899()
        {
            var x = new Calculator24();
            var s = new List<int>() { 3, 8, 9, 9 };
            var r = x.CalculateNode(s.ToArray());

            Assert.Equal(24.0f, r.val);
        }

        [Fact]
        public void Test1389()
        {
            var x = new Calculator24();
            var s = new List<int>() { 1, 3, 8, 9 };
            var r = x.CalculateNode(s.ToArray());

            Assert.Equal(24.0f, r.val);
        }
        [Fact]
        public void Test5551()
        {
            var x = new Calculator24();
            var s = new List<int>() { 1, 5, 5, 5 };
            var r = x.CalculateNode(s.ToArray());

            Assert.Equal(24.0f, r.val);
        }
        [Fact]
        public void Test1244()
        {
            var x = new Calculator24();
            var s = new List<int>() { 1, 2, 4, 4 };
            var r = x.CalculateNode(s.ToArray());

            Assert.Equal(24.0f, r.val);
        }
        [Fact]
        public void Test344()
        {
            var x = new Calculator24();
            var s = new List<int>() { 3, 4, 4 };
            var r = x.CalculateNode(s.ToArray());

            Assert.Equal(24.0f, r.val);
        }


        #endregion


        #region 无解
        [Fact]
        public void Test1189()
        {
            var x = new Calculator24();
            var s = new List<int>() { 1, 1, 8, 9 };
            var r = x.Calculate(s.ToArray());

            Assert.Equal("no answer", r);
        }

        [Fact]
        public void Test1557()
        {
            var x = new Calculator24();
            var s = new List<int>() { 1, 1, 8, 9 };
            var r = x.Calculate(s.ToArray());

            Assert.Equal("no answer", r);
        }

        [Fact]
        public void Test1700()
        {
            var x = new Calculator24();
            var s = new List<int>() { 1, 1, 8, 9 };
            var r = x.Calculate(s.ToArray());

            Assert.Equal("no answer", r);
        }

        [Fact]
        public void Test2555()
        {
            var x = new Calculator24();
            var s = new List<int>() { 1, 1, 8, 9 };
            var r = x.Calculate(s.ToArray());

            Assert.Equal("no answer", r);
        }

        #endregion
    }
}
